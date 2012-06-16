namespace Jeopardy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dF1Comm1 = new DF1Comm.DF1Comm(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.grpBoardControl = new System.Windows.Forms.GroupBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleViewScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAvailableDisplaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.txtPlayer3 = new System.Windows.Forms.TextBox();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer4 = new System.Windows.Forms.TextBox();
            this.txtPlayer8 = new System.Windows.Forms.TextBox();
            this.txtPlayer6 = new System.Windows.Forms.TextBox();
            this.txtPlayer7 = new System.Windows.Forms.TextBox();
            this.txtPlayer5 = new System.Windows.Forms.TextBox();
            this.txtScore8 = new System.Windows.Forms.TextBox();
            this.txtScore6 = new System.Windows.Forms.TextBox();
            this.txtScore7 = new System.Windows.Forms.TextBox();
            this.txtScore5 = new System.Windows.Forms.TextBox();
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.chkPLC = new System.Windows.Forms.CheckBox();
            this.PLC_Timer = new System.Windows.Forms.Timer(this.components);
            this.listOrder = new System.Windows.Forms.ListBox();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.bkgTimer = new System.ComponentModel.BackgroundWorker();
            this.timerBar = new CustomPbar.Pbar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentValue = new System.Windows.Forms.TextBox();
            this.score_p1_add = new System.Windows.Forms.Button();
            this.score_p1_sub = new System.Windows.Forms.Button();
            this.score_p1_hlf = new System.Windows.Forms.Button();
            this.score_p2_hlf = new System.Windows.Forms.Button();
            this.score_p2_sub = new System.Windows.Forms.Button();
            this.score_p2_add = new System.Windows.Forms.Button();
            this.score_p3_hlf = new System.Windows.Forms.Button();
            this.score_p3_sub = new System.Windows.Forms.Button();
            this.score_p3_add = new System.Windows.Forms.Button();
            this.score_p6_hlf = new System.Windows.Forms.Button();
            this.score_p6_sub = new System.Windows.Forms.Button();
            this.score_p6_add = new System.Windows.Forms.Button();
            this.score_p5_hlf = new System.Windows.Forms.Button();
            this.score_p5_sub = new System.Windows.Forms.Button();
            this.score_p5_add = new System.Windows.Forms.Button();
            this.score_p4_hlf = new System.Windows.Forms.Button();
            this.score_p4_sub = new System.Windows.Forms.Button();
            this.score_p4_add = new System.Windows.Forms.Button();
            this.score_p8_hlf = new System.Windows.Forms.Button();
            this.score_p8_sub = new System.Windows.Forms.Button();
            this.score_p8_add = new System.Windows.Forms.Button();
            this.score_p7_hlf = new System.Windows.Forms.Button();
            this.score_p7_sub = new System.Windows.Forms.Button();
            this.score_p7_add = new System.Windows.Forms.Button();
            this.btnBlank = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.showTitleImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dF1Comm1
            // 
            this.dF1Comm1.AsyncMode = false;
            this.dF1Comm1.BaudRate = 9600;
            this.dF1Comm1.CheckSum = DF1Comm.DF1Comm.CheckSumOptions.Crc;
            this.dF1Comm1.ComPort = "COM1";
            this.dF1Comm1.MyNode = 0;
            this.dF1Comm1.Parity = System.IO.Ports.Parity.None;
            this.dF1Comm1.Protocol = "DF1";
            this.dF1Comm1.SynchronizingObject = this;
            this.dF1Comm1.TargetNode = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(657, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpBoardControl
            // 
            this.grpBoardControl.Location = new System.Drawing.Point(12, 26);
            this.grpBoardControl.Name = "grpBoardControl";
            this.grpBoardControl.Size = new System.Drawing.Size(399, 328);
            this.grpBoardControl.TabIndex = 8;
            this.grpBoardControl.TabStop = false;
            this.grpBoardControl.Text = "Questions";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(421, 81);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(230, 146);
            this.txtQuestion.TabIndex = 9;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(421, 229);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(230, 96);
            this.txtAnswer.TabIndex = 10;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "ini";
            this.openFileDialog1.Filter = "Ini Files (*.ini) |*.ini";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(541, 331);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(110, 23);
            this.btnAnswer.TabIndex = 12;
            this.btnAnswer.Text = "Show/Hide Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveQAToolStripMenuItem,
            this.resetScoresToolStripMenuItem,
            this.nextLevelToolStripMenuItem,
            this.previousLevelToolStripMenuItem,
            this.numberNamesToolStripMenuItem,
            this.teamNamesToolStripMenuItem,
            this.playerNamesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openToolStripMenuItem.Text = "&Open File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveQAToolStripMenuItem
            // 
            this.saveQAToolStripMenuItem.Name = "saveQAToolStripMenuItem";
            this.saveQAToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveQAToolStripMenuItem.Text = "&Save Q/A";
            this.saveQAToolStripMenuItem.Click += new System.EventHandler(this.saveQAToolStripMenuItem_Click);
            // 
            // resetScoresToolStripMenuItem
            // 
            this.resetScoresToolStripMenuItem.Name = "resetScoresToolStripMenuItem";
            this.resetScoresToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.resetScoresToolStripMenuItem.Text = "Reset Scores";
            this.resetScoresToolStripMenuItem.Click += new System.EventHandler(this.resetScoresToolStripMenuItem_Click);
            // 
            // nextLevelToolStripMenuItem
            // 
            this.nextLevelToolStripMenuItem.Name = "nextLevelToolStripMenuItem";
            this.nextLevelToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nextLevelToolStripMenuItem.Text = "Next Level";
            this.nextLevelToolStripMenuItem.Click += new System.EventHandler(this.nextLevelToolStripMenuItem_Click);
            // 
            // previousLevelToolStripMenuItem
            // 
            this.previousLevelToolStripMenuItem.Name = "previousLevelToolStripMenuItem";
            this.previousLevelToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.previousLevelToolStripMenuItem.Text = "Previous Level";
            this.previousLevelToolStripMenuItem.Click += new System.EventHandler(this.previousLevelToolStripMenuItem_Click);
            // 
            // numberNamesToolStripMenuItem
            // 
            this.numberNamesToolStripMenuItem.Name = "numberNamesToolStripMenuItem";
            this.numberNamesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.numberNamesToolStripMenuItem.Text = "Set Number Names";
            this.numberNamesToolStripMenuItem.Click += new System.EventHandler(this.numberNamesToolStripMenuItem_Click);
            // 
            // teamNamesToolStripMenuItem
            // 
            this.teamNamesToolStripMenuItem.Name = "teamNamesToolStripMenuItem";
            this.teamNamesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.teamNamesToolStripMenuItem.Text = "Set Team Names";
            this.teamNamesToolStripMenuItem.Click += new System.EventHandler(this.teamNamesToolStripMenuItem_Click);
            // 
            // playerNamesToolStripMenuItem
            // 
            this.playerNamesToolStripMenuItem.Name = "playerNamesToolStripMenuItem";
            this.playerNamesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.playerNamesToolStripMenuItem.Text = "Set Player Names";
            this.playerNamesToolStripMenuItem.Click += new System.EventHandler(this.playerNamesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTitleImageToolStripMenuItem,
            this.toggleViewScreenToolStripMenuItem,
            this.refreshAvailableDisplaysToolStripMenuItem,
            this.sendToToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // toggleViewScreenToolStripMenuItem
            // 
            this.toggleViewScreenToolStripMenuItem.Name = "toggleViewScreenToolStripMenuItem";
            this.toggleViewScreenToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.toggleViewScreenToolStripMenuItem.Text = "Toggle ViewScreen";
            this.toggleViewScreenToolStripMenuItem.Click += new System.EventHandler(this.toggleViewScreenToolStripMenuItem_Click);
            // 
            // refreshAvailableDisplaysToolStripMenuItem
            // 
            this.refreshAvailableDisplaysToolStripMenuItem.Name = "refreshAvailableDisplaysToolStripMenuItem";
            this.refreshAvailableDisplaysToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.refreshAvailableDisplaysToolStripMenuItem.Text = "&Refresh Available Displays";
            this.refreshAvailableDisplaysToolStripMenuItem.Click += new System.EventHandler(this.refreshAvailableDisplaysToolStripMenuItem_Click);
            // 
            // sendToToolStripMenuItem
            // 
            this.sendToToolStripMenuItem.Name = "sendToToolStripMenuItem";
            this.sendToToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.sendToToolStripMenuItem.Text = "Send To:";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem,
            this.test2ToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.test1ToolStripMenuItem.Text = "Test1";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.test2ToolStripMenuItem.Text = "Test2";
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(421, 331);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next Q";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.BackColor = System.Drawing.Color.Red;
            this.txtPlayer1.Location = new System.Drawing.Point(12, 360);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(84, 20);
            this.txtPlayer1.TabIndex = 15;
            this.txtPlayer1.Text = "Team 1";
            // 
            // txtPlayer3
            // 
            this.txtPlayer3.BackColor = System.Drawing.Color.Cyan;
            this.txtPlayer3.Location = new System.Drawing.Point(192, 360);
            this.txtPlayer3.Name = "txtPlayer3";
            this.txtPlayer3.Size = new System.Drawing.Size(84, 20);
            this.txtPlayer3.TabIndex = 16;
            this.txtPlayer3.Text = "Team 3";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.BackColor = System.Drawing.Color.Lime;
            this.txtPlayer2.Location = new System.Drawing.Point(102, 360);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(84, 20);
            this.txtPlayer2.TabIndex = 17;
            this.txtPlayer2.Text = "Team 2";
            // 
            // txtPlayer4
            // 
            this.txtPlayer4.BackColor = System.Drawing.Color.Yellow;
            this.txtPlayer4.Location = new System.Drawing.Point(282, 360);
            this.txtPlayer4.Name = "txtPlayer4";
            this.txtPlayer4.Size = new System.Drawing.Size(84, 20);
            this.txtPlayer4.TabIndex = 18;
            this.txtPlayer4.Text = "Team 4";
            // 
            // txtPlayer8
            // 
            this.txtPlayer8.BackColor = System.Drawing.Color.Silver;
            this.txtPlayer8.Location = new System.Drawing.Point(642, 360);
            this.txtPlayer8.Name = "txtPlayer8";
            this.txtPlayer8.Size = new System.Drawing.Size(84, 20);
            this.txtPlayer8.TabIndex = 22;
            this.txtPlayer8.Text = "Team 8";
            // 
            // txtPlayer6
            // 
            this.txtPlayer6.BackColor = System.Drawing.Color.Orange;
            this.txtPlayer6.Location = new System.Drawing.Point(462, 360);
            this.txtPlayer6.Name = "txtPlayer6";
            this.txtPlayer6.Size = new System.Drawing.Size(84, 20);
            this.txtPlayer6.TabIndex = 21;
            this.txtPlayer6.Text = "Team 6";
            // 
            // txtPlayer7
            // 
            this.txtPlayer7.BackColor = System.Drawing.Color.Snow;
            this.txtPlayer7.Location = new System.Drawing.Point(552, 360);
            this.txtPlayer7.Name = "txtPlayer7";
            this.txtPlayer7.Size = new System.Drawing.Size(84, 20);
            this.txtPlayer7.TabIndex = 20;
            this.txtPlayer7.Text = "Team 7";
            // 
            // txtPlayer5
            // 
            this.txtPlayer5.BackColor = System.Drawing.Color.MediumPurple;
            this.txtPlayer5.Location = new System.Drawing.Point(372, 360);
            this.txtPlayer5.Name = "txtPlayer5";
            this.txtPlayer5.Size = new System.Drawing.Size(84, 20);
            this.txtPlayer5.TabIndex = 19;
            this.txtPlayer5.Text = "Team 5";
            // 
            // txtScore8
            // 
            this.txtScore8.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore8.Location = new System.Drawing.Point(642, 386);
            this.txtScore8.Name = "txtScore8";
            this.txtScore8.Size = new System.Drawing.Size(84, 20);
            this.txtScore8.TabIndex = 30;
            this.txtScore8.Text = "0";
            this.txtScore8.TextChanged += new System.EventHandler(this.ScoreChanged);
            // 
            // txtScore6
            // 
            this.txtScore6.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore6.Location = new System.Drawing.Point(462, 386);
            this.txtScore6.Name = "txtScore6";
            this.txtScore6.Size = new System.Drawing.Size(84, 20);
            this.txtScore6.TabIndex = 29;
            this.txtScore6.Text = "0";
            this.txtScore6.TextChanged += new System.EventHandler(this.ScoreChanged);
            // 
            // txtScore7
            // 
            this.txtScore7.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore7.Location = new System.Drawing.Point(552, 386);
            this.txtScore7.Name = "txtScore7";
            this.txtScore7.Size = new System.Drawing.Size(84, 20);
            this.txtScore7.TabIndex = 28;
            this.txtScore7.Text = "0";
            this.txtScore7.TextChanged += new System.EventHandler(this.ScoreChanged);
            // 
            // txtScore5
            // 
            this.txtScore5.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore5.Location = new System.Drawing.Point(372, 386);
            this.txtScore5.Name = "txtScore5";
            this.txtScore5.Size = new System.Drawing.Size(84, 20);
            this.txtScore5.TabIndex = 27;
            this.txtScore5.Text = "0";
            this.txtScore5.TextChanged += new System.EventHandler(this.ScoreChanged);
            // 
            // txtScore4
            // 
            this.txtScore4.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore4.Location = new System.Drawing.Point(282, 386);
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.Size = new System.Drawing.Size(84, 20);
            this.txtScore4.TabIndex = 26;
            this.txtScore4.Text = "0";
            this.txtScore4.TextChanged += new System.EventHandler(this.ScoreChanged);
            // 
            // txtScore2
            // 
            this.txtScore2.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore2.Location = new System.Drawing.Point(102, 386);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(84, 20);
            this.txtScore2.TabIndex = 25;
            this.txtScore2.Text = "0";
            this.txtScore2.TextChanged += new System.EventHandler(this.ScoreChanged);
            // 
            // txtScore3
            // 
            this.txtScore3.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore3.Location = new System.Drawing.Point(192, 386);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(84, 20);
            this.txtScore3.TabIndex = 24;
            this.txtScore3.Text = "0";
            this.txtScore3.TextChanged += new System.EventHandler(this.ScoreChanged);
            // 
            // txtScore1
            // 
            this.txtScore1.BackColor = System.Drawing.SystemColors.Control;
            this.txtScore1.Location = new System.Drawing.Point(12, 386);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(84, 20);
            this.txtScore1.TabIndex = 23;
            this.txtScore1.Text = "0";
            this.txtScore1.TextChanged += new System.EventHandler(this.ScoreChanged);
            // 
            // chkPLC
            // 
            this.chkPLC.AutoSize = true;
            this.chkPLC.Location = new System.Drawing.Point(657, 29);
            this.chkPLC.Name = "chkPLC";
            this.chkPLC.Size = new System.Drawing.Size(46, 17);
            this.chkPLC.TabIndex = 31;
            this.chkPLC.Text = "PLC";
            this.chkPLC.UseVisualStyleBackColor = true;
            this.chkPLC.CheckedChanged += new System.EventHandler(this.chkPLC_CheckedChanged);
            // 
            // PLC_Timer
            // 
            this.PLC_Timer.Enabled = true;
            this.PLC_Timer.Interval = 1000;
            this.PLC_Timer.Tick += new System.EventHandler(this.PLC_Timer_Tick);
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.Location = new System.Drawing.Point(657, 81);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(75, 212);
            this.listOrder.TabIndex = 32;
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.Location = new System.Drawing.Point(657, 299);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnNextPlayer.TabIndex = 33;
            this.btnNextPlayer.Text = "Next";
            this.btnNextPlayer.UseVisualStyleBackColor = true;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // bkgTimer
            // 
            this.bkgTimer.WorkerReportsProgress = true;
            this.bkgTimer.WorkerSupportsCancellation = true;
            this.bkgTimer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgTimer_DoWork);
            this.bkgTimer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgTimer_ProgressChanged);
            // 
            // timerBar
            // 
            this.timerBar.BackColor = System.Drawing.SystemColors.Window;
            this.timerBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timerBar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timerBar.Location = new System.Drawing.Point(0, 455);
            this.timerBar.Name = "timerBar";
            this.timerBar.Size = new System.Drawing.Size(739, 25);
            this.timerBar.TabIndex = 34;
            this.timerBar.Value = 0F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Question Value:";
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.Location = new System.Drawing.Point(557, 30);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.Size = new System.Drawing.Size(91, 20);
            this.txtCurrentValue.TabIndex = 36;
            this.txtCurrentValue.Text = "0";
            // 
            // score_p1_add
            // 
            this.score_p1_add.Location = new System.Drawing.Point(12, 412);
            this.score_p1_add.Name = "score_p1_add";
            this.score_p1_add.Size = new System.Drawing.Size(84, 20);
            this.score_p1_add.TabIndex = 37;
            this.score_p1_add.Tag = "1";
            this.score_p1_add.Text = "add";
            this.score_p1_add.UseVisualStyleBackColor = true;
            this.score_p1_add.Click += new System.EventHandler(this.score_add);
            // 
            // score_p1_sub
            // 
            this.score_p1_sub.Location = new System.Drawing.Point(12, 431);
            this.score_p1_sub.Name = "score_p1_sub";
            this.score_p1_sub.Size = new System.Drawing.Size(42, 20);
            this.score_p1_sub.TabIndex = 38;
            this.score_p1_sub.Tag = "1";
            this.score_p1_sub.Text = "sub";
            this.score_p1_sub.UseVisualStyleBackColor = true;
            this.score_p1_sub.Click += new System.EventHandler(this.score_sub);
            // 
            // score_p1_hlf
            // 
            this.score_p1_hlf.Location = new System.Drawing.Point(54, 431);
            this.score_p1_hlf.Name = "score_p1_hlf";
            this.score_p1_hlf.Size = new System.Drawing.Size(42, 20);
            this.score_p1_hlf.TabIndex = 39;
            this.score_p1_hlf.Tag = "1";
            this.score_p1_hlf.Text = "0.5";
            this.score_p1_hlf.UseVisualStyleBackColor = true;
            this.score_p1_hlf.Click += new System.EventHandler(this.score_hlf);
            // 
            // score_p2_hlf
            // 
            this.score_p2_hlf.Location = new System.Drawing.Point(144, 431);
            this.score_p2_hlf.Name = "score_p2_hlf";
            this.score_p2_hlf.Size = new System.Drawing.Size(42, 20);
            this.score_p2_hlf.TabIndex = 42;
            this.score_p2_hlf.Tag = "2";
            this.score_p2_hlf.Text = "0.5";
            this.score_p2_hlf.UseVisualStyleBackColor = true;
            this.score_p2_hlf.Click += new System.EventHandler(this.score_hlf);
            // 
            // score_p2_sub
            // 
            this.score_p2_sub.Location = new System.Drawing.Point(102, 431);
            this.score_p2_sub.Name = "score_p2_sub";
            this.score_p2_sub.Size = new System.Drawing.Size(42, 20);
            this.score_p2_sub.TabIndex = 41;
            this.score_p2_sub.Tag = "2";
            this.score_p2_sub.Text = "sub";
            this.score_p2_sub.UseVisualStyleBackColor = true;
            this.score_p2_sub.Click += new System.EventHandler(this.score_sub);
            // 
            // score_p2_add
            // 
            this.score_p2_add.Location = new System.Drawing.Point(102, 412);
            this.score_p2_add.Name = "score_p2_add";
            this.score_p2_add.Size = new System.Drawing.Size(84, 20);
            this.score_p2_add.TabIndex = 40;
            this.score_p2_add.Tag = "2";
            this.score_p2_add.Text = "add";
            this.score_p2_add.UseVisualStyleBackColor = true;
            this.score_p2_add.Click += new System.EventHandler(this.score_add);
            // 
            // score_p3_hlf
            // 
            this.score_p3_hlf.Location = new System.Drawing.Point(234, 431);
            this.score_p3_hlf.Name = "score_p3_hlf";
            this.score_p3_hlf.Size = new System.Drawing.Size(42, 20);
            this.score_p3_hlf.TabIndex = 45;
            this.score_p3_hlf.Tag = "3";
            this.score_p3_hlf.Text = "0.5";
            this.score_p3_hlf.UseVisualStyleBackColor = true;
            this.score_p3_hlf.Click += new System.EventHandler(this.score_hlf);
            // 
            // score_p3_sub
            // 
            this.score_p3_sub.Location = new System.Drawing.Point(192, 431);
            this.score_p3_sub.Name = "score_p3_sub";
            this.score_p3_sub.Size = new System.Drawing.Size(42, 20);
            this.score_p3_sub.TabIndex = 44;
            this.score_p3_sub.Tag = "3";
            this.score_p3_sub.Text = "sub";
            this.score_p3_sub.UseVisualStyleBackColor = true;
            this.score_p3_sub.Click += new System.EventHandler(this.score_sub);
            // 
            // score_p3_add
            // 
            this.score_p3_add.Location = new System.Drawing.Point(192, 412);
            this.score_p3_add.Name = "score_p3_add";
            this.score_p3_add.Size = new System.Drawing.Size(84, 20);
            this.score_p3_add.TabIndex = 43;
            this.score_p3_add.Tag = "3";
            this.score_p3_add.Text = "add";
            this.score_p3_add.UseVisualStyleBackColor = true;
            this.score_p3_add.Click += new System.EventHandler(this.score_add);
            // 
            // score_p6_hlf
            // 
            this.score_p6_hlf.Location = new System.Drawing.Point(504, 431);
            this.score_p6_hlf.Name = "score_p6_hlf";
            this.score_p6_hlf.Size = new System.Drawing.Size(42, 20);
            this.score_p6_hlf.TabIndex = 54;
            this.score_p6_hlf.Tag = "6";
            this.score_p6_hlf.Text = "0.5";
            this.score_p6_hlf.UseVisualStyleBackColor = true;
            this.score_p6_hlf.Click += new System.EventHandler(this.score_hlf);
            // 
            // score_p6_sub
            // 
            this.score_p6_sub.Location = new System.Drawing.Point(462, 431);
            this.score_p6_sub.Name = "score_p6_sub";
            this.score_p6_sub.Size = new System.Drawing.Size(42, 20);
            this.score_p6_sub.TabIndex = 53;
            this.score_p6_sub.Tag = "6";
            this.score_p6_sub.Text = "sub";
            this.score_p6_sub.UseVisualStyleBackColor = true;
            this.score_p6_sub.Click += new System.EventHandler(this.score_sub);
            // 
            // score_p6_add
            // 
            this.score_p6_add.Location = new System.Drawing.Point(462, 412);
            this.score_p6_add.Name = "score_p6_add";
            this.score_p6_add.Size = new System.Drawing.Size(84, 20);
            this.score_p6_add.TabIndex = 52;
            this.score_p6_add.Tag = "6";
            this.score_p6_add.Text = "add";
            this.score_p6_add.UseVisualStyleBackColor = true;
            this.score_p6_add.Click += new System.EventHandler(this.score_add);
            // 
            // score_p5_hlf
            // 
            this.score_p5_hlf.Location = new System.Drawing.Point(414, 431);
            this.score_p5_hlf.Name = "score_p5_hlf";
            this.score_p5_hlf.Size = new System.Drawing.Size(42, 20);
            this.score_p5_hlf.TabIndex = 51;
            this.score_p5_hlf.Tag = "5";
            this.score_p5_hlf.Text = "0.5";
            this.score_p5_hlf.UseVisualStyleBackColor = true;
            this.score_p5_hlf.Click += new System.EventHandler(this.score_hlf);
            // 
            // score_p5_sub
            // 
            this.score_p5_sub.Location = new System.Drawing.Point(372, 431);
            this.score_p5_sub.Name = "score_p5_sub";
            this.score_p5_sub.Size = new System.Drawing.Size(42, 20);
            this.score_p5_sub.TabIndex = 50;
            this.score_p5_sub.Tag = "5";
            this.score_p5_sub.Text = "sub";
            this.score_p5_sub.UseVisualStyleBackColor = true;
            this.score_p5_sub.Click += new System.EventHandler(this.score_sub);
            // 
            // score_p5_add
            // 
            this.score_p5_add.Location = new System.Drawing.Point(372, 412);
            this.score_p5_add.Name = "score_p5_add";
            this.score_p5_add.Size = new System.Drawing.Size(84, 20);
            this.score_p5_add.TabIndex = 49;
            this.score_p5_add.Tag = "5";
            this.score_p5_add.Text = "add";
            this.score_p5_add.UseVisualStyleBackColor = true;
            this.score_p5_add.Click += new System.EventHandler(this.score_add);
            // 
            // score_p4_hlf
            // 
            this.score_p4_hlf.Location = new System.Drawing.Point(324, 431);
            this.score_p4_hlf.Name = "score_p4_hlf";
            this.score_p4_hlf.Size = new System.Drawing.Size(42, 20);
            this.score_p4_hlf.TabIndex = 48;
            this.score_p4_hlf.Tag = "4";
            this.score_p4_hlf.Text = "0.5";
            this.score_p4_hlf.UseVisualStyleBackColor = true;
            this.score_p4_hlf.Click += new System.EventHandler(this.score_hlf);
            // 
            // score_p4_sub
            // 
            this.score_p4_sub.Location = new System.Drawing.Point(282, 431);
            this.score_p4_sub.Name = "score_p4_sub";
            this.score_p4_sub.Size = new System.Drawing.Size(42, 20);
            this.score_p4_sub.TabIndex = 47;
            this.score_p4_sub.Tag = "4";
            this.score_p4_sub.Text = "sub";
            this.score_p4_sub.UseVisualStyleBackColor = true;
            this.score_p4_sub.Click += new System.EventHandler(this.score_sub);
            // 
            // score_p4_add
            // 
            this.score_p4_add.Location = new System.Drawing.Point(282, 412);
            this.score_p4_add.Name = "score_p4_add";
            this.score_p4_add.Size = new System.Drawing.Size(84, 20);
            this.score_p4_add.TabIndex = 46;
            this.score_p4_add.Tag = "4";
            this.score_p4_add.Text = "add";
            this.score_p4_add.UseVisualStyleBackColor = true;
            this.score_p4_add.Click += new System.EventHandler(this.score_add);
            // 
            // score_p8_hlf
            // 
            this.score_p8_hlf.Location = new System.Drawing.Point(684, 431);
            this.score_p8_hlf.Name = "score_p8_hlf";
            this.score_p8_hlf.Size = new System.Drawing.Size(42, 20);
            this.score_p8_hlf.TabIndex = 60;
            this.score_p8_hlf.Tag = "8";
            this.score_p8_hlf.Text = "0.5";
            this.score_p8_hlf.UseVisualStyleBackColor = true;
            this.score_p8_hlf.Click += new System.EventHandler(this.score_hlf);
            // 
            // score_p8_sub
            // 
            this.score_p8_sub.Location = new System.Drawing.Point(642, 431);
            this.score_p8_sub.Name = "score_p8_sub";
            this.score_p8_sub.Size = new System.Drawing.Size(42, 20);
            this.score_p8_sub.TabIndex = 59;
            this.score_p8_sub.Tag = "8";
            this.score_p8_sub.Text = "sub";
            this.score_p8_sub.UseVisualStyleBackColor = true;
            this.score_p8_sub.Click += new System.EventHandler(this.score_sub);
            // 
            // score_p8_add
            // 
            this.score_p8_add.Location = new System.Drawing.Point(642, 412);
            this.score_p8_add.Name = "score_p8_add";
            this.score_p8_add.Size = new System.Drawing.Size(84, 20);
            this.score_p8_add.TabIndex = 58;
            this.score_p8_add.Tag = "8";
            this.score_p8_add.Text = "add";
            this.score_p8_add.UseVisualStyleBackColor = true;
            this.score_p8_add.Click += new System.EventHandler(this.score_add);
            // 
            // score_p7_hlf
            // 
            this.score_p7_hlf.Location = new System.Drawing.Point(594, 431);
            this.score_p7_hlf.Name = "score_p7_hlf";
            this.score_p7_hlf.Size = new System.Drawing.Size(42, 20);
            this.score_p7_hlf.TabIndex = 57;
            this.score_p7_hlf.Tag = "7";
            this.score_p7_hlf.Text = "0.5";
            this.score_p7_hlf.UseVisualStyleBackColor = true;
            this.score_p7_hlf.Click += new System.EventHandler(this.score_hlf);
            // 
            // score_p7_sub
            // 
            this.score_p7_sub.Location = new System.Drawing.Point(552, 431);
            this.score_p7_sub.Name = "score_p7_sub";
            this.score_p7_sub.Size = new System.Drawing.Size(42, 20);
            this.score_p7_sub.TabIndex = 56;
            this.score_p7_sub.Tag = "7";
            this.score_p7_sub.Text = "sub";
            this.score_p7_sub.UseVisualStyleBackColor = true;
            this.score_p7_sub.Click += new System.EventHandler(this.score_sub);
            // 
            // score_p7_add
            // 
            this.score_p7_add.Location = new System.Drawing.Point(552, 412);
            this.score_p7_add.Name = "score_p7_add";
            this.score_p7_add.Size = new System.Drawing.Size(84, 20);
            this.score_p7_add.TabIndex = 55;
            this.score_p7_add.Tag = "7";
            this.score_p7_add.Text = "add";
            this.score_p7_add.UseVisualStyleBackColor = true;
            this.score_p7_add.Click += new System.EventHandler(this.score_add);
            // 
            // btnBlank
            // 
            this.btnBlank.Location = new System.Drawing.Point(657, 331);
            this.btnBlank.Name = "btnBlank";
            this.btnBlank.Size = new System.Drawing.Size(75, 23);
            this.btnBlank.TabIndex = 61;
            this.btnBlank.Text = "Blank";
            this.btnBlank.UseVisualStyleBackColor = true;
            this.btnBlank.Click += new System.EventHandler(this.btnBlank_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(421, 52);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(230, 28);
            this.txtCategory.TabIndex = 62;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(495, 331);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(28, 23);
            this.btnRefresh.TabIndex = 63;
            this.btnRefresh.Text = "R";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // showTitleImageToolStripMenuItem
            // 
            this.showTitleImageToolStripMenuItem.Name = "showTitleImageToolStripMenuItem";
            this.showTitleImageToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.showTitleImageToolStripMenuItem.Text = "Show Title Image";
            this.showTitleImageToolStripMenuItem.Click += new System.EventHandler(this.showTitleImageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 480);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnBlank);
            this.Controls.Add(this.score_p8_hlf);
            this.Controls.Add(this.score_p8_sub);
            this.Controls.Add(this.score_p8_add);
            this.Controls.Add(this.score_p7_hlf);
            this.Controls.Add(this.score_p7_sub);
            this.Controls.Add(this.score_p7_add);
            this.Controls.Add(this.score_p6_hlf);
            this.Controls.Add(this.score_p6_sub);
            this.Controls.Add(this.score_p6_add);
            this.Controls.Add(this.score_p5_hlf);
            this.Controls.Add(this.score_p5_sub);
            this.Controls.Add(this.score_p5_add);
            this.Controls.Add(this.score_p4_hlf);
            this.Controls.Add(this.score_p4_sub);
            this.Controls.Add(this.score_p4_add);
            this.Controls.Add(this.score_p3_hlf);
            this.Controls.Add(this.score_p3_sub);
            this.Controls.Add(this.score_p3_add);
            this.Controls.Add(this.score_p2_hlf);
            this.Controls.Add(this.score_p2_sub);
            this.Controls.Add(this.score_p2_add);
            this.Controls.Add(this.score_p1_hlf);
            this.Controls.Add(this.score_p1_sub);
            this.Controls.Add(this.score_p1_add);
            this.Controls.Add(this.txtCurrentValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerBar);
            this.Controls.Add(this.btnNextPlayer);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.chkPLC);
            this.Controls.Add(this.txtScore8);
            this.Controls.Add(this.txtScore6);
            this.Controls.Add(this.txtScore7);
            this.Controls.Add(this.txtScore5);
            this.Controls.Add(this.txtScore4);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.txtPlayer8);
            this.Controls.Add(this.txtPlayer6);
            this.Controls.Add(this.txtPlayer7);
            this.Controls.Add(this.txtPlayer5);
            this.Controls.Add(this.txtPlayer4);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.txtPlayer3);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.grpBoardControl);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Jeopardizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DF1Comm.DF1Comm dF1Comm1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpBoardControl;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveQAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshAvailableDisplaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToToolStripMenuItem;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtPlayer4;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer3;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.TextBox txtScore8;
        private System.Windows.Forms.TextBox txtScore6;
        private System.Windows.Forms.TextBox txtScore7;
        private System.Windows.Forms.TextBox txtScore5;
        private System.Windows.Forms.TextBox txtScore4;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtPlayer8;
        private System.Windows.Forms.TextBox txtPlayer6;
        private System.Windows.Forms.TextBox txtPlayer7;
        private System.Windows.Forms.TextBox txtPlayer5;
        private System.Windows.Forms.CheckBox chkPLC;
        private System.Windows.Forms.Timer PLC_Timer;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.Button btnNextPlayer;
        private System.ComponentModel.BackgroundWorker bkgTimer;
        private CustomPbar.Pbar timerBar;
        private System.Windows.Forms.TextBox txtCurrentValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button score_p1_sub;
        private System.Windows.Forms.Button score_p1_add;
        private System.Windows.Forms.Button score_p8_hlf;
        private System.Windows.Forms.Button score_p8_sub;
        private System.Windows.Forms.Button score_p8_add;
        private System.Windows.Forms.Button score_p7_hlf;
        private System.Windows.Forms.Button score_p7_sub;
        private System.Windows.Forms.Button score_p7_add;
        private System.Windows.Forms.Button score_p6_hlf;
        private System.Windows.Forms.Button score_p6_sub;
        private System.Windows.Forms.Button score_p6_add;
        private System.Windows.Forms.Button score_p5_hlf;
        private System.Windows.Forms.Button score_p5_sub;
        private System.Windows.Forms.Button score_p5_add;
        private System.Windows.Forms.Button score_p4_hlf;
        private System.Windows.Forms.Button score_p4_sub;
        private System.Windows.Forms.Button score_p4_add;
        private System.Windows.Forms.Button score_p3_hlf;
        private System.Windows.Forms.Button score_p3_sub;
        private System.Windows.Forms.Button score_p3_add;
        private System.Windows.Forms.Button score_p2_hlf;
        private System.Windows.Forms.Button score_p2_sub;
        private System.Windows.Forms.Button score_p2_add;
        private System.Windows.Forms.Button score_p1_hlf;
        private System.Windows.Forms.ToolStripMenuItem resetScoresToolStripMenuItem;
        private System.Windows.Forms.Button btnBlank;
        private System.Windows.Forms.ToolStripMenuItem nextLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousLevelToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerNamesToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem toggleViewScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTitleImageToolStripMenuItem;
    }
}

