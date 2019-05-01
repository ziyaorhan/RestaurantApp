
using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Concrete;
using RestaurantZ.Business.DependencyResolvers.Ninject;
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
        public List<MessagesAndProperties> allExceptions;// User managerden fluent validation vasıtası ile gelen hataları property isimlerine göre tutar.
        public FrmNewUser()
        {
            InitializeComponent();
            //_userService = new UserManager(new EfUserDal());//IoC Container kullanmadan önce böyle idi.
            _userService = InstanceFactory.GetInstance<IUserService>();
            allExceptions = new List<MessagesAndProperties>();
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
                Name =txtName.Text.Trim(),
                Surname =txtSurname.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Mail = txtMail.Text.Trim(),
                UserName =txtUserName.Text.Trim(),
                Password = txtPwd1.Text.Trim(),
                IsActive = true,
                Role = rbEmployee.Checked ? "Employee" : "Manager",
                SyncId = Guid.NewGuid().ToString(),
                TransactionDate = DateTime.Now
            };
            try
            {
                _userService.Add(user);
                this.Close();
            }
            catch (CustomExceptionForValidation ex)
            {
                allExceptions = ex.ExceptionDetails;//hataları listeye at.
                RunErrorProviders();
            }
        }

        private void RunErrorProviders()
        {
            if (Global.IsThereAExceptionByProperty(allExceptions, "Name"))
            {
                epName.SetError(txtName, Global.GetExceptionsByProperty(allExceptions, "Name"));
            }
            else
            {
                epName.Clear();
            }
            //
            if (Global.IsThereAExceptionByProperty(allExceptions, "Surname"))
            {
                epSurname.SetError(txtSurname, Global.GetExceptionsByProperty(allExceptions, "Surname"));
            }
            else
            {
                epSurname.Clear();
            }
            //
            if (Global.IsThereAExceptionByProperty(allExceptions, "Phone"))
            {
                epPhone.SetError(txtPhone, Global.GetExceptionsByProperty(allExceptions, "Phone"));
            }
            else
            {
                epPhone.Clear();
            }
            //
            if (Global.IsThereAExceptionByProperty(allExceptions, "Mail"))
            {
                epMail.SetError(txtMail, Global.GetExceptionsByProperty(allExceptions, "Mail"));
            }
            else
            {
                epMail.Clear();
            }
            //
            if (Global.IsThereAExceptionByProperty(allExceptions, "UserName"))
            {
                epUserName.SetError(txtUserName, Global.GetExceptionsByProperty(allExceptions, "UserName"));
            }
            else
            {
                epUserName.Clear();
            }
            //
            if (Global.IsThereAExceptionByProperty(allExceptions, "Password"))
            {
                epPwd1.SetError(txtPwd1, Global.GetExceptionsByProperty(allExceptions, "Password"));
            }
            else
            {
                epPwd1.Clear();
            }

            if (txtPwd2.Text!=txtPwd1.Text)
            {
                epPwd2.SetError(txtPwd2, "-'Parola' ve 'Parola Tekrar' aynı olmalıdır.");
            }
            else
            {
                epPwd2.Clear();
            }
        }
    }
}
