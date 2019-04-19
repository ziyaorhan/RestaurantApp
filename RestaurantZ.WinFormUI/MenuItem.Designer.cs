namespace RestaurantZ.WinFormUI
{
    partial class MenuItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.White;
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(35, 35);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            this.pbIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbIcon_MouseDown);
            this.pbIcon.MouseEnter += new System.EventHandler(this.pbIcon_MouseEnter);
            this.pbIcon.MouseLeave += new System.EventHandler(this.pbIcon_MouseLeave);
            this.pbIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbIcon_MouseUp);
            // 
            // lblLabel
            // 
            this.lblLabel.BackColor = System.Drawing.Color.White;
            this.lblLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLabel.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLabel.Location = new System.Drawing.Point(35, 0);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(166, 35);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblLabel_MouseDown);
            this.lblLabel.MouseEnter += new System.EventHandler(this.lblLabel_MouseEnter);
            this.lblLabel.MouseLeave += new System.EventHandler(this.lblLabel_MouseLeave);
            this.lblLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblLabel_MouseUp);
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.DarkRed;
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLine.Location = new System.Drawing.Point(0, 35);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(201, 3);
            this.lblLine.TabIndex = 2;
            // 
            // MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblLine);
            this.Name = "MenuItem";
            this.Size = new System.Drawing.Size(201, 38);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLine;
        public System.Windows.Forms.PictureBox pbIcon;
        public System.Windows.Forms.Label lblLabel;
    }
}
