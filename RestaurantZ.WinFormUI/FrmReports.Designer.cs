namespace RestaurantZ.WinFormUI
{
    partial class FrmReports
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
            this.lblServiceName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSecond = new System.Windows.Forms.DateTimePicker();
            this.dtpFirst = new System.Windows.Forms.DateTimePicker();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.chkAllCustomers = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeatailedReport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnReportToExcel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGroupedReport = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(19, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1346, 22);
            this.pnlTop.TabIndex = 12;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(1323, 0);
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
            this.panel2.Controls.Add(this.lblServiceName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(19, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 37);
            this.panel2.TabIndex = 13;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Ubuntu", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblServiceName.ForeColor = System.Drawing.Color.White;
            this.lblServiceName.Location = new System.Drawing.Point(4, 6);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(117, 25);
            this.lblServiceName.TabIndex = 3;
            this.lblServiceName.Text = "RAPORLAR";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1346, 3);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 710);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 710);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpSecond);
            this.groupBox1.Controls.Add(this.dtpFirst);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 57);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Aralığı Belirleyin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "_";
            // 
            // dtpSecond
            // 
            this.dtpSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSecond.Location = new System.Drawing.Point(213, 22);
            this.dtpSecond.Name = "dtpSecond";
            this.dtpSecond.Size = new System.Drawing.Size(179, 21);
            this.dtpSecond.TabIndex = 0;
            // 
            // dtpFirst
            // 
            this.dtpFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpFirst.Location = new System.Drawing.Point(8, 22);
            this.dtpFirst.Name = "dtpFirst";
            this.dtpFirst.Size = new System.Drawing.Size(179, 21);
            this.dtpFirst.TabIndex = 0;
            this.dtpFirst.ValueChanged += new System.EventHandler(this.dtpFirst_ValueChanged);
            // 
            // cbCustomers
            // 
            this.cbCustomers.Enabled = false;
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(121, 21);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(271, 23);
            this.cbCustomers.TabIndex = 17;
            // 
            // chkAllCustomers
            // 
            this.chkAllCustomers.AutoSize = true;
            this.chkAllCustomers.Checked = true;
            this.chkAllCustomers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAllCustomers.Location = new System.Drawing.Point(6, 23);
            this.chkAllCustomers.Name = "chkAllCustomers";
            this.chkAllCustomers.Size = new System.Drawing.Size(109, 19);
            this.chkAllCustomers.TabIndex = 18;
            this.chkAllCustomers.Text = "Tüm Müşteriler";
            this.chkAllCustomers.UseVisualStyleBackColor = true;
            this.chkAllCustomers.CheckedChanged += new System.EventHandler(this.chkAllCustomers_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCustomers);
            this.groupBox2.Controls.Add(this.chkAllCustomers);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(432, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 57);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Seçin";
            // 
            // btnDeatailedReport
            // 
            this.btnDeatailedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeatailedReport.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeatailedReport.Location = new System.Drawing.Point(6, 17);
            this.btnDeatailedReport.Name = "btnDeatailedReport";
            this.btnDeatailedReport.Size = new System.Drawing.Size(252, 32);
            this.btnDeatailedReport.TabIndex = 18;
            this.btnDeatailedReport.Text = "AYRINTILI OLARAK LİSTELE";
            this.btnDeatailedReport.UseVisualStyleBackColor = true;
            this.btnDeatailedReport.Click += new System.EventHandler(this.btnDeatailedReport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvReport);
            this.groupBox4.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(22, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1341, 509);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rapor";
            // 
            // dgvReport
            // 
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(3, 17);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(1335, 489);
            this.dgvReport.TabIndex = 0;
            // 
            // btnReportToExcel
            // 
            this.btnReportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportToExcel.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReportToExcel.Location = new System.Drawing.Point(1220, 644);
            this.btnReportToExcel.Name = "btnReportToExcel";
            this.btnReportToExcel.Size = new System.Drawing.Size(140, 32);
            this.btnReportToExcel.TabIndex = 18;
            this.btnReportToExcel.Text = "EXCEL\'E AKTAR";
            this.btnReportToExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeatailedReport);
            this.groupBox5.Controls.Add(this.btnGroupedReport);
            this.groupBox5.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(839, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(524, 57);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Listele";
            // 
            // btnGroupedReport
            // 
            this.btnGroupedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupedReport.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGroupedReport.Location = new System.Drawing.Point(263, 17);
            this.btnGroupedReport.Name = "btnGroupedReport";
            this.btnGroupedReport.Size = new System.Drawing.Size(252, 32);
            this.btnGroupedReport.TabIndex = 18;
            this.btnGroupedReport.Text = "HESAPLANMIŞ OLARAK LİSTELE";
            this.btnGroupedReport.UseVisualStyleBackColor = true;
            this.btnGroupedReport.Click += new System.EventHandler(this.btnGroupedReport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Snow;
            this.statusStrip1.Location = new System.Drawing.Point(19, 688);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1346, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 710);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnReportToExcel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReports";
            this.Load += new System.EventHandler(this.FrmReports_Load);
            this.pnlTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAllCustomers;
        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.DateTimePicker dtpSecond;
        private System.Windows.Forms.DateTimePicker dtpFirst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeatailedReport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReportToExcel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGroupedReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}