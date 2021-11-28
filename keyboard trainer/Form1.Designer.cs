
namespace keyboard_trainer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StartBtn = new System.Windows.Forms.Button();
            this.WordsCountLabel = new System.Windows.Forms.Label();
            this.WordsCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.CaseCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimeStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordsStripLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordsProgressBarStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.SymbolsStripLb = new System.Windows.Forms.ToolStripStatusLabel();
            this.SymbolsProgressBarStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadWordsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowWordsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowStatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShuflleWordsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StopBtn = new System.Windows.Forms.Button();
            this.WordsBox = new System.Windows.Forms.RichTextBox();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.AccuracyLb = new System.Windows.Forms.Label();
            this.KeyboardGroup = new System.Windows.Forms.GroupBox();
            this.Space = new System.Windows.Forms.Button();
            this.QuestionMark = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Colon = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.J = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.RightShift = new System.Windows.Forms.Button();
            this.LeftShift = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.CapsLock = new System.Windows.Forms.Button();
            this.BracketOpen = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.BracketClose = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.BackSlash = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Dash = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.To = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Apostrophe = new System.Windows.Forms.Button();
            this.KeyboardEnabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.WordsCountNumeric)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.KeyboardGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Location = new System.Drawing.Point(98, 48);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(172, 53);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // WordsCountLabel
            // 
            this.WordsCountLabel.AutoSize = true;
            this.WordsCountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordsCountLabel.Location = new System.Drawing.Point(813, 58);
            this.WordsCountLabel.Name = "WordsCountLabel";
            this.WordsCountLabel.Size = new System.Drawing.Size(86, 32);
            this.WordsCountLabel.TabIndex = 2;
            this.WordsCountLabel.Text = "Words:";
            // 
            // WordsCountNumeric
            // 
            this.WordsCountNumeric.Location = new System.Drawing.Point(905, 56);
            this.WordsCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WordsCountNumeric.Name = "WordsCountNumeric";
            this.WordsCountNumeric.Size = new System.Drawing.Size(121, 39);
            this.WordsCountNumeric.TabIndex = 3;
            this.WordsCountNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // CaseCheckBox
            // 
            this.CaseCheckBox.AutoSize = true;
            this.CaseCheckBox.Checked = true;
            this.CaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CaseCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaseCheckBox.Location = new System.Drawing.Point(1069, 56);
            this.CaseCheckBox.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.CaseCheckBox.Name = "CaseCheckBox";
            this.CaseCheckBox.Size = new System.Drawing.Size(200, 36);
            this.CaseCheckBox.TabIndex = 5;
            this.CaseCheckBox.Text = "Case Sensetive";
            this.CaseCheckBox.UseVisualStyleBackColor = true;
            this.CaseCheckBox.CheckedChanged += new System.EventHandler(this.CaseCheckBox_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeStrip,
            this.WordsStripLb,
            this.WordsProgressBarStrip,
            this.SymbolsStripLb,
            this.SymbolsProgressBarStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 984);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1571, 42);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TimeStrip
            // 
            this.TimeStrip.Margin = new System.Windows.Forms.Padding(100, 6, 200, 4);
            this.TimeStrip.Name = "TimeStrip";
            this.TimeStrip.Size = new System.Drawing.Size(109, 32);
            this.TimeStrip.Text = "Time : 0s";
            // 
            // WordsStripLb
            // 
            this.WordsStripLb.Name = "WordsStripLb";
            this.WordsStripLb.Size = new System.Drawing.Size(93, 32);
            this.WordsStripLb.Text = "Words :";
            // 
            // WordsProgressBarStrip
            // 
            this.WordsProgressBarStrip.Margin = new System.Windows.Forms.Padding(2, 6, 200, 6);
            this.WordsProgressBarStrip.Name = "WordsProgressBarStrip";
            this.WordsProgressBarStrip.Size = new System.Drawing.Size(300, 30);
            this.WordsProgressBarStrip.Step = 1;
            // 
            // SymbolsStripLb
            // 
            this.SymbolsStripLb.Name = "SymbolsStripLb";
            this.SymbolsStripLb.Size = new System.Drawing.Size(115, 32);
            this.SymbolsStripLb.Text = "Symbols :";
            // 
            // SymbolsProgressBarStrip
            // 
            this.SymbolsProgressBarStrip.Name = "SymbolsProgressBarStrip";
            this.SymbolsProgressBarStrip.Size = new System.Drawing.Size(300, 30);
            this.SymbolsProgressBarStrip.Step = 1;
            this.SymbolsProgressBarStrip.ToolTipText = "Symbols :";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1571, 40);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UploadWordsMenu,
            this.ShowWordsMenu,
            this.ShowStatMenu,
            this.ShuflleWordsMenu});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(89, 36);
            this.ToolsMenu.Text = "Tools";
            // 
            // UploadWordsMenu
            // 
            this.UploadWordsMenu.Name = "UploadWordsMenu";
            this.UploadWordsMenu.Size = new System.Drawing.Size(348, 44);
            this.UploadWordsMenu.Text = "Upload your words";
            this.UploadWordsMenu.Click += new System.EventHandler(this.UploadWordsMenu_Click);
            // 
            // ShowWordsMenu
            // 
            this.ShowWordsMenu.Name = "ShowWordsMenu";
            this.ShowWordsMenu.Size = new System.Drawing.Size(348, 44);
            this.ShowWordsMenu.Text = "Show words list";
            this.ShowWordsMenu.Click += new System.EventHandler(this.ShowWordsMenu_Click);
            // 
            // ShowStatMenu
            // 
            this.ShowStatMenu.Name = "ShowStatMenu";
            this.ShowStatMenu.Size = new System.Drawing.Size(348, 44);
            this.ShowStatMenu.Text = "Show statistics";
            this.ShowStatMenu.Click += new System.EventHandler(this.ShowStatMenu_Click);
            // 
            // ShuflleWordsMenu
            // 
            this.ShuflleWordsMenu.Name = "ShuflleWordsMenu";
            this.ShuflleWordsMenu.Size = new System.Drawing.Size(348, 44);
            this.ShuflleWordsMenu.Text = "Shuffle words";
            this.ShuflleWordsMenu.Click += new System.EventHandler(this.ShuflleWordsMenu_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Location = new System.Drawing.Point(313, 48);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(172, 53);
            this.StopBtn.TabIndex = 11;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // WordsBox
            // 
            this.WordsBox.Enabled = false;
            this.WordsBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordsBox.Location = new System.Drawing.Point(44, 199);
            this.WordsBox.Multiline = false;
            this.WordsBox.Name = "WordsBox";
            this.WordsBox.ReadOnly = true;
            this.WordsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.WordsBox.Size = new System.Drawing.Size(1480, 75);
            this.WordsBox.TabIndex = 12;
            this.WordsBox.Text = "";
            // 
            // InputBox
            // 
            this.InputBox.Enabled = false;
            this.InputBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputBox.Location = new System.Drawing.Point(44, 336);
            this.InputBox.Multiline = false;
            this.InputBox.Name = "InputBox";
            this.InputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.InputBox.Size = new System.Drawing.Size(1480, 75);
            this.InputBox.TabIndex = 13;
            this.InputBox.Text = "";
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            this.InputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyUp);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(528, 48);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(172, 53);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeedLabel.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpeedLabel.Location = new System.Drawing.Point(44, 287);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(148, 36);
            this.SpeedLabel.TabIndex = 15;
            this.SpeedLabel.Text = "0 s/min";
            // 
            // AccuracyLb
            // 
            this.AccuracyLb.AutoSize = true;
            this.AccuracyLb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccuracyLb.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccuracyLb.Location = new System.Drawing.Point(44, 142);
            this.AccuracyLb.Name = "AccuracyLb";
            this.AccuracyLb.Size = new System.Drawing.Size(301, 36);
            this.AccuracyLb.TabIndex = 16;
            this.AccuracyLb.Text = "Accuracy:  100%";
            // 
            // KeyboardGroup
            // 
            this.KeyboardGroup.Controls.Add(this.Space);
            this.KeyboardGroup.Controls.Add(this.QuestionMark);
            this.KeyboardGroup.Controls.Add(this.Comma);
            this.KeyboardGroup.Controls.Add(this.Point);
            this.KeyboardGroup.Controls.Add(this.C);
            this.KeyboardGroup.Controls.Add(this.V);
            this.KeyboardGroup.Controls.Add(this.B);
            this.KeyboardGroup.Controls.Add(this.N);
            this.KeyboardGroup.Controls.Add(this.M);
            this.KeyboardGroup.Controls.Add(this.Z);
            this.KeyboardGroup.Controls.Add(this.X);
            this.KeyboardGroup.Controls.Add(this.button12);
            this.KeyboardGroup.Controls.Add(this.Colon);
            this.KeyboardGroup.Controls.Add(this.L);
            this.KeyboardGroup.Controls.Add(this.K);
            this.KeyboardGroup.Controls.Add(this.J);
            this.KeyboardGroup.Controls.Add(this.S);
            this.KeyboardGroup.Controls.Add(this.D);
            this.KeyboardGroup.Controls.Add(this.F);
            this.KeyboardGroup.Controls.Add(this.G);
            this.KeyboardGroup.Controls.Add(this.H);
            this.KeyboardGroup.Controls.Add(this.A);
            this.KeyboardGroup.Controls.Add(this.RightShift);
            this.KeyboardGroup.Controls.Add(this.LeftShift);
            this.KeyboardGroup.Controls.Add(this.Enter);
            this.KeyboardGroup.Controls.Add(this.CapsLock);
            this.KeyboardGroup.Controls.Add(this.BracketOpen);
            this.KeyboardGroup.Controls.Add(this.O);
            this.KeyboardGroup.Controls.Add(this.P);
            this.KeyboardGroup.Controls.Add(this.BracketClose);
            this.KeyboardGroup.Controls.Add(this.Nine);
            this.KeyboardGroup.Controls.Add(this.I);
            this.KeyboardGroup.Controls.Add(this.T);
            this.KeyboardGroup.Controls.Add(this.Y);
            this.KeyboardGroup.Controls.Add(this.U);
            this.KeyboardGroup.Controls.Add(this.W);
            this.KeyboardGroup.Controls.Add(this.E);
            this.KeyboardGroup.Controls.Add(this.R);
            this.KeyboardGroup.Controls.Add(this.BackSlash);
            this.KeyboardGroup.Controls.Add(this.Q);
            this.KeyboardGroup.Controls.Add(this.Tab);
            this.KeyboardGroup.Controls.Add(this.Zero);
            this.KeyboardGroup.Controls.Add(this.Dash);
            this.KeyboardGroup.Controls.Add(this.Equals);
            this.KeyboardGroup.Controls.Add(this.Six);
            this.KeyboardGroup.Controls.Add(this.Seven);
            this.KeyboardGroup.Controls.Add(this.Eight);
            this.KeyboardGroup.Controls.Add(this.To);
            this.KeyboardGroup.Controls.Add(this.Three);
            this.KeyboardGroup.Controls.Add(this.Four);
            this.KeyboardGroup.Controls.Add(this.Five);
            this.KeyboardGroup.Controls.Add(this.Back);
            this.KeyboardGroup.Controls.Add(this.One);
            this.KeyboardGroup.Controls.Add(this.Apostrophe);
            this.KeyboardGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyboardGroup.Location = new System.Drawing.Point(6, 415);
            this.KeyboardGroup.Name = "KeyboardGroup";
            this.KeyboardGroup.Size = new System.Drawing.Size(1557, 557);
            this.KeyboardGroup.TabIndex = 18;
            this.KeyboardGroup.TabStop = false;
            this.KeyboardGroup.Enter += new System.EventHandler(this.KeyboardGroup_Enter);
            // 
            // Space
            // 
            this.Space.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Space.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Space.Location = new System.Drawing.Point(471, 466);
            this.Space.Margin = new System.Windows.Forms.Padding(24);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(615, 80);
            this.Space.TabIndex = 64;
            this.Space.Text = " ";
            this.Space.UseVisualStyleBackColor = true;
            // 
            // QuestionMark
            // 
            this.QuestionMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionMark.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuestionMark.Location = new System.Drawing.Point(1218, 359);
            this.QuestionMark.Margin = new System.Windows.Forms.Padding(24);
            this.QuestionMark.Name = "QuestionMark";
            this.QuestionMark.Size = new System.Drawing.Size(80, 80);
            this.QuestionMark.TabIndex = 63;
            this.QuestionMark.Text = "?";
            this.QuestionMark.UseVisualStyleBackColor = true;
            // 
            // Comma
            // 
            this.Comma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comma.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Comma.Location = new System.Drawing.Point(1007, 359);
            this.Comma.Margin = new System.Windows.Forms.Padding(24);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(80, 80);
            this.Comma.TabIndex = 62;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            // 
            // Point
            // 
            this.Point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Point.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Point.Location = new System.Drawing.Point(1113, 359);
            this.Point.Margin = new System.Windows.Forms.Padding(24);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(80, 80);
            this.Point.TabIndex = 61;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.C.Location = new System.Drawing.Point(471, 359);
            this.C.Margin = new System.Windows.Forms.Padding(24);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(80, 80);
            this.C.TabIndex = 60;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // V
            // 
            this.V.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.V.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.V.Location = new System.Drawing.Point(578, 359);
            this.V.Margin = new System.Windows.Forms.Padding(24);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(80, 80);
            this.V.TabIndex = 59;
            this.V.Text = "V";
            this.V.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B.Location = new System.Drawing.Point(685, 359);
            this.B.Margin = new System.Windows.Forms.Padding(24);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(80, 80);
            this.B.TabIndex = 58;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // N
            // 
            this.N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.N.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.N.Location = new System.Drawing.Point(792, 359);
            this.N.Margin = new System.Windows.Forms.Padding(24);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(80, 80);
            this.N.TabIndex = 57;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = true;
            // 
            // M
            // 
            this.M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.M.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.M.Location = new System.Drawing.Point(899, 359);
            this.M.Margin = new System.Windows.Forms.Padding(24);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(80, 80);
            this.M.TabIndex = 56;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = true;
            // 
            // Z
            // 
            this.Z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Z.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Z.Location = new System.Drawing.Point(257, 359);
            this.Z.Margin = new System.Windows.Forms.Padding(24);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(80, 80);
            this.Z.TabIndex = 55;
            this.Z.Text = "Z";
            this.Z.UseVisualStyleBackColor = true;
            // 
            // X
            // 
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.X.Location = new System.Drawing.Point(364, 359);
            this.X.Margin = new System.Windows.Forms.Padding(24);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(80, 80);
            this.X.TabIndex = 54;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(1260, 252);
            this.button12.Margin = new System.Windows.Forms.Padding(24);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 80);
            this.button12.TabIndex = 53;
            this.button12.Text = "\'";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Colon
            // 
            this.Colon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Colon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Colon.Location = new System.Drawing.Point(1153, 252);
            this.Colon.Margin = new System.Windows.Forms.Padding(24);
            this.Colon.Name = "Colon";
            this.Colon.Size = new System.Drawing.Size(80, 80);
            this.Colon.TabIndex = 52;
            this.Colon.Text = ":";
            this.Colon.UseVisualStyleBackColor = true;
            // 
            // L
            // 
            this.L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.L.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L.Location = new System.Drawing.Point(1046, 252);
            this.L.Margin = new System.Windows.Forms.Padding(24);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(80, 80);
            this.L.TabIndex = 51;
            this.L.Text = "L";
            this.L.UseVisualStyleBackColor = true;
            // 
            // K
            // 
            this.K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.K.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.K.Location = new System.Drawing.Point(939, 252);
            this.K.Margin = new System.Windows.Forms.Padding(24);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(80, 80);
            this.K.TabIndex = 50;
            this.K.Text = "K";
            this.K.UseVisualStyleBackColor = true;
            // 
            // J
            // 
            this.J.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.J.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.J.Location = new System.Drawing.Point(832, 252);
            this.J.Margin = new System.Windows.Forms.Padding(24);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(80, 80);
            this.J.TabIndex = 49;
            this.J.Text = "J";
            this.J.UseVisualStyleBackColor = true;
            // 
            // S
            // 
            this.S.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.S.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.S.Location = new System.Drawing.Point(297, 252);
            this.S.Margin = new System.Windows.Forms.Padding(24);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(80, 80);
            this.S.TabIndex = 48;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.D.Location = new System.Drawing.Point(404, 252);
            this.D.Margin = new System.Windows.Forms.Padding(24);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(80, 80);
            this.D.TabIndex = 47;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.F.Location = new System.Drawing.Point(511, 252);
            this.F.Margin = new System.Windows.Forms.Padding(24);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(80, 80);
            this.F.TabIndex = 46;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            // 
            // G
            // 
            this.G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.G.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.G.Location = new System.Drawing.Point(618, 252);
            this.G.Margin = new System.Windows.Forms.Padding(24);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(80, 80);
            this.G.TabIndex = 45;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            // 
            // H
            // 
            this.H.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.H.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.H.Location = new System.Drawing.Point(725, 252);
            this.H.Margin = new System.Windows.Forms.Padding(24);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(80, 80);
            this.H.TabIndex = 44;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.A.Location = new System.Drawing.Point(190, 252);
            this.A.Margin = new System.Windows.Forms.Padding(24);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(80, 80);
            this.A.TabIndex = 43;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // RightShift
            // 
            this.RightShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightShift.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RightShift.Location = new System.Drawing.Point(1327, 359);
            this.RightShift.Margin = new System.Windows.Forms.Padding(24);
            this.RightShift.Name = "RightShift";
            this.RightShift.Size = new System.Drawing.Size(227, 80);
            this.RightShift.TabIndex = 42;
            this.RightShift.Text = "Shift";
            this.RightShift.UseVisualStyleBackColor = true;
            // 
            // LeftShift
            // 
            this.LeftShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftShift.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LeftShift.Location = new System.Drawing.Point(3, 359);
            this.LeftShift.Margin = new System.Windows.Forms.Padding(24);
            this.LeftShift.Name = "LeftShift";
            this.LeftShift.Size = new System.Drawing.Size(227, 80);
            this.LeftShift.TabIndex = 41;
            this.LeftShift.Text = "Shift";
            this.LeftShift.UseVisualStyleBackColor = true;
            // 
            // Enter
            // 
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enter.Location = new System.Drawing.Point(1367, 252);
            this.Enter.Margin = new System.Windows.Forms.Padding(24);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(187, 80);
            this.Enter.TabIndex = 40;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // CapsLock
            // 
            this.CapsLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CapsLock.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CapsLock.Location = new System.Drawing.Point(3, 252);
            this.CapsLock.Margin = new System.Windows.Forms.Padding(24);
            this.CapsLock.Name = "CapsLock";
            this.CapsLock.Size = new System.Drawing.Size(160, 80);
            this.CapsLock.TabIndex = 39;
            this.CapsLock.Text = "Caps lock";
            this.CapsLock.UseVisualStyleBackColor = true;
            // 
            // BracketOpen
            // 
            this.BracketOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BracketOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BracketOpen.Location = new System.Drawing.Point(1218, 145);
            this.BracketOpen.Margin = new System.Windows.Forms.Padding(24);
            this.BracketOpen.Name = "BracketOpen";
            this.BracketOpen.Size = new System.Drawing.Size(80, 80);
            this.BracketOpen.TabIndex = 38;
            this.BracketOpen.Text = "{";
            this.BracketOpen.UseVisualStyleBackColor = true;
            // 
            // O
            // 
            this.O.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.O.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.O.Location = new System.Drawing.Point(1006, 145);
            this.O.Margin = new System.Windows.Forms.Padding(24);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(80, 80);
            this.O.TabIndex = 37;
            this.O.Text = "O";
            this.O.UseVisualStyleBackColor = true;
            // 
            // P
            // 
            this.P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.P.Location = new System.Drawing.Point(1113, 145);
            this.P.Margin = new System.Windows.Forms.Padding(24);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(80, 80);
            this.P.TabIndex = 36;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = true;
            // 
            // BracketClose
            // 
            this.BracketClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BracketClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BracketClose.Location = new System.Drawing.Point(1327, 145);
            this.BracketClose.Margin = new System.Windows.Forms.Padding(24);
            this.BracketClose.Name = "BracketClose";
            this.BracketClose.Size = new System.Drawing.Size(80, 80);
            this.BracketClose.TabIndex = 35;
            this.BracketClose.Text = "}";
            this.BracketClose.UseVisualStyleBackColor = true;
            // 
            // Nine
            // 
            this.Nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nine.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nine.Location = new System.Drawing.Point(966, 38);
            this.Nine.Margin = new System.Windows.Forms.Padding(24);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(80, 80);
            this.Nine.TabIndex = 34;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            // 
            // I
            // 
            this.I.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.I.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.I.Location = new System.Drawing.Point(899, 145);
            this.I.Margin = new System.Windows.Forms.Padding(24);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(80, 80);
            this.I.TabIndex = 33;
            this.I.Text = "I";
            this.I.UseVisualStyleBackColor = true;
            // 
            // T
            // 
            this.T.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.T.Location = new System.Drawing.Point(578, 145);
            this.T.Margin = new System.Windows.Forms.Padding(24);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(80, 80);
            this.T.TabIndex = 32;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            // 
            // Y
            // 
            this.Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Y.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Y.Location = new System.Drawing.Point(685, 145);
            this.Y.Margin = new System.Windows.Forms.Padding(24);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(80, 80);
            this.Y.TabIndex = 31;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = true;
            // 
            // U
            // 
            this.U.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.U.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.U.Location = new System.Drawing.Point(792, 145);
            this.U.Margin = new System.Windows.Forms.Padding(24);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(80, 80);
            this.U.TabIndex = 30;
            this.U.Text = "U";
            this.U.UseVisualStyleBackColor = true;
            // 
            // W
            // 
            this.W.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.W.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.W.Location = new System.Drawing.Point(257, 145);
            this.W.Margin = new System.Windows.Forms.Padding(24);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(80, 80);
            this.W.TabIndex = 29;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = true;
            // 
            // E
            // 
            this.E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.E.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.E.Location = new System.Drawing.Point(364, 145);
            this.E.Margin = new System.Windows.Forms.Padding(24);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(80, 80);
            this.E.TabIndex = 28;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            // 
            // R
            // 
            this.R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R.Location = new System.Drawing.Point(471, 145);
            this.R.Margin = new System.Windows.Forms.Padding(24);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(80, 80);
            this.R.TabIndex = 27;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            // 
            // BackSlash
            // 
            this.BackSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackSlash.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackSlash.Location = new System.Drawing.Point(1434, 145);
            this.BackSlash.Margin = new System.Windows.Forms.Padding(24);
            this.BackSlash.Name = "BackSlash";
            this.BackSlash.Size = new System.Drawing.Size(120, 80);
            this.BackSlash.TabIndex = 26;
            this.BackSlash.Text = "\\";
            this.BackSlash.UseVisualStyleBackColor = true;
            // 
            // Q
            // 
            this.Q.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Q.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Q.Location = new System.Drawing.Point(150, 145);
            this.Q.Margin = new System.Windows.Forms.Padding(24);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(80, 80);
            this.Q.TabIndex = 25;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = true;
            // 
            // Tab
            // 
            this.Tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tab.Location = new System.Drawing.Point(3, 145);
            this.Tab.Margin = new System.Windows.Forms.Padding(24);
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(120, 80);
            this.Tab.TabIndex = 24;
            this.Tab.Text = "TAB";
            this.Tab.UseVisualStyleBackColor = true;
            // 
            // Zero
            // 
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Zero.Location = new System.Drawing.Point(1073, 38);
            this.Zero.Margin = new System.Windows.Forms.Padding(24);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(80, 80);
            this.Zero.TabIndex = 23;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            // 
            // Dash
            // 
            this.Dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dash.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dash.Location = new System.Drawing.Point(1180, 38);
            this.Dash.Margin = new System.Windows.Forms.Padding(24);
            this.Dash.Name = "Dash";
            this.Dash.Size = new System.Drawing.Size(80, 80);
            this.Dash.TabIndex = 22;
            this.Dash.Text = "-";
            this.Dash.UseVisualStyleBackColor = true;
            // 
            // Equals
            // 
            this.Equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equals.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equals.Location = new System.Drawing.Point(1287, 38);
            this.Equals.Margin = new System.Windows.Forms.Padding(24);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(80, 80);
            this.Equals.TabIndex = 21;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            // 
            // Six
            // 
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Six.Location = new System.Drawing.Point(645, 38);
            this.Six.Margin = new System.Windows.Forms.Padding(24);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(80, 80);
            this.Six.TabIndex = 20;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            // 
            // Seven
            // 
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Seven.Location = new System.Drawing.Point(752, 38);
            this.Seven.Margin = new System.Windows.Forms.Padding(24);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(80, 80);
            this.Seven.TabIndex = 19;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            // 
            // Eight
            // 
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Eight.Location = new System.Drawing.Point(859, 38);
            this.Eight.Margin = new System.Windows.Forms.Padding(24);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(80, 80);
            this.Eight.TabIndex = 18;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            // 
            // To
            // 
            this.To.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.To.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.To.Location = new System.Drawing.Point(217, 38);
            this.To.Margin = new System.Windows.Forms.Padding(24);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(80, 80);
            this.To.TabIndex = 17;
            this.To.Text = "2";
            this.To.UseVisualStyleBackColor = true;
            // 
            // Three
            // 
            this.Three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Three.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Three.Location = new System.Drawing.Point(324, 38);
            this.Three.Margin = new System.Windows.Forms.Padding(24);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(80, 80);
            this.Three.TabIndex = 16;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            // 
            // Four
            // 
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Four.Location = new System.Drawing.Point(431, 38);
            this.Four.Margin = new System.Windows.Forms.Padding(24);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(80, 80);
            this.Four.TabIndex = 15;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            // 
            // Five
            // 
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Five.Location = new System.Drawing.Point(538, 38);
            this.Five.Margin = new System.Windows.Forms.Padding(24);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(80, 80);
            this.Five.TabIndex = 14;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(1394, 38);
            this.Back.Margin = new System.Windows.Forms.Padding(24);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(160, 80);
            this.Back.TabIndex = 13;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // One
            // 
            this.One.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.One.Location = new System.Drawing.Point(110, 38);
            this.One.Margin = new System.Windows.Forms.Padding(24);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(80, 80);
            this.One.TabIndex = 7;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            // 
            // Apostrophe
            // 
            this.Apostrophe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apostrophe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Apostrophe.Location = new System.Drawing.Point(3, 38);
            this.Apostrophe.Margin = new System.Windows.Forms.Padding(24);
            this.Apostrophe.Name = "Apostrophe";
            this.Apostrophe.Size = new System.Drawing.Size(80, 80);
            this.Apostrophe.TabIndex = 0;
            this.Apostrophe.Text = "`";
            this.Apostrophe.UseVisualStyleBackColor = true;
            // 
            // KeyboardEnabled
            // 
            this.KeyboardEnabled.AutoSize = true;
            this.KeyboardEnabled.Checked = true;
            this.KeyboardEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KeyboardEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyboardEnabled.Location = new System.Drawing.Point(1312, 56);
            this.KeyboardEnabled.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.KeyboardEnabled.Name = "KeyboardEnabled";
            this.KeyboardEnabled.Size = new System.Drawing.Size(220, 36);
            this.KeyboardEnabled.TabIndex = 19;
            this.KeyboardEnabled.Text = "Enable Keyboard";
            this.KeyboardEnabled.UseVisualStyleBackColor = true;
            this.KeyboardEnabled.CheckedChanged += new System.EventHandler(this.KeyboardEnabled_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 1026);
            this.Controls.Add(this.KeyboardEnabled);
            this.Controls.Add(this.KeyboardGroup);
            this.Controls.Add(this.AccuracyLb);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.WordsBox);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CaseCheckBox);
            this.Controls.Add(this.WordsCountNumeric);
            this.Controls.Add(this.WordsCountLabel);
            this.Controls.Add(this.StartBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Keyboard Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.WordsCountNumeric)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.KeyboardGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label WordsCountLabel;
        private System.Windows.Forms.NumericUpDown WordsCountNumeric;
        private System.Windows.Forms.CheckBox CaseCheckBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TimeStrip;
        private System.Windows.Forms.ToolStripProgressBar WordsProgressBarStrip;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem UploadWordsMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowWordsMenu;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.RichTextBox WordsBox;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.ToolStripStatusLabel WordsStripLb;
        private System.Windows.Forms.ToolStripStatusLabel SymbolsStripLb;
        private System.Windows.Forms.ToolStripProgressBar SymbolsProgressBarStrip;
        private System.Windows.Forms.ToolStripMenuItem ShowStatMenu;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label AccuracyLb;
        private System.Windows.Forms.GroupBox KeyboardGroup;
        private System.Windows.Forms.Button Apostrophe;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Dash;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button To;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Tab;
        private System.Windows.Forms.Button BackSlash;
        private System.Windows.Forms.Button Q;
        private System.Windows.Forms.Button W;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button T;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button U;
        private System.Windows.Forms.Button O;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button BracketClose;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Button BracketOpen;
        private System.Windows.Forms.Button CapsLock;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button LeftShift;
        private System.Windows.Forms.Button RightShift;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button H;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button Colon;
        private System.Windows.Forms.Button L;
        private System.Windows.Forms.Button K;
        private System.Windows.Forms.Button J;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Z;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button V;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button N;
        private System.Windows.Forms.Button M;
        private System.Windows.Forms.Button QuestionMark;
        private System.Windows.Forms.Button Space;
        private System.Windows.Forms.CheckBox KeyboardEnabled;
        private System.Windows.Forms.ToolStripMenuItem ShuflleWordsMenu;
    }
}

