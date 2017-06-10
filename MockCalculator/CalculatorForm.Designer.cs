namespace StockCalculator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Result = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ButtFact = new System.Windows.Forms.Button();
            this.ButtonOpenBrac = new System.Windows.Forms.Button();
            this.ButtCloseBrac = new System.Windows.Forms.Button();
            this.ButtPer = new System.Windows.Forms.Button();
            this.ButtCE = new System.Windows.Forms.Button();
            this.ButtSin = new System.Windows.Forms.Button();
            this.ButtNatLog = new System.Windows.Forms.Button();
            this.Butt1 = new System.Windows.Forms.Button();
            this.Butt2 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.ButtDev = new System.Windows.Forms.Button();
            this.ButtCos = new System.Windows.Forms.Button();
            this.ButtLog = new System.Windows.Forms.Button();
            this.Butt4 = new System.Windows.Forms.Button();
            this.Butt5 = new System.Windows.Forms.Button();
            this.Butt6 = new System.Windows.Forms.Button();
            this.ButtMult = new System.Windows.Forms.Button();
            this.ButtTan = new System.Windows.Forms.Button();
            this.ButtRoot = new System.Windows.Forms.Button();
            this.Butt7 = new System.Windows.Forms.Button();
            this.Butt8 = new System.Windows.Forms.Button();
            this.Butt9 = new System.Windows.Forms.Button();
            this.ButtSub = new System.Windows.Forms.Button();
            this.ButtExp = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.Butt0 = new System.Windows.Forms.Button();
            this.ButtDec = new System.Windows.Forms.Button();
            this.ButtEq = new System.Windows.Forms.Button();
            this.ButtAdd = new System.Windows.Forms.Button();
            this.Fetcher = new System.Windows.Forms.Button();
            this.TopLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stockTitle = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.SystemColors.Info;
            this.Result.Location = new System.Drawing.Point(17, 24);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(480, 22);
            this.Result.TabIndex = 0;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(17, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "e";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ButtFact
            // 
            this.ButtFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtFact.Location = new System.Drawing.Point(98, 62);
            this.ButtFact.Name = "ButtFact";
            this.ButtFact.Size = new System.Drawing.Size(75, 29);
            this.ButtFact.TabIndex = 11;
            this.ButtFact.Text = "x!";
            this.ButtFact.UseVisualStyleBackColor = false;
            this.ButtFact.Click += new System.EventHandler(this.math_click);
            // 
            // ButtonOpenBrac
            // 
            this.ButtonOpenBrac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonOpenBrac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOpenBrac.Location = new System.Drawing.Point(179, 62);
            this.ButtonOpenBrac.Name = "ButtonOpenBrac";
            this.ButtonOpenBrac.Size = new System.Drawing.Size(75, 29);
            this.ButtonOpenBrac.TabIndex = 12;
            this.ButtonOpenBrac.Text = "(";
            this.ButtonOpenBrac.UseVisualStyleBackColor = false;
            this.ButtonOpenBrac.Click += new System.EventHandler(this.brackClick);
            // 
            // ButtCloseBrac
            // 
            this.ButtCloseBrac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtCloseBrac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtCloseBrac.Location = new System.Drawing.Point(260, 62);
            this.ButtCloseBrac.Name = "ButtCloseBrac";
            this.ButtCloseBrac.Size = new System.Drawing.Size(75, 29);
            this.ButtCloseBrac.TabIndex = 13;
            this.ButtCloseBrac.Text = ")";
            this.ButtCloseBrac.UseVisualStyleBackColor = false;
            this.ButtCloseBrac.Click += new System.EventHandler(this.brackClick);
            // 
            // ButtPer
            // 
            this.ButtPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtPer.Location = new System.Drawing.Point(341, 62);
            this.ButtPer.Name = "ButtPer";
            this.ButtPer.Size = new System.Drawing.Size(75, 29);
            this.ButtPer.TabIndex = 14;
            this.ButtPer.Text = "%";
            this.ButtPer.UseVisualStyleBackColor = false;
            // 
            // ButtCE
            // 
            this.ButtCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtCE.Location = new System.Drawing.Point(422, 62);
            this.ButtCE.Name = "ButtCE";
            this.ButtCE.Size = new System.Drawing.Size(75, 29);
            this.ButtCE.TabIndex = 15;
            this.ButtCE.Text = "CE";
            this.ButtCE.UseVisualStyleBackColor = false;
            this.ButtCE.Click += new System.EventHandler(this.ButtCE_Click);
            // 
            // ButtSin
            // 
            this.ButtSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtSin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtSin.Location = new System.Drawing.Point(17, 97);
            this.ButtSin.Name = "ButtSin";
            this.ButtSin.Size = new System.Drawing.Size(75, 27);
            this.ButtSin.TabIndex = 16;
            this.ButtSin.Text = "sin";
            this.ButtSin.UseVisualStyleBackColor = false;
            this.ButtSin.Click += new System.EventHandler(this.math_click);
            // 
            // ButtNatLog
            // 
            this.ButtNatLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtNatLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtNatLog.Location = new System.Drawing.Point(98, 97);
            this.ButtNatLog.Name = "ButtNatLog";
            this.ButtNatLog.Size = new System.Drawing.Size(75, 27);
            this.ButtNatLog.TabIndex = 17;
            this.ButtNatLog.Text = "ln";
            this.ButtNatLog.UseVisualStyleBackColor = false;
            this.ButtNatLog.Click += new System.EventHandler(this.math_click);
            // 
            // Butt1
            // 
            this.Butt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Butt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butt1.Location = new System.Drawing.Point(179, 97);
            this.Butt1.Name = "Butt1";
            this.Butt1.Size = new System.Drawing.Size(75, 27);
            this.Butt1.TabIndex = 18;
            this.Butt1.Text = "1";
            this.Butt1.UseVisualStyleBackColor = false;
            this.Butt1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Butt2
            // 
            this.Butt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butt2.Location = new System.Drawing.Point(260, 97);
            this.Butt2.Name = "Butt2";
            this.Butt2.Size = new System.Drawing.Size(75, 27);
            this.Butt2.TabIndex = 19;
            this.Butt2.Text = "2";
            this.Butt2.UseVisualStyleBackColor = false;
            this.Butt2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Location = new System.Drawing.Point(341, 97);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 27);
            this.button15.TabIndex = 20;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtDev
            // 
            this.ButtDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtDev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtDev.Location = new System.Drawing.Point(422, 97);
            this.ButtDev.Name = "ButtDev";
            this.ButtDev.Size = new System.Drawing.Size(75, 27);
            this.ButtDev.TabIndex = 21;
            this.ButtDev.Text = "/";
            this.ButtDev.UseVisualStyleBackColor = false;
            this.ButtDev.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ButtCos
            // 
            this.ButtCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtCos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtCos.Location = new System.Drawing.Point(17, 130);
            this.ButtCos.Name = "ButtCos";
            this.ButtCos.Size = new System.Drawing.Size(75, 27);
            this.ButtCos.TabIndex = 23;
            this.ButtCos.Text = "cos";
            this.ButtCos.UseVisualStyleBackColor = false;
            this.ButtCos.Click += new System.EventHandler(this.math_click);
            // 
            // ButtLog
            // 
            this.ButtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtLog.Location = new System.Drawing.Point(98, 130);
            this.ButtLog.Name = "ButtLog";
            this.ButtLog.Size = new System.Drawing.Size(75, 27);
            this.ButtLog.TabIndex = 24;
            this.ButtLog.Text = "log";
            this.ButtLog.UseVisualStyleBackColor = false;
            this.ButtLog.Click += new System.EventHandler(this.math_click);
            // 
            // Butt4
            // 
            this.Butt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butt4.Location = new System.Drawing.Point(179, 130);
            this.Butt4.Name = "Butt4";
            this.Butt4.Size = new System.Drawing.Size(75, 27);
            this.Butt4.TabIndex = 25;
            this.Butt4.Text = "4";
            this.Butt4.UseVisualStyleBackColor = false;
            this.Butt4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Butt5
            // 
            this.Butt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butt5.Location = new System.Drawing.Point(260, 130);
            this.Butt5.Name = "Butt5";
            this.Butt5.Size = new System.Drawing.Size(75, 27);
            this.Butt5.TabIndex = 26;
            this.Butt5.Text = "5";
            this.Butt5.UseVisualStyleBackColor = false;
            this.Butt5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Butt6
            // 
            this.Butt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butt6.Location = new System.Drawing.Point(341, 130);
            this.Butt6.Name = "Butt6";
            this.Butt6.Size = new System.Drawing.Size(75, 27);
            this.Butt6.TabIndex = 27;
            this.Butt6.Text = "6";
            this.Butt6.UseVisualStyleBackColor = false;
            this.Butt6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtMult
            // 
            this.ButtMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtMult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtMult.Location = new System.Drawing.Point(422, 130);
            this.ButtMult.Name = "ButtMult";
            this.ButtMult.Size = new System.Drawing.Size(75, 27);
            this.ButtMult.TabIndex = 28;
            this.ButtMult.Text = "*";
            this.ButtMult.UseVisualStyleBackColor = false;
            this.ButtMult.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ButtTan
            // 
            this.ButtTan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtTan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtTan.Location = new System.Drawing.Point(17, 163);
            this.ButtTan.Name = "ButtTan";
            this.ButtTan.Size = new System.Drawing.Size(75, 23);
            this.ButtTan.TabIndex = 29;
            this.ButtTan.Text = "tan";
            this.ButtTan.UseVisualStyleBackColor = false;
            this.ButtTan.Click += new System.EventHandler(this.math_click);
            // 
            // ButtRoot
            // 
            this.ButtRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtRoot.Location = new System.Drawing.Point(98, 163);
            this.ButtRoot.Name = "ButtRoot";
            this.ButtRoot.Size = new System.Drawing.Size(75, 23);
            this.ButtRoot.TabIndex = 30;
            this.ButtRoot.Text = "√";
            this.ButtRoot.UseVisualStyleBackColor = false;
            this.ButtRoot.Click += new System.EventHandler(this.math_click);
            // 
            // Butt7
            // 
            this.Butt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butt7.Location = new System.Drawing.Point(179, 163);
            this.Butt7.Name = "Butt7";
            this.Butt7.Size = new System.Drawing.Size(75, 23);
            this.Butt7.TabIndex = 31;
            this.Butt7.Text = "7";
            this.Butt7.UseVisualStyleBackColor = false;
            this.Butt7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Butt8
            // 
            this.Butt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butt8.Location = new System.Drawing.Point(260, 163);
            this.Butt8.Name = "Butt8";
            this.Butt8.Size = new System.Drawing.Size(75, 23);
            this.Butt8.TabIndex = 32;
            this.Butt8.Text = "8";
            this.Butt8.UseVisualStyleBackColor = false;
            this.Butt8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Butt9
            // 
            this.Butt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butt9.Location = new System.Drawing.Point(341, 163);
            this.Butt9.Name = "Butt9";
            this.Butt9.Size = new System.Drawing.Size(75, 23);
            this.Butt9.TabIndex = 33;
            this.Butt9.Text = "9";
            this.Butt9.UseVisualStyleBackColor = false;
            this.Butt9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtSub
            // 
            this.ButtSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtSub.Location = new System.Drawing.Point(422, 163);
            this.ButtSub.Name = "ButtSub";
            this.ButtSub.Size = new System.Drawing.Size(75, 23);
            this.ButtSub.TabIndex = 34;
            this.ButtSub.Text = "-";
            this.ButtSub.UseVisualStyleBackColor = false;
            this.ButtSub.Click += new System.EventHandler(this.OperatorClick);
            // 
            // ButtExp
            // 
            this.ButtExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtExp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtExp.Location = new System.Drawing.Point(17, 192);
            this.ButtExp.Name = "ButtExp";
            this.ButtExp.Size = new System.Drawing.Size(75, 28);
            this.ButtExp.TabIndex = 35;
            this.ButtExp.Text = "EXP";
            this.ButtExp.UseVisualStyleBackColor = false;
            this.ButtExp.Click += new System.EventHandler(this.math_click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button30.Location = new System.Drawing.Point(98, 192);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 28);
            this.button30.TabIndex = 36;
            this.button30.Text = "π";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // Butt0
            // 
            this.Butt0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Butt0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butt0.Location = new System.Drawing.Point(179, 192);
            this.Butt0.Name = "Butt0";
            this.Butt0.Size = new System.Drawing.Size(75, 28);
            this.Butt0.TabIndex = 37;
            this.Butt0.Text = "0";
            this.Butt0.UseVisualStyleBackColor = false;
            this.Butt0.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtDec
            // 
            this.ButtDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtDec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtDec.Location = new System.Drawing.Point(260, 192);
            this.ButtDec.Name = "ButtDec";
            this.ButtDec.Size = new System.Drawing.Size(75, 28);
            this.ButtDec.TabIndex = 38;
            this.ButtDec.Text = ".";
            this.ButtDec.UseVisualStyleBackColor = false;
            this.ButtDec.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtEq
            // 
            this.ButtEq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtEq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtEq.Location = new System.Drawing.Point(341, 192);
            this.ButtEq.Name = "ButtEq";
            this.ButtEq.Size = new System.Drawing.Size(75, 28);
            this.ButtEq.TabIndex = 39;
            this.ButtEq.Text = "=";
            this.ButtEq.UseVisualStyleBackColor = false;
            this.ButtEq.Click += new System.EventHandler(this.ButtEq_Click);
            // 
            // ButtAdd
            // 
            this.ButtAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtAdd.Location = new System.Drawing.Point(422, 192);
            this.ButtAdd.Name = "ButtAdd";
            this.ButtAdd.Size = new System.Drawing.Size(75, 28);
            this.ButtAdd.TabIndex = 40;
            this.ButtAdd.Text = "+";
            this.ButtAdd.UseVisualStyleBackColor = false;
            this.ButtAdd.Click += new System.EventHandler(this.OperatorClick);
            // 
            // Fetcher
            // 
            this.Fetcher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fetcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fetcher.Location = new System.Drawing.Point(223, 229);
            this.Fetcher.Name = "Fetcher";
            this.Fetcher.Size = new System.Drawing.Size(98, 23);
            this.Fetcher.TabIndex = 50;
            this.Fetcher.Text = "Fetch Data";
            this.Fetcher.UseVisualStyleBackColor = false;
            this.Fetcher.Click += new System.EventHandler(this.FetchData_Click);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopLabel.Location = new System.Drawing.Point(445, 3);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(0, 18);
            this.TopLabel.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(14, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Stock Name:";
            // 
            // stockTitle
            // 
            this.stockTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stockTitle.Location = new System.Drawing.Point(89, 229);
            this.stockTitle.Multiline = true;
            this.stockTitle.Name = "stockTitle";
            this.stockTitle.Size = new System.Drawing.Size(128, 23);
            this.stockTitle.TabIndex = 62;
            // 
            // chart
            // 
            this.chart.AccessibleName = "";
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(503, 3);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(536, 249);
            this.chart.TabIndex = 60;
            this.chart.Text = "chart";
            this.chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Show_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(417, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.TabIndex = 63;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(327, 229);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 23);
            this.addButton.TabIndex = 64;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1046, 262);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stockTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.Fetcher);
            this.Controls.Add(this.ButtAdd);
            this.Controls.Add(this.ButtEq);
            this.Controls.Add(this.ButtDec);
            this.Controls.Add(this.Butt0);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.ButtExp);
            this.Controls.Add(this.ButtSub);
            this.Controls.Add(this.Butt9);
            this.Controls.Add(this.Butt8);
            this.Controls.Add(this.Butt7);
            this.Controls.Add(this.ButtRoot);
            this.Controls.Add(this.ButtTan);
            this.Controls.Add(this.ButtMult);
            this.Controls.Add(this.Butt6);
            this.Controls.Add(this.Butt5);
            this.Controls.Add(this.Butt4);
            this.Controls.Add(this.ButtLog);
            this.Controls.Add(this.ButtCos);
            this.Controls.Add(this.ButtDev);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.Butt2);
            this.Controls.Add(this.Butt1);
            this.Controls.Add(this.ButtNatLog);
            this.Controls.Add(this.ButtSin);
            this.Controls.Add(this.ButtCE);
            this.Controls.Add(this.ButtPer);
            this.Controls.Add(this.ButtCloseBrac);
            this.Controls.Add(this.ButtonOpenBrac);
            this.Controls.Add(this.ButtFact);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtFact;
        private System.Windows.Forms.Button ButtonOpenBrac;
        private System.Windows.Forms.Button ButtCloseBrac;
        private System.Windows.Forms.Button ButtPer;
        private System.Windows.Forms.Button ButtCE;
        private System.Windows.Forms.Button ButtSin;
        private System.Windows.Forms.Button ButtNatLog;
        private System.Windows.Forms.Button Butt1;
        private System.Windows.Forms.Button Butt2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button ButtDev;
        private System.Windows.Forms.Button ButtCos;
        private System.Windows.Forms.Button ButtLog;
        private System.Windows.Forms.Button Butt4;
        private System.Windows.Forms.Button Butt5;
        private System.Windows.Forms.Button Butt6;
        private System.Windows.Forms.Button ButtMult;
        private System.Windows.Forms.Button ButtTan;
        private System.Windows.Forms.Button ButtRoot;
        private System.Windows.Forms.Button Butt7;
        private System.Windows.Forms.Button Butt8;
        private System.Windows.Forms.Button Butt9;
        private System.Windows.Forms.Button ButtSub;
        private System.Windows.Forms.Button ButtExp;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button Butt0;
        private System.Windows.Forms.Button ButtDec;
        private System.Windows.Forms.Button ButtEq;
        private System.Windows.Forms.Button ButtAdd;
        private System.Windows.Forms.Button Fetcher;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addButton;
    }
}

