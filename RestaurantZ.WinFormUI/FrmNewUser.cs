using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Concrete;
using RestaurantZ.DataAccess.Concrete.EntityFramework;
using RestaurantZ.Entities.Concrete;
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
    public partial class FrmNewUser : Form
    {
        public IUserService _userService;
        public FrmNewUser()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = "abc",
                Surname = "def",
                Phone = "0000000000",
                Mail = "abc@abc.com",
                UserName = "admin",
                Password = "123456",
                IsActive = true,
                Role = "admin",
                SyncId = "abcdefgh",
                TransactionDate = DateTime.Now
               
            };
            if (_userService.Add(user))
            {
                MessageBox.Show("ok");
            }
        }
    }
}
