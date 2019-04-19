using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class MenuItem : UserControl
    {
        public MenuItem()
        {
            InitializeComponent();        
        }
        private void pbIcon_MouseEnter(object sender, EventArgs e)
        {
            this.pbIcon.BackColor = Color.Tomato;
            this.lblLabel.BackColor = Color.Tomato;
            this.lblLabel.ForeColor = Color.White;
            this.lblLine.BackColor = Color.White;
        }

        private void pbIcon_MouseLeave(object sender, EventArgs e)
        {
            this.pbIcon.BackColor = Color.White;
            this.lblLabel.BackColor = Color.White;
            this.lblLabel.ForeColor = Color.DarkRed;
            this.lblLine.BackColor = Color.DarkRed;
        }

        private void lblLabel_MouseEnter(object sender, EventArgs e)
        {
            this.pbIcon.BackColor = Color.Tomato;
            this.lblLabel.BackColor = Color.Tomato;
            this.lblLabel.ForeColor = Color.White;
            this.lblLine.BackColor = Color.White;
        }

        private void lblLabel_MouseLeave(object sender, EventArgs e)
        {
            this.pbIcon.BackColor = Color.White;
            this.lblLabel.BackColor = Color.White;
            this.lblLabel.ForeColor = Color.DarkRed;
            this.lblLine.BackColor = Color.DarkRed;
        }

   

        private void pbIcon_MouseDown(object sender, MouseEventArgs e)
        {
            this.pbIcon.BackColor = Color.DarkRed;
            this.lblLabel.BackColor = Color.DarkRed;
            this.lblLabel.ForeColor = Color.White;
            this.lblLine.BackColor = Color.White;
        }

        private void pbIcon_MouseUp(object sender, MouseEventArgs e)
        {
            this.pbIcon.BackColor = Color.Tomato;
            this.lblLabel.BackColor = Color.Tomato;
            this.lblLabel.ForeColor = Color.White;
            this.lblLine.BackColor = Color.White;
        }

        private void lblLabel_MouseDown(object sender, MouseEventArgs e)
        {
            this.pbIcon.BackColor = Color.DarkRed;
            this.lblLabel.BackColor = Color.DarkRed;
            this.lblLabel.ForeColor = Color.White;
            this.lblLine.BackColor = Color.White;
        }

        private void lblLabel_MouseUp(object sender, MouseEventArgs e)
        {
            this.pbIcon.BackColor = Color.Tomato;
            this.lblLabel.BackColor = Color.Tomato;
            this.lblLabel.ForeColor = Color.White;
            this.lblLine.BackColor = Color.White;
        }
    }
}
