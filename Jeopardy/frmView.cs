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
            lblTitle.Location = new Point((int)(this.Width*0.5 - lblTitle.Width*0.5),lblTitle.Location.Y);

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
            for (int i = 0; i < num_cat; i++)
            {
                Label L = new Label();
                L.Name = "CatLabel" + i.ToString();
                L.Size = new Size(catWidth, 30);
                L.Location = new Point(grpLocation.X + (i * catWidth), 5);
                L.Text = categoryNames[i];
                L.TextAlign = ContentAlignment.MiddleCenter;
                QPanel.Controls.Add(L);
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
                    B.Location = new Point(grpLocation.X + (i * catWidth), 35 + (j * btnHeight));
                    B.Text = ((j + 1) * base_value).ToString();
                    B.TextAlign = ContentAlignment.MiddleCenter;
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
                clickedBtn.BackColor = SystemColors.Control;
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

            string documentText = "<html><body><table style='height:80%;width:100%'><tr><td valign='middle'><div id='question' ><h1 align='center'><big>";
            documentText += question;
            documentText += "</big></h1></div></td></tr></table><div id='answer' style='display:none'><h1>";
            documentText += answer;
            documentText += "</h1></div></body></html>";
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

                    //old code
                    //int width = (int)(this.Size.Width / 2);
                    //int height = (int)(this.Size.Height / 5);
                    //int X = (int)(this.Location.X + (this.Size.Width / 2) - (width / 2));
                    //int Y = (int)(this.Location.Y + (this.Size.Height / 2) - (height / 2));
                    //lblAnswerPopup.Size = new Size(width, height);
                    //lblAnswerPopup.Location = new Point(X, Y);
                    //lblAnswerPopup.Visible = true;

                    return true;
                }
                else
                {
                    //answer is displayed, hide it
                    webBrowser1.Document.GetElementById("answer").Style = "display:none";

                    return false;
                }
            }
            catch (Exception e)
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
                Label[] AnswerLabels = new Label[] { order1, order2, order3, order4, order5, order6, order7, order8, order9, order10 };

                for (int i = 0; ((i < names.Length) && (i < 10)); i++)
                {
                    AnswerLabels[i].BackColor = colors[i];
                    AnswerLabels[i].Text = names[i];
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
                grpOrder.Visible = true;
            }
            else
            {
                grpOrder.Visible = false;
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
