using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Concrete;
using RestaurantZ.Business.ValidationRules;
using RestaurantZ.DataAccess.Concrete.EntityFramework;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmNewUser : Form
    {
        public IUserService _userService;// Business katmanı
        public List<MyExceptionModel> allExceptions;// User managerden fluent validation vasıtası ile gelen hataları property isimlerine göre tutar.
        public FrmNewUser()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
            allExceptions = new List<MyExceptionModel>(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            allExceptions.Clear();
            User user = new User
            {
                Name = txtName.Text.Trim(),
                Surname = txtSurname.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Mail = txtMail.Text.Trim(),
                UserName = txtUserName.Text.Trim(),
                Password = txtPwd1.Text.Trim(),
                IsActive = true,
                Role = rbEmployee.Checked ? "Employee" : "Manager",
                SyncId = Guid.NewGuid().ToString(),
                TransactionDate = DateTime.Now
            };
            try
            {
                _userService.Add(user);
            }
            catch (MyException ex)
            {
                allExceptions = ex.MyExceptions;//hataları listeye at.
                RunErrorProviders();
            }
        }

        private void RunErrorProviders()
        {
            if (Global.IsThereAExceptionByProperty(allExceptions, "Password"))
            {
                epTxtPwd.SetError(txtPwd1, Global.GetExceptionsByProperty(allExceptions, "Password"));
            }
            else
            {
                epTxtPwd.Clear();
            }
        }

        private void txtPwd1_Validating(object sender, CancelEventArgs e)
        {
            
           // string errorText = epTxtPwd.GetError(txtPwd1);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPwd1.UseSystemPasswordChar = false;
        }
    }
}
