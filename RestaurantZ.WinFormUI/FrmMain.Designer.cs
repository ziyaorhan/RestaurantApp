namespace RestaurantZ.WinFormUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tsBtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsBtnMax = new System.Windows.Forms.ToolStripButton();
            this.tsBtnMin = new System.Windows.Forms.ToolStripButton();
            this.tsBtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tsBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSessionOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblSessionName = new System.Windows.Forms.ToolStripSplitButton();
            this.bilgilerimiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsLblSync = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblSettings = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblReports = new System.Windows.Forms.ToolStripSplitButton();
            this.günlükRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapsamlıRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişKayıtlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLblDate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsBtnClear = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNightMale = new System.Windows.Forms.Button();
            this.btnDinner = new System.Windows.Forms.Button();
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnBreakfast = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tsTop.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tsTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(205, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(821, 32);
            this.panel2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(3, 32);
            this.label8.TabIndex = 13;
            // 
            // tsTop
            // 
            this.tsTop.BackColor = System.Drawing.Color.White;
            this.tsTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsTop.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnClose,
            this.tsBtnMax,
            this.tsBtnMin,
            this.tsBtnInfo,
            this.tsBtnHelp,
            this.toolStripSeparator4,
            this.tsBtnSessionOut,
            this.toolStripSeparator5,
            this.tsLblSessionName});
            this.tsTop.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsTop.Location = new System.Drawing.Point(0, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(821, 32);
            this.tsTop.TabIndex = 0;
            this.tsTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tsTop_MouseDown);
            // 
            // tsBtnClose
            // 
            this.tsBtnClose.AutoSize = false;
            this.tsBtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnClose.Image")));
            this.tsBtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnClose.Name = "tsBtnClose";
            this.tsBtnClose.Size = new System.Drawing.Size(29, 29);
            this.tsBtnClose.Text = "Çıkış";
            this.tsBtnClose.Click += new System.EventHandler(this.tsBtnClose_Click);
            // 
            // tsBtnMax
            // 
            this.tsBtnMax.AutoSize = false;
            this.tsBtnMax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnMax.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMax.Image")));
            this.tsBtnMax.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMax.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnMax.Name = "tsBtnMax";
            this.tsBtnMax.Size = new System.Drawing.Size(29, 29);
            this.tsBtnMax.Text = "Maksimum Boyut";
            this.tsBtnMax.Click += new System.EventHandler(this.tsBtnMax_Click);
            // 
            // tsBtnMin
            // 
            this.tsBtnMin.AutoSize = false;
            this.tsBtnMin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnMin.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMin.Image")));
            this.tsBtnMin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnMin.Name = "tsBtnMin";
            this.tsBtnMin.Size = new System.Drawing.Size(29, 29);
            this.tsBtnMin.Text = "Simge Durumuna";
            this.tsBtnMin.Click += new System.EventHandler(this.tsBtnMin_Click);
            // 
            // tsBtnInfo
            // 
            this.tsBtnInfo.AutoSize = false;
            this.tsBtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnInfo.Image")));
            this.tsBtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnInfo.Name = "tsBtnInfo";
            this.tsBtnInfo.Size = new System.Drawing.Size(29, 29);
            this.tsBtnInfo.Text = "Program Hakkında";
            this.tsBtnInfo.Click += new System.EventHandler(this.tsBtnInfo_Click);
            // 
            // tsBtnHelp
            // 
            this.tsBtnHelp.AutoSize = false;
            this.tsBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnHelp.Image")));
            this.tsBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnHelp.Name = "tsBtnHelp";
            this.tsBtnHelp.Size = new System.Drawing.Size(29, 29);
            this.tsBtnHelp.Text = "Yardım";
            this.tsBtnHelp.Click += new System.EventHandler(this.tsBtnHelp_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // tsBtnSessionOut
            // 
            this.tsBtnSessionOut.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSessionOut.Image")));
            this.tsBtnSessionOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSessionOut.Name = "tsBtnSessionOut";
            this.tsBtnSessionOut.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsBtnSessionOut.Size = new System.Drawing.Size(126, 29);
            this.tsBtnSessionOut.Text = "Oturumu Kapat";
            this.tsBtnSessionOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsBtnSessionOut.Click += new System.EventHandler(this.tsBtnSessionOut_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // tsLblSessionName
            // 
            this.tsLblSessionName.DropDownButtonWidth = 24;
            this.tsLblSessionName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgilerimiGuncelleToolStripMenuItem});
            this.tsLblSessionName.Name = "tsLblSessionName";
            this.tsLblSessionName.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsLblSessionName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsLblSessionName.Size = new System.Drawing.Size(151, 29);
            this.tsLblSessionName.Text = "Hoşgeldin Abdullah";
            // 
            // bilgilerimiGuncelleToolStripMenuItem
            // 
            this.bilgilerimiGuncelleToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bilgilerimiGuncelleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bilgilerimiGuncelleToolStripMenuItem.Name = "bilgilerimiGuncelleToolStripMenuItem";
            this.bilgilerimiGuncelleToolStripMenuItem.ShowShortcutKeys = false;
            this.bilgilerimiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.bilgilerimiGuncelleToolStripMenuItem.Text = "Bilgilerimi Güncelle";
            this.bilgilerimiGuncelleToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tomato;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(205, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(821, 42);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tsMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 24);
            this.panel3.TabIndex = 13;
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.White;
            this.tsMain.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblSync,
            this.toolStripSeparator1,
            this.tsLblSettings,
            this.toolStripSeparator2,
            this.tsLblReports,
            this.tsLblDate,
            this.toolStripSeparator6,
            this.tsLblSearch,
            this.tsTxtSearch,
            this.tsBtnClear});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(818, 25);
            this.tsMain.TabIndex = 0;
            // 
            // tsLblSync
            // 
            this.tsLblSync.BackColor = System.Drawing.Color.White;
            this.tsLblSync.Image = ((System.Drawing.Image)(resources.GetObject("tsLblSync.Image")));
            this.tsLblSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsLblSync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLblSync.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.tsLblSync.Name = "tsLblSync";
            this.tsLblSync.Size = new System.Drawing.Size(109, 22);
            this.tsLblSync.Text = "Senkronizasyon";
            this.tsLblSync.Click += new System.EventHandler(this.tsLblSync_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLblSettings
            // 
            this.tsLblSettings.DropDownButtonWidth = 24;
            this.tsLblSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsers,
            this.tsmiCustomers});
            this.tsLblSettings.Name = "tsLblSettings";
            this.tsLblSettings.Size = new System.Drawing.Size(74, 22);
            this.tsLblSettings.Text = "Ayarlar";
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(140, 22);
            this.tsmiUsers.Text = "Kullanıcılar";
            this.tsmiUsers.Click += new System.EventHandler(this.tsmiUsers_Click);
            // 
            // tsmiCustomers
            // 
            this.tsmiCustomers.Name = "tsmiCustomers";
            this.tsmiCustomers.Size = new System.Drawing.Size(140, 22);
            this.tsmiCustomers.Text = "Müşteriler";
            this.tsmiCustomers.Click += new System.EventHandler(this.tsmiCustomers_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLblReports
            // 
            this.tsLblReports.DropDownButtonWidth = 24;
            this.tsLblReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükRaporToolStripMenuItem,
            this.aylıkRaporToolStripMenuItem,
            this.kapsamlıRaporToolStripMenuItem,
            this.geçmişKayıtlarToolStripMenuItem});
            this.tsLblReports.Name = "tsLblReports";
            this.tsLblReports.Size = new System.Drawing.Size(84, 22);
            this.tsLblReports.Text = "Raporlar";
            // 
            // günlükRaporToolStripMenuItem
            // 
            this.günlükRaporToolStripMenuItem.Name = "günlükRaporToolStripMenuItem";
            this.günlükRaporToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.günlükRaporToolStripMenuItem.Text = "Günlük Rapor";
            // 
            // aylıkRaporToolStripMenuItem
            // 
            this.aylıkRaporToolStripMenuItem.Name = "aylıkRaporToolStripMenuItem";
            this.aylıkRaporToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aylıkRaporToolStripMenuItem.Text = "Aylık Rapor";
            // 
            // kapsamlıRaporToolStripMenuItem
            // 
            this.kapsamlıRaporToolStripMenuItem.Name = "kapsamlıRaporToolStripMenuItem";
            this.kapsamlıRaporToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.kapsamlıRaporToolStripMenuItem.Text = "Kapsamlı Rapor";
            // 
            // geçmişKayıtlarToolStripMenuItem
            // 
            this.geçmişKayıtlarToolStripMenuItem.Name = "geçmişKayıtlarToolStripMenuItem";
            this.geçmişKayıtlarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.geçmişKayıtlarToolStripMenuItem.Text = "Geçmiş Kayıtlar";
            // 
            // tsLblDate
            // 
            this.tsLblDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblDate.Name = "tsLblDate";
            this.tsLblDate.Size = new System.Drawing.Size(129, 22);
            this.tsLblDate.Text = "16.04.2019 Perşembe";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLblSearch
            // 
            this.tsLblSearch.Name = "tsLblSearch";
            this.tsLblSearch.Size = new System.Drawing.Size(0, 22);
            // 
            // tsTxtSearch
            // 
            this.tsTxtSearch.AutoToolTip = true;
            this.tsTxtSearch.BackColor = System.Drawing.Color.White;
            this.tsTxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTxtSearch.Name = "tsTxtSearch";
            this.tsTxtSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // tsBtnClear
            // 
            this.tsBtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnClear.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnClear.Image")));
            this.tsBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnClear.Name = "tsBtnClear";
            this.tsBtnClear.Size = new System.Drawing.Size(23, 22);
            this.tsBtnClear.Text = "Temizle";
            this.tsBtnClear.Click += new System.EventHandler(this.tsBtnClear_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(3, 42);
            this.label7.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(205, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(821, 3);
            this.label3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(205, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(3, 485);
            this.label5.TabIndex = 11;
            // 
            // dgvMain
            // 
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(208, 77);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 16;
            this.dgvMain.ShowEditingIcon = false;
            this.dgvMain.Size = new System.Drawing.Size(806, 485);
            this.dgvMain.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(3, 709);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 3);
            this.label6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(0, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 3);
            this.label2.TabIndex = 9;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(77, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(50, 50);
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kevser Kebap";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.btnNightMale);
            this.panel1.Controls.Add(this.btnDinner);
            this.panel1.Controls.Add(this.btnLunch);
            this.panel1.Controls.Add(this.btnBreakfast);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 562);
            this.panel1.TabIndex = 5;
            // 
            // btnNightMale
            // 
            this.btnNightMale.BackColor = System.Drawing.Color.Tomato;
            this.btnNightMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNightMale.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNightMale.ForeColor = System.Drawing.Color.White;
            this.btnNightMale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNightMale.Location = new System.Drawing.Point(0, 387);
            this.btnNightMale.Name = "btnNightMale";
            this.btnNightMale.Size = new System.Drawing.Size(205, 56);
            this.btnNightMale.TabIndex = 0;
            this.btnNightMale.Text = "GECE Y.";
            this.btnNightMale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNightMale.UseVisualStyleBackColor = false;
            this.btnNightMale.Click += new System.EventHandler(this.btnBreakfast_Click);
            // 
            // btnDinner
            // 
            this.btnDinner.BackColor = System.Drawing.Color.Tomato;
            this.btnDinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinner.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDinner.ForeColor = System.Drawing.Color.White;
            this.btnDinner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinner.Location = new System.Drawing.Point(0, 304);
            this.btnDinner.Name = "btnDinner";
            this.btnDinner.Size = new System.Drawing.Size(205, 56);
            this.btnDinner.TabIndex = 0;
            this.btnDinner.Text = "AKŞAM Y.";
            this.btnDinner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDinner.UseVisualStyleBackColor = false;
            this.btnDinner.Click += new System.EventHandler(this.btnDinner_Click);
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.Tomato;
            this.btnLunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLunch.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLunch.ForeColor = System.Drawing.Color.White;
            this.btnLunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLunch.Location = new System.Drawing.Point(0, 226);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(205, 56);
            this.btnLunch.TabIndex = 0;
            this.btnLunch.Text = "ÖĞLEN Y.";
            this.btnLunch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.btnLunch_Click);
            // 
            // btnBreakfast
            // 
            this.btnBreakfast.BackColor = System.Drawing.Color.Tomato;
            this.btnBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreakfast.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBreakfast.ForeColor = System.Drawing.Color.White;
            this.btnBreakfast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBreakfast.Location = new System.Drawing.Point(0, 149);
            this.btnBreakfast.Name = "btnBreakfast";
            this.btnBreakfast.Size = new System.Drawing.Size(205, 56);
            this.btnBreakfast.TabIndex = 0;
            this.btnBreakfast.Text = "KAHVALTI";
            this.btnBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBreakfast.UseVisualStyleBackColor = false;
            this.btnBreakfast.Click += new System.EventHandler(this.btnBreakfast_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 562);
            this.ControlBox = false;
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsBtnClose;
        private System.Windows.Forms.ToolStripButton tsBtnMax;
        private System.Windows.Forms.ToolStripButton tsBtnMin;
        private System.Windows.Forms.ToolStripButton tsBtnInfo;
        private System.Windows.Forms.ToolStripButton tsBtnHelp;
        private System.Windows.Forms.ToolStripButton tsBtnSessionOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSplitButton tsLblSessionName;
        private System.Windows.Forms.ToolStripMenuItem bilgilerimiGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton tsLblSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton tsLblReports;
        private System.Windows.Forms.ToolStripMenuItem günlükRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapsamlıRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel tsLblDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel tsLblSearch;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearch;
        private System.Windows.Forms.ToolStripButton tsBtnClear;
        private System.Windows.Forms.ToolStripLabel tsLblSync;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBreakfast;
        private System.Windows.Forms.ToolStripMenuItem geçmişKayıtlarToolStripMenuItem;
        private System.Windows.Forms.Button btnNightMale;
        private System.Windows.Forms.Button btnDinner;
        private System.Windows.Forms.Button btnLunch;
    }
}