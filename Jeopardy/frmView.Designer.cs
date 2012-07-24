namespace Jeopardy
{
    partial class frmView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblAnswerPopup = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.QPanel = new System.Windows.Forms.Panel();
            this.HidePanel = new System.Windows.Forms.Panel();
            this.timerBar = new CustomPbar.Pbar();
            this.grpScores = new System.Windows.Forms.GroupBox();
            this.score8 = new System.Windows.Forms.Label();
            this.score7 = new System.Windows.Forms.Label();
            this.score6 = new System.Windows.Forms.Label();
            this.score5 = new System.Windows.Forms.Label();
            this.score4 = new System.Windows.Forms.Label();
            this.score3 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblNextPlayer = new System.Windows.Forms.Label();
            this.SampleHeading = new System.Windows.Forms.Label();
            this.SampleQuestion = new System.Windows.Forms.Label();
            this.grpScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(592, 85);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(121, 99);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(-1, 713);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 28);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(937, 713);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(81, 28);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblAnswerPopup
            // 
            this.lblAnswerPopup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAnswerPopup.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPopup.Location = new System.Drawing.Point(843, 678);
            this.lblAnswerPopup.Name = "lblAnswerPopup";
            this.lblAnswerPopup.Size = new System.Drawing.Size(17, 54);
            this.lblAnswerPopup.TabIndex = 3;
            this.lblAnswerPopup.Text = "Template Answer";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(168, 149);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(674, 73);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "DOUBLE JEOPARDY";
            // 
            // QPanel
            // 
            this.QPanel.Location = new System.Drawing.Point(12, 84);
            this.QPanel.Name = "QPanel";
            this.QPanel.Size = new System.Drawing.Size(813, 310);
            this.QPanel.TabIndex = 5;
            // 
            // HidePanel
            // 
            this.HidePanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.HidePanel.Location = new System.Drawing.Point(671, 463);
            this.HidePanel.Name = "HidePanel";
            this.HidePanel.Size = new System.Drawing.Size(99, 72);
            this.HidePanel.TabIndex = 6;
            this.HidePanel.Visible = false;
            this.HidePanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HidePanel_MouseDoubleClick);
            // 
            // timerBar
            // 
            this.timerBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.timerBar.BackColor = System.Drawing.SystemColors.Window;
            this.timerBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerBar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timerBar.Location = new System.Drawing.Point(12, 404);
            this.timerBar.Name = "timerBar";
            this.timerBar.Size = new System.Drawing.Size(995, 22);
            this.timerBar.TabIndex = 9;
            this.timerBar.Value = 0F;
            this.timerBar.Visible = false;
            // 
            // grpScores
            // 
            this.grpScores.Controls.Add(this.score8);
            this.grpScores.Controls.Add(this.score7);
            this.grpScores.Controls.Add(this.score6);
            this.grpScores.Controls.Add(this.score5);
            this.grpScores.Controls.Add(this.score4);
            this.grpScores.Controls.Add(this.score3);
            this.grpScores.Controls.Add(this.score2);
            this.grpScores.Controls.Add(this.score1);
            this.grpScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScores.Location = new System.Drawing.Point(22, 556);
            this.grpScores.Name = "grpScores";
            this.grpScores.Size = new System.Drawing.Size(973, 39);
            this.grpScores.TabIndex = 10;
            this.grpScores.TabStop = false;
            this.grpScores.Text = "Scores";
            this.grpScores.Visible = false;
            // 
            // score8
            // 
            this.score8.BackColor = System.Drawing.Color.Silver;
            this.score8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score8.Location = new System.Drawing.Point(804, 15);
            this.score8.Name = "score8";
            this.score8.Size = new System.Drawing.Size(108, 28);
            this.score8.TabIndex = 8;
            this.score8.Text = "0";
            this.score8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score7
            // 
            this.score7.BackColor = System.Drawing.Color.Snow;
            this.score7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score7.Location = new System.Drawing.Point(690, 15);
            this.score7.Name = "score7";
            this.score7.Size = new System.Drawing.Size(108, 28);
            this.score7.TabIndex = 7;
            this.score7.Text = "0";
            this.score7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score6
            // 
            this.score6.BackColor = System.Drawing.Color.Orange;
            this.score6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score6.Location = new System.Drawing.Point(576, 17);
            this.score6.Name = "score6";
            this.score6.Size = new System.Drawing.Size(108, 28);
            this.score6.TabIndex = 6;
            this.score6.Text = "0";
            this.score6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score5
            // 
            this.score5.BackColor = System.Drawing.Color.MediumPurple;
            this.score5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score5.Location = new System.Drawing.Point(462, 15);
            this.score5.Name = "score5";
            this.score5.Size = new System.Drawing.Size(108, 28);
            this.score5.TabIndex = 5;
            this.score5.Text = "0";
            this.score5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score4
            // 
            this.score4.BackColor = System.Drawing.Color.Yellow;
            this.score4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score4.Location = new System.Drawing.Point(348, 15);
            this.score4.Name = "score4";
            this.score4.Size = new System.Drawing.Size(108, 28);
            this.score4.TabIndex = 4;
            this.score4.Text = "0";
            this.score4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score3
            // 
            this.score3.BackColor = System.Drawing.Color.Cyan;
            this.score3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score3.Location = new System.Drawing.Point(234, 15);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(108, 28);
            this.score3.TabIndex = 3;
            this.score3.Text = "0";
            this.score3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score2
            // 
            this.score2.BackColor = System.Drawing.Color.Lime;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(120, 15);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(108, 28);
            this.score2.TabIndex = 2;
            this.score2.Text = "0";
            this.score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score1
            // 
            this.score1.BackColor = System.Drawing.Color.Red;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(6, 15);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(108, 28);
            this.score1.TabIndex = 1;
            this.score1.Text = "0";
            this.score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.BackColor = System.Drawing.Color.Red;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(-1, -1);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(69, 73);
            this.lblCurrentPlayer.TabIndex = 11;
            this.lblCurrentPlayer.Text = "1";
            this.lblCurrentPlayer.Visible = false;
            // 
            // lblNextPlayer
            // 
            this.lblNextPlayer.AutoSize = true;
            this.lblNextPlayer.BackColor = System.Drawing.Color.Lime;
            this.lblNextPlayer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNextPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPlayer.Location = new System.Drawing.Point(950, 0);
            this.lblNextPlayer.Name = "lblNextPlayer";
            this.lblNextPlayer.Size = new System.Drawing.Size(69, 73);
            this.lblNextPlayer.TabIndex = 12;
            this.lblNextPlayer.Text = "2";
            this.lblNextPlayer.Visible = false;
            // 
            // SampleHeading
            // 
            this.SampleHeading.AutoSize = true;
            this.SampleHeading.BackColor = System.Drawing.Color.Yellow;
            this.SampleHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SampleHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SampleHeading.Location = new System.Drawing.Point(46, 480);
            this.SampleHeading.Name = "SampleHeading";
            this.SampleHeading.Size = new System.Drawing.Size(161, 26);
            this.SampleHeading.TabIndex = 13;
            this.SampleHeading.Text = "SampleHeading";
            this.SampleHeading.Visible = false;
            // 
            // SampleQuestion
            // 
            this.SampleQuestion.AutoSize = true;
            this.SampleQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SampleQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SampleQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SampleQuestion.Location = new System.Drawing.Point(321, 480);
            this.SampleQuestion.Name = "SampleQuestion";
            this.SampleQuestion.Size = new System.Drawing.Size(108, 55);
            this.SampleQuestion.TabIndex = 14;
            this.SampleQuestion.Text = "500";
            this.SampleQuestion.Visible = false;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 741);
            this.Controls.Add(this.HidePanel);
            this.Controls.Add(this.SampleQuestion);
            this.Controls.Add(this.SampleHeading);
            this.Controls.Add(this.lblNextPlayer);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.grpScores);
            this.Controls.Add(this.timerBar);
            this.Controls.Add(this.QPanel);
            this.Controls.Add(this.lblAnswerPopup);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmView";
            this.Text = "frmView";
            this.Load += new System.EventHandler(this.frmView_Load);
            this.grpScores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label lblAnswerPopup;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel QPanel;
        private System.Windows.Forms.Panel HidePanel;
        private CustomPbar.Pbar timerBar;
        private System.Windows.Forms.GroupBox grpScores;
        private System.Windows.Forms.Label score6;
        private System.Windows.Forms.Label score5;
        private System.Windows.Forms.Label score4;
        private System.Windows.Forms.Label score3;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score7;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblNextPlayer;
        private System.Windows.Forms.Label SampleHeading;
        private System.Windows.Forms.Label SampleQuestion;
        private System.Windows.Forms.Label score8;
    }
}