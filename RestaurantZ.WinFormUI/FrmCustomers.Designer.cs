namespace RestaurantZ.WinFormUI
{
    partial class FrmCustomers
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.chkPassiveCustomer = new System.Windows.Forms.CheckBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.txtSearch = new RestaurantZ.WinFormUI.CustomTools.LetterOrDigitTextBox();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(19, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1057, 22);
            this.pnlTop.TabIndex = 12;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(1034, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 22);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(19, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 37);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "MÜŞTERİLER";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1057, 3);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 551);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 551);
            this.panel1.TabIndex = 11;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(22, 122);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(1054, 429);
            this.dgvCustomers.TabIndex = 16;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomer.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCustomer.Location = new System.Drawing.Point(775, 81);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(115, 35);
            this.btnNewCustomer.TabIndex = 18;
            this.btnNewCustomer.Text = "Yeni Müşteri";
            this.btnNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Location = new System.Drawing.Point(22, 96);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(20, 20);
            this.pbSearch.TabIndex = 19;
            this.pbSearch.TabStop = false;
            // 
            // chkPassiveCustomer
            // 
            this.chkPassiveCustomer.AutoSize = true;
            this.chkPassiveCustomer.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkPassiveCustomer.Location = new System.Drawing.Point(164, 98);
            this.chkPassiveCustomer.Name = "chkPassiveCustomer";
            this.chkPassiveCustomer.Size = new System.Drawing.Size(194, 20);
            this.chkPassiveCustomer.TabIndex = 21;
            this.chkPassiveCustomer.Text = "Sadece Pasif Müşterileri Getir";
            this.chkPassiveCustomer.UseVisualStyleBackColor = true;
            this.chkPassiveCustomer.CheckedChanged += new System.EventHandler(this.chkPassiveCustomer_CheckedChanged);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportToExcel.Location = new System.Drawing.Point(896, 81);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(180, 35);
            this.btnExportToExcel.TabIndex = 18;
            this.btnExportToExcel.Text = "Müşterileri Excel\'e Aktar";
            this.btnExportToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(48, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(110, 21);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 551);
            this.Controls.Add(this.chkPassiveCustomer);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.PictureBox pbSearch;
        private CustomTools.LetterOrDigitTextBox txtSearch;
        private System.Windows.Forms.CheckBox chkPassiveCustomer;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}