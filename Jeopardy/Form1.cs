using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Collections;
using DF1Comm;
using Ini;

namespace Jeopardy
{
    public partial class Form1 : Form
    {
        frmView QuestionForm;
        public IniFile SettingsIni;

        //global settings:
        //buzzer related (time in ms)
        int gTimerDelay = 3000;
        int gBuzzerLength = 1000;

        //global variables to keep track of the level/question/category
        string gLevel = "0";
        string gQuestion = "0";
        string gCategory = "0";

        //global variables to keep track of person answering
        volatile int gActivePlayer = -1;

        //global variables to determine if the Question or Answer has changed
        bool QChanged = false;
        bool AChanged = false;

        //temp file location
        public string tempfile = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing();
        }

        private void closing()
        {
            if (tempfile != "")
            {
                if (File.Exists(tempfile))
                {
                    File.Delete(tempfile);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (chkPLC.Checked)
            {
                //reset standard lock bits
                dF1Comm1.WriteData("B3:10/0", 0);
                dF1Comm1.WriteData("B3:0", 0);
                dF1Comm1.WriteData("B3:14", 0);

                //reset order accumulator
                dF1Comm1.WriteData("C5:0.ACC", 0);

                //reset player order locks
                dF1Comm1.WriteData("N7:0", 0);
                dF1Comm1.WriteData("N7:1", 0);
                dF1Comm1.WriteData("N7:2", 0);
                dF1Comm1.WriteData("N7:3", 0);
                dF1Comm1.WriteData("N7:4", 0);
                dF1Comm1.WriteData("N7:5", 0);
                dF1Comm1.WriteData("N7:6", 0);
                dF1Comm1.WriteData("N7:7", 0);
                dF1Comm1.WriteData("N7:8", 0);
                dF1Comm1.WriteData("N7:9", 0);

                //stop software timer
                StopTimer();

                //stop buzzer
                BuzzerStop();

                //read PLC memory
                PLC_Read();
            }
            else
            {
                listOrder.Items.Clear();
                SendListUpdate(listOrder);
            }
        }

        private void view_mon(int index, Form SendForm)
        {
            //sends the view screen to a particular monitor
            Screen[] sc;
            sc = Screen.AllScreens;
            //get all the screen width and heights
            SendForm.FormBorderStyle = FormBorderStyle.None;
            SendForm.Left = sc[index].Bounds.Width;
            SendForm.Top = sc[index].Bounds.Height;
            SendForm.StartPosition = FormStartPosition.Manual;
            SendForm.Location = sc[index].Bounds.Location;
            Point p = new Point(sc[index].Bounds.Location.X, sc[index].Bounds.Location.Y);
            SendForm.Location = p;
            //SendForm.WindowState = FormWindowState.Maximized;
            SendForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuestionForm = new frmView(this);
            populateScreenList();

            //auto-open viewscreen on screen 0, perhaps disable this
            view_mon(0, QuestionForm);
        }

        private void ShowTitlePage()
        {
            //TODO: Title Page
        }

        private void PopulateScreen(int level)
        {
            //establish well-used ini headings
            gLevel = level.ToString();
            string LevelStr = "LEVEL" + level.ToString();
            string QAStr = "QA" + level.ToString();

            //get number of categories
            int num_cat = int.Parse(SettingsIni.IniReadValue(LevelStr, "categories"));
            int num_qs = int.Parse(SettingsIni.IniReadValue(LevelStr, "questions"));
            int base_value = int.Parse(SettingsIni.IniReadValue(LevelStr, "base"));
            
            //get round name
            string jeo_title = SettingsIni.IniReadValue(LevelStr, "name");

            //get all category names
            string[] categoryNames = new string[num_cat];
            for (int i = 0; i < num_cat; i++)
            {
                categoryNames[i] = SettingsIni.IniReadValue(LevelStr, "h" + (i+1).ToString());
            }

            //remove any old items in the groupbox
            grpBoardControl.Controls.Clear();
            foreach (Control c in grpBoardControl.Controls)
            {
                grpBoardControl.Controls.Remove(c);
            }

            //get groupbox location and size
            Point grpLocation = grpBoardControl.Location;
            int grpWidth = grpBoardControl.Width;
            int grpHeight = grpBoardControl.Height;
            int catWidth = (int)((grpWidth-20) / num_cat);

            //add new headings
            for (int i=0; i< num_cat; i++)
            {
                Label L = new Label();
                L.Name = "CatLabel" + i.ToString();
                L.Size = new Size(catWidth, 30);
                L.Location = new Point(grpLocation.X + (i * catWidth), 20);
                L.Text = categoryNames[i];
                L.TextAlign = ContentAlignment.MiddleCenter;
                grpBoardControl.Controls.Add(L);
            }

            //add buttons
            int btnHeight = (int)((grpHeight - 55) / num_qs);
            for (int i = 0; i < num_cat; i++)
            {
                for (int j = 0; j < num_qs; j++)
                {
                    Button B = new Button();
                    B.Name = "btnQ" + ((i + 1).ToString() + (j + 1).ToString()).ToString();
                    B.Size = new Size(catWidth, btnHeight);
                    B.Location = new Point(grpLocation.X + (i * catWidth), 50 + (j*btnHeight));
                    B.Text = ((j+1)*base_value).ToString();
                    B.TextAlign = ContentAlignment.MiddleCenter;
                    B.Tag = new string[]{level.ToString(),(i + 1).ToString() + (j + 1).ToString()};
                    B.Click += new EventHandler(btnQ_Click);
                    grpBoardControl.Controls.Add(B);
                }
            }

            grpBoardControl.Text = jeo_title;

            if (QuestionForm.Visible)
            {
                QuestionForm.PopulateSelectionScreen(jeo_title, categoryNames, num_qs, base_value, level);
            }
        }

        #region QAControls

        public void btnClicker(string[] question)
        {
            Button clickedBtn = (Button)(grpBoardControl.Controls["btnQ" + question[1]]);
            if (clickedBtn.BackColor != Color.Red)
            {
                //show button as red
                clickedBtn.BackColor = Color.Red;
            }
            else
            {
                //reset button to gray
                clickedBtn.BackColor = SystemColors.Control;
                if (QuestionForm.Visible)
                {
                    QuestionForm.BtnToggle("btnQ" + question[1]);
                }
                return;
            }

            gLevel = question[0];
            gQuestion = question[1];
            gCategory = question[1].Substring(0,1);

            string Q, A, C;

            try
            {
                Q = SettingsIni.IniReadValue("QA" + question[0], "q" + question[1]);
            }
            catch
            {
                Q = "Question Missing";
            }

            try
            {
                A = SettingsIni.IniReadValue("QA" + question[0], "r" + question[1]);
            }
            catch
            {
                A = "Answer Missing.";
            }

            try
            {
                C = SettingsIni.IniReadValue("LEVEL" + question[0], "h" + gCategory);
            }
            catch
            {
                C = "";
            }

            txtQuestion.Text = Q;
            txtAnswer.Text = A;
            txtCategory.Text = C;

            if (QuestionForm.Visible)
            {
                if ((C == "")||(!showCategoryToolStripMenuItem.Checked))
                {
                    QuestionForm.UpdateScreenQA(Q, A);
                }
                else
                {
                    QuestionForm.UpdateScreenQA(C, Q, A);
                }

                QuestionForm.BtnToggle("btnQ" + question[1]);
                QChanged = false;
                AChanged = false;
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            string[] question = (string[])((Button)sender).Tag;
            txtCurrentValue.Text = ((Button)sender).Text;
            btnClicker(question);
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            //update the question if the text has changed
            if (QChanged || AChanged)
            {
                if ((txtCategory.Text == "")||(!showCategoryToolStripMenuItem.Checked))
                {
                    QuestionForm.UpdateScreenQA(txtQuestion.Text, txtAnswer.Text);
                }
                else
                {
                    QuestionForm.UpdateScreenQA(txtCategory.Text, txtQuestion.Text, txtAnswer.Text);
                }
            }

            //click the answer button
            btnAnswer.BackColor = (QuestionForm.AnswerButton()) ? Color.Red : SystemColors.Control;

            //reset question and answer change flags
            QChanged = false;
            AChanged = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (QuestionForm.Visible)
            {
                QuestionForm.NextQuestion();
            }
        }

        #endregion

        #region toolstripControls

        private void populateScreenList()
        {
            //creates a list of screens in the menu
            int i;
            string temp1="";
            Screen[] sc;
            sc = Screen.AllScreens;
            
            sendToToolStripMenuItem.DropDownItems.Clear();
            //screenList.Items.Clear();
            
            i = 0;
            foreach (Screen mon in sc)
            {
                temp1 = mon.DeviceName;
                if (mon.Primary)
                {
                    temp1 += " (Primary)";
                }

                sendToToolStripMenuItem.DropDownItems.Add(temp1);
                sendToToolStripMenuItem.DropDownItems[i].Tag = i;
                sendToToolStripMenuItem.DropDownItems[i].Click += new System.EventHandler(ScreenChooseClick);

                //screenList.Items.Add(temp1);
            }
            
            //screenList.SelectedIndex = 0;
        }

        private void ScreenChooseClick(object sender, EventArgs e)
        {
            int screen_index = (int)(((ToolStripDropDownItem)sender).Tag);
            QuestionForm.Show();
            view_mon(screen_index, QuestionForm);
        }

        private void refreshAvailableDisplaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateScreenList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (QuestionForm.Visible)
                {   //re-initialize the title-shown variable every time a Jeopardy is opened
                    QuestionForm.TitleShown = false;
                }

                try
                {
                    SettingsIni = new IniFile(openFileDialog1.FileName);
                    PopulateScreen(1);
                }
                catch
                {
                    MessageBox.Show("The file is not valid.", "File Error");
                    return;
                }

                //get location of temp file (and make file)
                tempfile = Path.Combine(Path.GetDirectoryName(SettingsIni.path), "jeopardizertemp.html");

                try
                {
                    File.WriteAllText(tempfile, "");
                }
                catch
                {
                    //do nothing
                }
            }
        }

        private void saveQAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsIni.IniWriteValue("QA" + gLevel, "q" + gQuestion, txtQuestion.Text);
                SettingsIni.IniWriteValue("QA" + gLevel, "r" + gQuestion, txtAnswer.Text);
            }
            catch
            {
                MessageBox.Show("The question and answer could not be saved.", "Save Failed");
            }
        }

        private void nextLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = int.Parse(gLevel) + 1;
            int limit = int.Parse(SettingsIni.IniReadValue("MAIN", "levels"));

            if (num > limit)
            {
                num = limit;
            }

            PopulateScreen(num);
        }

        private void previousLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = int.Parse(gLevel) - 1;
            int limit = int.Parse(SettingsIni.IniReadValue("MAIN", "levels"));

            if (num < 1)
            {
                num = 1;
            }

            PopulateScreen(num);
        }

        private void numberNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPlayer1.Text = "1";
            txtPlayer2.Text = "2";
            txtPlayer3.Text = "3";
            txtPlayer4.Text = "4";
            txtPlayer5.Text = "5";
            txtPlayer6.Text = "6";
            txtPlayer7.Text = "7";
            txtPlayer8.Text = "8";
        }

        private void teamNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPlayer1.Text = "Team 1";
            txtPlayer2.Text = "Team 2";
            txtPlayer3.Text = "Team 3";
            txtPlayer4.Text = "Team 4";
            txtPlayer5.Text = "Team 5";
            txtPlayer6.Text = "Team 6";
            txtPlayer7.Text = "Team 7";
            txtPlayer8.Text = "Team 8";
        }

        private void playerNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPlayer1.Text = "Player 1";
            txtPlayer2.Text = "Player 2";
            txtPlayer3.Text = "Player 3";
            txtPlayer4.Text = "Player 4";
            txtPlayer5.Text = "Player 5";
            txtPlayer6.Text = "Player 6";
            txtPlayer7.Text = "Player 7";
            txtPlayer8.Text = "Player 8";
        }

        private void toggleViewScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestionForm.Visible = !QuestionForm.Visible;
        }

        private void showTitleImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QuestionForm.Visible)
            {
                QuestionForm.ShowTitle(true);
            }
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOrder.Items.Add("0, hello");
            SendListUpdate(listOrder);
        }

        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listOrder.Items.Add("1, hello");
            SendListUpdate(listOrder);
        }

        #region HidePanelLayout

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QuestionForm.Visible)
            {
                QuestionForm.ChangeHidePanelLayout(ImageLayout.Center);
            }
        }

        private void stretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QuestionForm.Visible)
            {
                QuestionForm.ChangeHidePanelLayout(ImageLayout.Stretch);
            }
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QuestionForm.Visible)
            {
                QuestionForm.ChangeHidePanelLayout(ImageLayout.Zoom);
            }
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QuestionForm.Visible)
            {
                QuestionForm.ChangeHidePanelLayout(ImageLayout.Tile);
            }
        }

        #endregion

        #endregion

        #region PLCFunctions

        private void UpdateActivePlayer(int player, bool start_timer)
        {
            //function to change the global variable gActivePlayer
            //also allows the timer to start, only if the player is new/next

            if (player != gActivePlayer)
            {
                gActivePlayer = player;
                if (start_timer)
                {
                    StopTimer();
                    StartTimer(gTimerDelay, gBuzzerLength);
                }
            }

        }

        private void PLC_Timer_Tick(object sender, EventArgs e)
        {
            if (chkPLC.Checked)
            {
                try
                {
                    PLC_Read();
                }
                catch
                {
                    chkPLC.Checked = false;
                    MessageBox.Show("PLC Error, communication disabled.", "PLC Com Error");
                }
            }
        }

        private void PLC_Read()
        {
            if (chkPLC.Checked)
            {
                int[] OrderStatus = dF1Comm1.ReadInt("N7:0", 9);

                int nonZeros = OrderStatus.Count(x => x > 0);
                int adjust = OrderStatus.Max() - nonZeros;
                for (int i = 0; i < OrderStatus.Length; i++)
                {
                    OrderStatus[i] = OrderStatus[i] - adjust;
                }

                if (OrderStatus.Max() > 0)
                {
                    //int[] PlayerOrder = new int[OrderStatus.Count(x => x>0)];
                    int[] PlayerOrder = new int[OrderStatus.Max()];

                    //fill PlayerOrder list with a list of the players, in the order they buzzed in
                    for (int i = 0; i < OrderStatus.Length; i++)
                    {
                        if (OrderStatus[i] > 0)
                        {
                            PlayerOrder[OrderStatus[i] - 1] = i;
                        }
                    }

                    //read player names
                    string[] players = new string[]{txtPlayer1.Text,txtPlayer2.Text,txtPlayer3.Text,txtPlayer4.Text,
                    txtPlayer5.Text,txtPlayer6.Text,txtPlayer7.Text,txtPlayer8.Text,"Feud 1","Feud 2"};

                    //fill a list box with this info
                    listOrder.Items.Clear();
                    for (int i = 0; i < PlayerOrder.Length; i++)
                    {
                        listOrder.Items.Add(PlayerOrder[i].ToString() + ", " + players[PlayerOrder[i]]);
                    }

                    UpdateActivePlayer(PlayerOrder[0], true);
                }
                else
                {
                    listOrder.Items.Clear();
                    UpdateActivePlayer(-1, false);
                }
            }

        }

        private void chkPLC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPLC.Checked)
            {
                try
                {
                    //enable additional logic
                    dF1Comm1.WriteData("B3:12/0", 1);
                    //disable standard beeper
                    dF1Comm1.WriteData("B3:12/1", 1);
                }
                catch
                {
                    chkPLC.Checked = false;
                }
            }
            else
            {
                try
                {
                    //disable additional logic
                    dF1Comm1.WriteData("B3:12/0", 0);
                    //enable standard beeper
                    dF1Comm1.WriteData("B3:12/1", 0);
                }
                catch
                {
                    //doesn't matter if this fails
                }
            }
        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            StopTimer();

            string temp1;
            int addressPart;
            if (listOrder.Items.Count > 0)
            {
                if (chkPLC.Checked)
                {
                    try
                    {
                        PLC_Timer.Enabled = false;

                        //for (int i = 0; i < listOrder.Items.Count; i++)
                        //{
                        //    temp1 = ((string)listOrder.Items[i]).Split(',')[0];
                        //    addressPart = int.Parse(temp1);
                        //    dF1Comm1.WriteData("N7:" + addressPart.ToString(), i);
                        //}

                        temp1 = ((string)listOrder.Items[0]).Split(',')[0];
                        addressPart = int.Parse(temp1);
                        dF1Comm1.WriteData("N7:" + addressPart.ToString(), 0);

                        PLC_Read();
                        PLC_Timer.Enabled = true;
                    }
                    catch
                    {
                        chkPLC.Checked = false;
                        PLC_Timer.Enabled = true;
                    }
                }
            }
        }

        private void SendListUpdate(ListBox list1)
        {
            int count = list1.Items.Count;
            int temp1;

            //make blank arrays
            string[] names = new string[]{"","","","","","","","","",""};
            Color blank = SystemColors.Control;
            Color[] colors = new Color[] { blank, blank, blank, blank, blank, blank, blank, blank, blank, blank };

            //create source arrays
            //read player names
            string[] players = new string[]{txtPlayer1.Text,txtPlayer2.Text,txtPlayer3.Text,txtPlayer4.Text,
                    txtPlayer5.Text,txtPlayer6.Text,txtPlayer7.Text,txtPlayer8.Text,"Feud 1","Feud 2"};
            //get colors
            Color[] playerColors = new Color[]{txtPlayer1.BackColor,txtPlayer2.BackColor,txtPlayer3.BackColor,txtPlayer4.BackColor,
                    txtPlayer5.BackColor,txtPlayer6.BackColor,txtPlayer7.BackColor,txtPlayer8.BackColor,blank,blank};

            if (count > 0)
            {
                for (int i = 0; ((i < count) && (i < 10)); i++)
                {
                    temp1 = int.Parse(((string)list1.Items[i]).Split(',')[0]);
                    colors[i] = playerColors[temp1];
                    names[i] = players[temp1];
                }
            }

            QuestionForm.UpdateOrder(names, colors);
        }
        
        #endregion

        #region BuzzerFunctions

        private void bkgTimer_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] inputs = e.Argument as int[];
            if (inputs.Length != 2)
            {
                e.Cancel = true;
                return;
            }

            int WaitTime = inputs[0];
            int BeepTime = inputs[1];

            DateTime startTime = DateTime.Now;

            while (DateTime.Now.Subtract(startTime).TotalMilliseconds < WaitTime)
            {
                if (bkgTimer.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    bkgTimer.ReportProgress((int)((DateTime.Now.Subtract(startTime).TotalMilliseconds / WaitTime)*100));
                    Thread.Sleep(100);
                }
            }

            bkgTimer.ReportProgress(100);

            BuzzerBeep(BeepTime,bkgTimer,e);
        }

        private void StartTimer(int TimerLength, int BeepLength)
        {
            bkgTimer.RunWorkerAsync(new int[] {TimerLength, BeepLength});
        }

        private void StopTimer()
        {
            if (bkgTimer.IsBusy)
            {   //only stop the timer if it is running
                try
                {
                    bkgTimer.CancelAsync();
                }
                catch
                {
                    //does it ever fail?
                }
            }
            BuzzerStop();
        }

        private void BuzzerBeep(int duration, BackgroundWorker worker, DoWorkEventArgs e)
        {
            DateTime startTime = DateTime.Now;

            //start beep
            dF1Comm1.WriteData("B3:12/2", 1);

            while (DateTime.Now.Subtract(startTime).TotalMilliseconds < duration)
            {
                if (worker.CancellationPending)
                {
                    //stop beep and exit
                    BuzzerStop();
                    e.Cancel = true;
                    return;
                }
                else
                {
                    Thread.Sleep(100);
                }
            }

            //stop beep
            BuzzerStop();
        }

        private void BuzzerBeep(int duration)
        {
            //does not support cancellation, keeps on beeping once started till duration elapses

            DateTime startTime = DateTime.Now;

            //start beep
            dF1Comm1.WriteData("B3:12/2", 1);

            while (DateTime.Now.Subtract(startTime).TotalMilliseconds < duration)
            {
                Thread.Sleep(100);
            }

            //stop beep
            BuzzerStop();
        }

        private void BuzzerStop()
        {
            //stop beep
            dF1Comm1.WriteData("B3:12/2", 0);
        }

        private void bkgTimer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            timerBar.Value = e.ProgressPercentage;
            timerBar.Update();
            QuestionForm.UpdateTimer(timerBar.Value);
        }

        #endregion

        #region score_handles
        //event handles for the score add/subtract buttons
        
        private void score_add(object sender, EventArgs e)
        {   //add the current score to a player
            TextBox[] scores = new TextBox[]{new TextBox(),txtScore1,txtScore2,txtScore3,txtScore4,txtScore5,txtScore6,txtScore7,txtScore8};
            int index = int.Parse((string)((Button)sender).Tag);
            scores[index].Text = (int.Parse(scores[index].Text) + int.Parse(txtCurrentValue.Text)).ToString();
        }

        private void score_sub(object sender, EventArgs e)
        {   //subtracts the current score from a player
            TextBox[] scores = new TextBox[] { new TextBox(), txtScore1, txtScore2, txtScore3, txtScore4, txtScore5, txtScore6, txtScore7, txtScore8 };
            int index = int.Parse((string)((Button)sender).Tag);
            scores[index].Text = (int.Parse(scores[index].Text) - int.Parse(txtCurrentValue.Text)).ToString();
        }

        private void score_hlf(object sender, EventArgs e)
        {   //subtracts half the current score from a player
            TextBox[] scores = new TextBox[] { new TextBox(), txtScore1, txtScore2, txtScore3, txtScore4, txtScore5, txtScore6, txtScore7, txtScore8 };
            int index = int.Parse((string)((Button)sender).Tag);
            scores[index].Text = (int.Parse(scores[index].Text) - 0.5*(int.Parse(txtCurrentValue.Text))).ToString();
        }

        //update current Q value
        public void update_curQ_score(string score)
        {
            txtCurrentValue.Text = score;
        }

        private void resetScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {   //reset all scores
            txtScore1.Text = "0";
            txtScore2.Text = "0";
            txtScore3.Text = "0";
            txtScore4.Text = "0";
            txtScore5.Text = "0";
            txtScore6.Text = "0";
            txtScore7.Text = "0";
            txtScore8.Text = "0";
        }

        //update scores based on active player, not currently used
        public void score_mod(float mult)
        {
            TextBox[] scores = new TextBox[] { new TextBox(), txtScore1, txtScore2, txtScore3, txtScore4, txtScore5, txtScore6, txtScore7, txtScore8 };
            int index = gActivePlayer; //if gActivePlayer is not zero based
            scores[index].Text = (int.Parse(scores[index].Text) + (mult * int.Parse(txtCurrentValue.Text))).ToString();
        }

        private void ScoreChanged(object sender, EventArgs e)
        {   //event handler for tracking score textbox changes
            if (QuestionForm.Visible)
            {
                QuestionForm.UpdateScores(
                    new String[] { txtScore1.Text, txtScore2.Text, 
                txtScore3.Text, txtScore4.Text, txtScore5.Text, 
                txtScore6.Text, txtScore7.Text, txtScore8.Text, });
            }
        }

        #endregion

        private void btnBlank_Click(object sender, EventArgs e)
        {
            if (btnBlank.BackColor == Color.Red)
            {
                QuestionForm.BlankScreen(false);
                btnBlank.BackColor = SystemColors.Control;
            }
            else
            {
                QuestionForm.BlankScreen(true);
                btnBlank.BackColor = Color.Red;
            }
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            QChanged = true;
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            AChanged = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QuestionForm.RefreshBrowser();
        }
    }
}
