using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            btnNewCustomer.Image = Image.FromFile(Global.GetPath("\\Images\\add.png"));
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FrmNewCustomer frmNewCustomer = new FrmNewCustomer();
            frmNewCustomer.ShowDialog();
        }
    }
}
