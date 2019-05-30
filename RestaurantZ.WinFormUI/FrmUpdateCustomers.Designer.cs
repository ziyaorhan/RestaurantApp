namespace RestaurantZ.WinFormUI
{
    partial class FrmUpdateCustomers
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkNightMale = new System.Windows.Forms.CheckBox();
            this.chkDinner = new System.Windows.Forms.CheckBox();
            this.chkLunch = new System.Windows.Forms.CheckBox();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone1Intercom = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone1 = new System.Windows.Forms.MaskedTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.epCustomerName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCustomerRep = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPhone1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBreakfast = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLunch = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDinner = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNightMale = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNightMale = new RestaurantZ.WinFormUI.CustomTools.DecimalTextBox();
            this.txtDinner = new RestaurantZ.WinFormUI.CustomTools.DecimalTextBox();
            this.txtLunch = new RestaurantZ.WinFormUI.CustomTools.DecimalTextBox();
            this.txtBreakfast = new RestaurantZ.WinFormUI.CustomTools.DecimalTextBox();
            this.txtCustomerRep = new RestaurantZ.WinFormUI.CustomTools.LetterTextBox();
            this.txtCustomerName = new RestaurantZ.WinFormUI.CustomTools.LetterOrDigitTextBox();
            this.txtMail = new RestaurantZ.WinFormUI.PlaceHolderTextBox();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomerRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBreakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNightMale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(19, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(583, 22);
            this.panel4.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(560, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 22);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 498);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 3);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.lblFormName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(19, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 31);
            this.panel2.TabIndex = 15;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.BackColor = System.Drawing.Color.Transparent;
            this.lblFormName.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormName.ForeColor = System.Drawing.Color.White;
            this.lblFormName.Location = new System.Drawing.Point(3, 3);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(201, 25);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "MÜŞTERİ GÜNCELLE";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 498);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkIsActive.Location = new System.Drawing.Point(24, 440);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(110, 21);
            this.chkIsActive.TabIndex = 26;
            this.chkIsActive.Text = "Aktif Kullanıcı";
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.Click += new System.EventHandler(this.chkIsActive_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(504, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 33);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNotes);
            this.groupBox3.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(379, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 375);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.Snow;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 19);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(212, 353);
            this.txtNotes.TabIndex = 0;
            this.txtNotes.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNightMale);
            this.groupBox2.Controls.Add(this.txtDinner);
            this.groupBox2.Controls.Add(this.txtLunch);
            this.groupBox2.Controls.Add(this.txtBreakfast);
            this.groupBox2.Controls.Add(this.chkNightMale);
            this.groupBox2.Controls.Add(this.chkDinner);
            this.groupBox2.Controls.Add(this.chkLunch);
            this.groupBox2.Controls.Add(this.chkBreakfast);
            this.groupBox2.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(22, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 139);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşterinin Aldığı Hizmetler";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(298, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(298, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(298, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(298, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "TL";
            // 
            // chkNightMale
            // 
            this.chkNightMale.AutoSize = true;
            this.chkNightMale.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkNightMale.Location = new System.Drawing.Point(14, 106);
            this.chkNightMale.Name = "chkNightMale";
            this.chkNightMale.Size = new System.Drawing.Size(106, 21);
            this.chkNightMale.TabIndex = 6;
            this.chkNightMale.Text = "Gece Yemeği";
            this.chkNightMale.UseVisualStyleBackColor = true;
            this.chkNightMale.CheckedChanged += new System.EventHandler(this.chkNightMale_CheckedChanged);
            this.chkNightMale.Click += new System.EventHandler(this.chkNightMale_Click);
            // 
            // chkDinner
            // 
            this.chkDinner.AutoSize = true;
            this.chkDinner.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDinner.Location = new System.Drawing.Point(14, 83);
            this.chkDinner.Name = "chkDinner";
            this.chkDinner.Size = new System.Drawing.Size(114, 21);
            this.chkDinner.TabIndex = 4;
            this.chkDinner.Text = "Akşam Yemeği";
            this.chkDinner.UseVisualStyleBackColor = true;
            this.chkDinner.CheckedChanged += new System.EventHandler(this.chkDinner_CheckedChanged);
            this.chkDinner.Click += new System.EventHandler(this.chkDinner_Click);
            // 
            // chkLunch
            // 
            this.chkLunch.AutoSize = true;
            this.chkLunch.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkLunch.Location = new System.Drawing.Point(14, 55);
            this.chkLunch.Name = "chkLunch";
            this.chkLunch.Size = new System.Drawing.Size(111, 21);
            this.chkLunch.TabIndex = 2;
            this.chkLunch.Text = "Öğlen Yemeği";
            this.chkLunch.UseVisualStyleBackColor = true;
            this.chkLunch.CheckedChanged += new System.EventHandler(this.chkLunch_CheckedChanged);
            this.chkLunch.Click += new System.EventHandler(this.chkLunch_Click);
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBreakfast.Location = new System.Drawing.Point(14, 27);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(77, 21);
            this.chkBreakfast.TabIndex = 0;
            this.chkBreakfast.Text = "Kahvaltı";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            this.chkBreakfast.CheckedChanged += new System.EventHandler(this.chkBreakfast_CheckedChanged);
            this.chkBreakfast.Click += new System.EventHandler(this.chkBreakfast_Click);
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Controls.Add(this.txtCustomerRep);
            this.gbCustomerInfo.Controls.Add(this.txtCustomerName);
            this.gbCustomerInfo.Controls.Add(this.txtMail);
            this.gbCustomerInfo.Controls.Add(this.txtPhone2);
            this.gbCustomerInfo.Controls.Add(this.txtPhone1Intercom);
            this.gbCustomerInfo.Controls.Add(this.txtPhone1);
            this.gbCustomerInfo.Controls.Add(this.txtAddress);
            this.gbCustomerInfo.Controls.Add(this.label4);
            this.gbCustomerInfo.Controls.Add(this.label5);
            this.gbCustomerInfo.Controls.Add(this.label12);
            this.gbCustomerInfo.Controls.Add(this.label6);
            this.gbCustomerInfo.Controls.Add(this.label8);
            this.gbCustomerInfo.Controls.Add(this.label13);
            this.gbCustomerInfo.Controls.Add(this.label7);
            this.gbCustomerInfo.Font = new System.Drawing.Font("Ubuntu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbCustomerInfo.Location = new System.Drawing.Point(22, 59);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(351, 236);
            this.gbCustomerInfo.TabIndex = 23;
            this.gbCustomerInfo.TabStop = false;
            this.gbCustomerInfo.Text = "Müşteri Bilgileri";
            // 
            // txtPhone2
            // 
            this.txtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone2.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone2.Location = new System.Drawing.Point(159, 128);
            this.txtPhone2.Mask = "(000) 000-0000";
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(161, 22);
            this.txtPhone2.TabIndex = 4;
            // 
            // txtPhone1Intercom
            // 
            this.txtPhone1Intercom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone1Intercom.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone1Intercom.Location = new System.Drawing.Point(159, 102);
            this.txtPhone1Intercom.Mask = "00000";
            this.txtPhone1Intercom.Name = "txtPhone1Intercom";
            this.txtPhone1Intercom.Size = new System.Drawing.Size(161, 22);
            this.txtPhone1Intercom.TabIndex = 3;
            // 
            // txtPhone1
            // 
            this.txtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone1.Location = new System.Drawing.Point(159, 76);
            this.txtPhone1.Mask = "(000) 000-0000";
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(161, 22);
            this.txtPhone1.TabIndex = 2;
            this.txtPhone1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPhone1_MaskInputRejected);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddress.Location = new System.Drawing.Point(159, 180);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(161, 46);
            this.txtAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Firma Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Firma Temsilcisi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(11, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Dahili No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon-1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Adres";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(11, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefon-2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Snow;
            this.statusStrip1.Location = new System.Drawing.Point(19, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(583, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // epCustomerName
            // 
            this.epCustomerName.ContainerControl = this;
            // 
            // epCustomerRep
            // 
            this.epCustomerRep.ContainerControl = this;
            // 
            // epPhone1
            // 
            this.epPhone1.ContainerControl = this;
            // 
            // epMail
            // 
            this.epMail.ContainerControl = this;
            // 
            // epBreakfast
            // 
            this.epBreakfast.ContainerControl = this;
            // 
            // epLunch
            // 
            this.epLunch.ContainerControl = this;
            // 
            // epDinner
            // 
            this.epDinner.ContainerControl = this;
            // 
            // epNightMale
            // 
            this.epNightMale.ContainerControl = this;
            // 
            // txtNightMale
            // 
            this.txtNightMale.Location = new System.Drawing.Point(159, 109);
            this.txtNightMale.Name = "txtNightMale";
            this.txtNightMale.Size = new System.Drawing.Size(138, 23);
            this.txtNightMale.TabIndex = 7;
            this.txtNightMale.Text = "0.00";
            // 
            // txtDinner
            // 
            this.txtDinner.Location = new System.Drawing.Point(159, 81);
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.Size = new System.Drawing.Size(138, 23);
            this.txtDinner.TabIndex = 5;
            this.txtDinner.Text = "0.00";
            // 
            // txtLunch
            // 
            this.txtLunch.Location = new System.Drawing.Point(159, 53);
            this.txtLunch.Name = "txtLunch";
            this.txtLunch.Size = new System.Drawing.Size(138, 23);
            this.txtLunch.TabIndex = 3;
            this.txtLunch.Text = "0.00";
            // 
            // txtBreakfast
            // 
            this.txtBreakfast.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBreakfast.Location = new System.Drawing.Point(159, 25);
            this.txtBreakfast.Name = "txtBreakfast";
            this.txtBreakfast.Size = new System.Drawing.Size(138, 23);
            this.txtBreakfast.TabIndex = 1;
            this.txtBreakfast.Text = "0.00";
            // 
            // txtCustomerRep
            // 
            this.txtCustomerRep.Location = new System.Drawing.Point(159, 49);
            this.txtCustomerRep.Name = "txtCustomerRep";
            this.txtCustomerRep.Size = new System.Drawing.Size(161, 23);
            this.txtCustomerRep.TabIndex = 1;
            this.txtCustomerRep.TextChanged += new System.EventHandler(this.txtCustomerRep_TextChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(159, 22);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(161, 23);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.ForeColor = System.Drawing.Color.Gray;
            this.txtMail.Location = new System.Drawing.Point(159, 154);
            this.txtMail.Name = "txtMail";
            this.txtMail.PlaceHolderText = "abc@abc.com";
            this.txtMail.Size = new System.Drawing.Size(161, 22);
            this.txtMail.TabIndex = 5;
            this.txtMail.Text = "abc@abc.com";
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // FrmUpdateCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(602, 498);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdateCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmUpdateCustomers";
            this.Load += new System.EventHandler(this.FrmUpdateCustomers_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomerRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBreakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNightMale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private CustomTools.DecimalTextBox txtNightMale;
        private CustomTools.DecimalTextBox txtDinner;
        private CustomTools.DecimalTextBox txtLunch;
        private CustomTools.DecimalTextBox txtBreakfast;
        private System.Windows.Forms.CheckBox chkNightMale;
        private System.Windows.Forms.CheckBox chkDinner;
        private System.Windows.Forms.CheckBox chkLunch;
        private System.Windows.Forms.CheckBox chkBreakfast;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private CustomTools.LetterTextBox txtCustomerRep;
        private CustomTools.LetterOrDigitTextBox txtCustomerName;
        private System.Windows.Forms.MaskedTextBox txtPhone2;
        private System.Windows.Forms.MaskedTextBox txtPhone1Intercom;
        private System.Windows.Forms.MaskedTextBox txtPhone1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ErrorProvider epCustomerName;
        private System.Windows.Forms.ErrorProvider epCustomerRep;
        private System.Windows.Forms.ErrorProvider epPhone1;
        private System.Windows.Forms.ErrorProvider epMail;
        private System.Windows.Forms.ErrorProvider epBreakfast;
        private System.Windows.Forms.ErrorProvider epLunch;
        private System.Windows.Forms.ErrorProvider epDinner;
        private System.Windows.Forms.ErrorProvider epNightMale;
        private PlaceHolderTextBox txtMail;
    }
}