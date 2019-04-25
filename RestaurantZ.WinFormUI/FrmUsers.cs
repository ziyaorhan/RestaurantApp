using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Concrete;
using RestaurantZ.DataAccess.Concrete.EntityFramework;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }
        public IUserService _userService;
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmNewUser frmNewUser = new FrmNewUser();
            frmNewUser.ShowDialog();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            btnNewUser.Image = Image.FromFile(Global.GetPath("\\Images\\add.png"));
            //dgvUsers.DataSource = _userService.;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
