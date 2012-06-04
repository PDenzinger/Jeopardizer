using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmView : Form
    {
        Form1 mainform;

        public frmView(Form1 mainf)
        {
            mainform = mainf;
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            webBrowser1.Dock = DockStyle.Fill;
            lblAnswerPopup.Visible = false;
            btnAnswer.Visible = false;
            btnNext.Visible = false;
            webBrowser1.Visible = false;
        }

        public void PopulateSelectionScreen(string title, string[] categoryNames, int num_questions, int base_value, int level)
        {
            int num_qs = num_questions;
            int num_cat = categoryNames.Length;
            lblTitle.Text = title;
            int Main_Xloc = this.Location.X;
            int Main_Yloc = this.Location.Y;

            lblTitle.Refresh();
            lblTitle.Location = new Point((int)(this.Width*0.5 - lblTitle.Width*0.5), (int)(Main_Yloc + 1));

            QPanel.Location = new Point(Main_Xloc + 10, lblTitle.Location.Y + lblTitle.Height + 10);
            QPanel.Width = this.Width - 20;
            QPanel.Height = this.Height - QPanel.Location.Y - 10;

            //hide panel blanks the screen
            HidePanel.Location = this.Location;
            HidePanel.Width = this.Width;
            HidePanel.Height = this.Height;

            //remove any old items in the groupbox
            QPanel.Controls.Clear();
            foreach (Control c in QPanel.Controls)
            {
                QPanel.Controls.Remove(c);
            }

            //get groupbox location and size
            Point grpLocation = QPanel.Location;
            int grpWidth = QPanel.Width;
            int grpHeight = QPanel.Height;
            int catWidth = (int)((grpWidth - 20) / num_cat);

            //add new headings
            int LabelHeight = 0;
            for (int i = 0; i < num_cat; i++)
            {
                GrowLabel L = new GrowLabel();
                //Label L = new Label();
                L.Name = "CatLabel" + i.ToString();
                //L.Size = new Size(catWidth, 30);
                L.Width = catWidth;
                L.Location = new Point(grpLocation.X + (i * catWidth), 5);
                L.Text = categoryNames[i];
                L.TextAlign = ContentAlignment.MiddleCenter;
                L.BackColor = SampleHeading.BackColor;
                L.ForeColor = SampleHeading.ForeColor;
                L.Font = SampleHeading.Font;
                QPanel.Controls.Add(L);

                //save max label height
                if (LabelHeight < L.Height)
                {
                    LabelHeight = L.Height;
                }
            }

            //adjust heights to match
            for (int i = 0; i < num_cat; i++)
            {
                ((GrowLabel)QPanel.Controls["CatLabel" + i.ToString()]).AllowResize = false;
                ((GrowLabel)QPanel.Controls["CatLabel" + i.ToString()]).Height = LabelHeight;
            }

            //add buttons
            int btnHeight = (int)((grpHeight - (20 + LabelHeight)) / num_qs);
            for (int i = 0; i < num_cat; i++)
            {
                for (int j = 0; j < num_qs; j++)
                {
                    Button B = new Button();
                    B.Name = "btnQ" + ((i + 1).ToString() + (j + 1).ToString()).ToString();
                    B.Size = new Size(catWidth, btnHeight);
                    B.Location = new Point(grpLocation.X + (i * catWidth), LabelHeight + 5 + (j * btnHeight));
                    B.Text = ((j + 1) * base_value).ToString();
                    B.TextAlign = ContentAlignment.MiddleCenter;
                    B.BackColor = SampleQuestion.BackColor;
                    B.ForeColor = SampleQuestion.ForeColor;
                    B.Font = SampleQuestion.Font;
                    B.Tag = new string[] { level.ToString(), (i + 1).ToString() + (j + 1).ToString() };
                    B.Click += new EventHandler(btnQ_Click);
                    QPanel.Controls.Add(B);
                }
            }
        }

        public void BtnToggle(string name)
        {
            Button clickedBtn = (Button)QPanel.Controls[name];
            if (clickedBtn.BackColor != Color.Red)
            {
                clickedBtn.BackColor = Color.Red;
            }
            else
            {
                clickedBtn.BackColor = SampleQuestion.BackColor;
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            string[] question = (string[])((Button)sender).Tag;
            mainform.update_curQ_score(((Button)sender).Text);
            mainform.btnClicker(question);
        }

        private void ChangeDocument(string documentText, double timeout)
        {
            System.DateTime startTime = System.DateTime.Now;
            double elapsed = 0;

            if (webBrowser1.Document == null)
            {
                webBrowser1.Navigate("about:blank");
            }

            webBrowser1.Document.OpenNew(false);

            while ((webBrowser1.DocumentText != "") && (elapsed < timeout))
            {
                System.Threading.Thread.Sleep(50);
                elapsed = System.DateTime.Now.Subtract(startTime).TotalMilliseconds;
            }

            webBrowser1.Document.Write(documentText);
            //webBrowser1.DocumentText = documentText;

            startTime = System.DateTime.Now;
            elapsed = 0;

            while ((webBrowser1.DocumentText != documentText) && (elapsed < timeout))
            {
                System.Threading.Thread.Sleep(50);
                elapsed = System.DateTime.Now.Subtract(startTime).TotalMilliseconds;
            }
        }

        public void UpdateScreenQA(string question, string answer)
        {
            //create question text
            lblAnswerPopup.Visible = false;
            lblAnswerPopup.Text = answer;

            string documentText = "<html><body><table cellpadding='0' cellspacing='0' style='height:90%;width:100%'>";
            documentText += "<tr height='80%'><td valign='middle'><div id='question' ><h1 align='center'><big>";
            documentText += question;
            documentText += "</big></h1></div></td></tr>";
            documentText += "<tr height='20%'><td><div id='answer' style='display:none'><h1>";
            documentText += answer;
            documentText += "</h1></div></td></tr></table></body></html>";
            ChangeDocument(documentText, 1000);

            webBrowser1.Document.GetElementById("answer").Style = "display:none";

            webBrowser1.Visible = true;
            QPanel.Visible = false;

            btnAnswer.Visible = true;
            btnNext.Visible = true;
        }

        public void UpdateScreenQA(string category, string question, string answer)
        {
            //create question text
            lblAnswerPopup.Visible = false;
            lblAnswerPopup.Text = answer;

            string documentText = "<html><body><table cellpadding='0' cellspacing='0' style='height:90%;width:100%'>";
            documentText += "<tr height='10%'><td valign='middle'><div id='category'><font color='red'><h2 align='center'>";
            documentText += category;
            documentText += "</h2></font></div></td></tr>";
            documentText += "<tr height='80%'><td valign='middle'><div id='question' ><h1 align='center'><big>";
            documentText += question;
            documentText += "</big></h1></div></td></tr>";
            documentText += "<tr height='10%'><td><div id='answer' style='display:none'><h1>";
            documentText += answer;
            documentText += "</h1></div></td></tr></table></body></html>";
            ChangeDocument(documentText, 1000);

            webBrowser1.Document.GetElementById("answer").Style = "display:none";

            webBrowser1.Visible = true;
            QPanel.Visible = false;

            btnAnswer.Visible = true;
            btnNext.Visible = true;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            AnswerButton();
        }

        public bool AnswerButton()
        {
            try
            {
                string style = webBrowser1.Document.GetElementById("answer").Style;

                //the space before "none" is required
                if (style.ToLower() == "display: none")
                {
                    //answer is not currently displayed, display it
                    webBrowser1.Document.GetElementById("answer").Style = "display:block;text-align:center";

                    return true;
                }
                else
                {
                    //answer is displayed, hide it
                    webBrowser1.Document.GetElementById("answer").Style = "display:none";

                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public void NextQuestion()
        {
            lblAnswerPopup.Visible = false;

            QPanel.Visible = true;
            btnNext.Visible = false;
            btnAnswer.Visible = false;
            webBrowser1.Visible = false;
        }

        public void UpdateOrder(string[] names, Color[] colors)
        {
            if ((names.Length == colors.Length)&&(names.Length > 0)&&(names.Length<11))
            {
                //begin with them invisible
                lblCurrentPlayer.Visible = false;
                lblNextPlayer.Visible = false;

                Label[] AnswerLabels = new Label[] { lblCurrentPlayer, lblNextPlayer };

                //current display allows for two answer positions
                for (int i = 0; ((i < names.Length) && (i < 2)); i++)
                {
                    if (names[i] != "")
                    {
                        AnswerLabels[i].BackColor = colors[i];
                        AnswerLabels[i].Text = names[i];
                        AnswerLabels[i].Visible = true;
                    }
                }
            }
        }

        public void UpdateTimer(float progress)
        {
            timerBar.Value = progress;
            timerBar.Update();

            if ((progress < 100) && (progress > 0))
            {
                timerBar.Visible = true;
            }
            else
            {
                timerBar.Visible = false;
            }
        }

        public void HideScreen(bool hide)
        {
            if (hide)
            {
                HidePanel.Visible = true;
                HidePanel.BringToFront();
                btnAnswer.BringToFront();
                btnNext.BringToFront();
            }
            else
            {
                HidePanel.Visible = false;
            }
        }

        public void ShowOrder(bool show)
        {
            if (show)
            {
                lblCurrentPlayer.Visible = true;
                lblNextPlayer.Visible = true;
            }
            else
            {
                lblCurrentPlayer.Visible = false;
                lblNextPlayer.Visible = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void HidePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HideScreen(false);
        }

        public void BlankScreen(bool hide)
        {
            if (hide)
            {
                HidePanel.Location = new Point(0, 0);
                HidePanel.Width = this.Width;
                HidePanel.Height = this.Height;
                HidePanel.Visible = true;
            }
            else
            {
                HidePanel.Visible = false;
            }
        }

    }
}
