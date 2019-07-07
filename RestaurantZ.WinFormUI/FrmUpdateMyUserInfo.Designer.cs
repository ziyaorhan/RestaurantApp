namespace RestaurantZ.WinFormUI
{
    partial class FrmUpdateMyUserInfo
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
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.txtSurname = new RestaurantZ.WinFormUI.CustomTools.LetterTextBox();
            this.txtName = new RestaurantZ.WinFormUI.CustomTools.LetterTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.gbLoginInfo = new System.Windows.Forms.GroupBox();
            this.txtUserName = new RestaurantZ.WinFormUI.CustomTools.LetterOrDigitTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSurname = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPwd1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPwd2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbUserInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.gbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSurname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPwd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPwd2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone.Location = new System.Drawing.Point(105, 75);
            this.txtPhone.Mask = "(000) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 22);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-Posta";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.txtSurname);
            this.gbUserInfo.Controls.Add(this.txtName);
            this.gbUserInfo.Controls.Add(this.txtPhone);
            this.gbUserInfo.Controls.Add(this.label4);
            this.gbUserInfo.Controls.Add(this.label5);
            this.gbUserInfo.Controls.Add(this.label6);
            this.gbUserInfo.Controls.Add(this.txtMail);
            this.gbUserInfo.Controls.Add(this.label7);
            this.gbUserInfo.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbUserInfo.Location = new System.Drawing.Point(25, 65);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(346, 140);
            this.gbUserInfo.TabIndex = 33;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "Kullanıcı Bilgileri";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(105, 48);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(220, 22);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(105, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(105, 103);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(220, 22);
            this.txtMail.TabIndex = 3;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rol";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkIsActive.Location = new System.Drawing.Point(30, 376);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(110, 21);
            this.chkIsActive.TabIndex = 36;
            this.chkIsActive.Text = "Aktif Kullanıcı";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Snow;
            this.statusStrip1.Location = new System.Drawing.Point(19, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(358, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(287, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 28);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 3);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 427);
            this.label2.TabIndex = 31;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 427);
            this.panel1.TabIndex = 27;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormName.ForeColor = System.Drawing.Color.White;
            this.lblFormName.Location = new System.Drawing.Point(6, 8);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(234, 25);
            this.lblFormName.TabIndex = 2;
            this.lblFormName.Text = "BİLGİLERİMİ GÜNCELLE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.lblFormName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(19, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 37);
            this.panel2.TabIndex = 29;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(335, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 22);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbAdmin);
            this.groupBox3.Controls.Add(this.rbManager);
            this.groupBox3.Controls.Add(this.rbEmployee);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(25, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 37);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAdmin.Location = new System.Drawing.Point(262, 12);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(64, 21);
            this.rbAdmin.TabIndex = 15;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbManager.Location = new System.Drawing.Point(182, 12);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(74, 21);
            this.rbManager.TabIndex = 14;
            this.rbManager.Text = "Yönetici";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Checked = true;
            this.rbEmployee.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEmployee.Location = new System.Drawing.Point(107, 12);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(69, 21);
            this.rbEmployee.TabIndex = 13;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Çalışan";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(19, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(358, 22);
            this.pnlTop.TabIndex = 28;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // gbLoginInfo
            // 
            this.gbLoginInfo.Controls.Add(this.txtUserName);
            this.gbLoginInfo.Controls.Add(this.label3);
            this.gbLoginInfo.Controls.Add(this.label10);
            this.gbLoginInfo.Controls.Add(this.txtPwd1);
            this.gbLoginInfo.Controls.Add(this.label11);
            this.gbLoginInfo.Controls.Add(this.txtPwd2);
            this.gbLoginInfo.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbLoginInfo.Location = new System.Drawing.Point(25, 211);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Size = new System.Drawing.Size(346, 109);
            this.gbLoginInfo.TabIndex = 37;
            this.gbLoginInfo.TabStop = false;
            this.gbLoginInfo.Text = "Giriş Bilgileri";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(105, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(220, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(11, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Parola";
            // 
            // txtPwd1
            // 
            this.txtPwd1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPwd1.Location = new System.Drawing.Point(105, 51);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.Size = new System.Drawing.Size(220, 22);
            this.txtPwd1.TabIndex = 1;
            this.txtPwd1.UseSystemPasswordChar = true;
            this.txtPwd1.TextChanged += new System.EventHandler(this.txtPwd1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(11, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Parola Tekrar";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPwd2.Location = new System.Drawing.Point(105, 76);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Size = new System.Drawing.Size(220, 22);
            this.txtPwd2.TabIndex = 2;
            this.txtPwd2.UseSystemPasswordChar = true;
            this.txtPwd2.TextChanged += new System.EventHandler(this.txtPwd2_TextChanged);
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // epSurname
            // 
            this.epSurname.ContainerControl = this;
            // 
            // epPhone
            // 
            this.epPhone.ContainerControl = this;
            // 
            // epMail
            // 
            this.epMail.ContainerControl = this;
            // 
            // epUserName
            // 
            this.epUserName.ContainerControl = this;
            // 
            // epPwd1
            // 
            this.epPwd1.ContainerControl = this;
            // 
            // epPwd2
            // 
            this.epPwd2.ContainerControl = this;
            // 
            // FrmUpdateMyUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 427);
            this.Controls.Add(this.gbLoginInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpdateMyUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUpdateMyUserInfo";
            this.Load += new System.EventHandler(this.FrmUpdateMyUserInfo_Load);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.gbLoginInfo.ResumeLayout(false);
            this.gbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSurname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPwd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPwd2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTools.LetterTextBox txtSurname;
        private CustomTools.LetterTextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.GroupBox gbLoginInfo;
        private CustomTools.LetterOrDigitTextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.ErrorProvider epSurname;
        private System.Windows.Forms.ErrorProvider epPhone;
        private System.Windows.Forms.ErrorProvider epMail;
        private System.Windows.Forms.ErrorProvider epUserName;
        private System.Windows.Forms.ErrorProvider epPwd1;
        private System.Windows.Forms.ErrorProvider epPwd2;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbEmployee;
    }
}