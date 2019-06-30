using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
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
            try
            {
                _userService = InstanceFactory.GetInstance<IUserService>();
            }
            catch 
            {
                MessageBox.Show("Form açılırken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
            }
            allExceptions = new List<MessagesAndProperties>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            allExceptions.Clear();
            try
            {
                User user = new User
                {
                    Name = txtName.Text.Trim(),
                    Surname = txtSurname.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Mail = txtMail.Text.Trim(),
                    UserName = txtUserName.Text.Trim(),
                    Password = CryptTool.EncryptSha(CryptTool.EncryptMd5(txtPwd1.Text.Trim())),
                    IsActive = chkIsActive.Checked,
                    Role = rbEmployee.Checked ?
                    Variables.UserType.Employee.ToString() :
                    (rbManager.Checked ? 
                    Variables.UserType.Manager.ToString() :
                    Variables.UserType.Admin.ToString())
                };
                if (PasswordsAreSame())
                {
                    _userService.Add(user);
                    FrmUsers refreshedFrm = (FrmUsers)Application.OpenForms["FrmUsers"];
                    refreshedFrm.DgvUsersFill();
                    Cursor.Current = Cursors.Default;
                    this.Close();
                }
            }
            catch (CustomExceptionForValidation ex)
            {
                Cursor.Current = Cursors.Default;
                allExceptions = ex.ExceptionDetails;//hataları listeye at.
                RunErrorProviders();
                PasswordsAreSame();
            }
            catch
            {
                MessageBox.Show("Yeni kullanıcı eklerken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
            }
        }

        private void RunErrorProviders()
        {
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "Name"))
            {
                epName.SetError(txtName, ValidationTool.GetExceptionsByProperty(allExceptions, "Name"));
            }
            else
            {
                epName.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "Surname"))
            {
                epSurname.SetError(txtSurname, ValidationTool.GetExceptionsByProperty(allExceptions, "Surname"));
            }
            else
            {
                epSurname.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "Phone"))
            {
                epPhone.SetError(txtPhone, ValidationTool.GetExceptionsByProperty(allExceptions, "Phone"));
            }
            else
            {
                epPhone.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "Mail"))
            {
                epMail.SetError(txtMail, ValidationTool.GetExceptionsByProperty(allExceptions, "Mail"));
            }
            else
            {
                epMail.Clear();
            }
            //
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "UserName"))
            {
                epUserName.SetError(txtUserName, ValidationTool.GetExceptionsByProperty(allExceptions, "UserName"));
            }
            else
            {
                epUserName.Clear();
            }
            if (ValidationTool.IsThereAExceptionByProperty(allExceptions, "Password"))
            {
                epPwd1.SetError(txtPwd1, ValidationTool.GetExceptionsByProperty(allExceptions, "Password"));
            }
            else
            {
                epPwd1.Clear();
            }
        }

        public bool PasswordsAreSame()
        {
            if (txtPwd2.Text != txtPwd1.Text)
            {
                epPwd2.SetError(txtPwd2, "-'Parola' ve 'Parola Tekrar' aynı olmalıdır.");
                return false;
            }
            else
            {
                return true;
            }
        }

        #region TextChanced Events For ErrorProvider Clear
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            epName.Clear();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            epSurname.Clear();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            epPhone.Clear();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            epMail.Clear();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            epUserName.Clear();
        }

        private void txtPwd1_TextChanged(object sender, EventArgs e)
        {
            epPwd1.Clear();
        }

        private void txtPwd2_TextChanged(object sender, EventArgs e)
        {
            if (txtPwd2.Text == txtPwd1.Text)
            {
                epPwd2.Clear();
            }
        }
        #endregion

        private void rbManager_Click(object sender, EventArgs e)
        {
            if (rbManager.Checked)
            {
                MessageBox.Show("Bir yönetici,\r\n-Günlük kayıt tutabilir,\r\n-Geçmiş kayıtlarda işlem yapabilir,\r\n-Rapor alabilir,\r\n-Müşteriler üzerinde işlem yapabilir.\r\n\r\nBunu yapmak istediğinizden emin misiniz?", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbAdmin_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                MessageBox.Show("Admin yetkisi en kapsamlı yetkidir.Bir admin,\r\n-Günlük kayıt tutabilir,\r\n-Geçmiş kayıtlarda işlem yapabilir,\r\n-Rapor alabilir,\r\n-Müşteriler üzerinde işlem yapabilir,\r\n-Kullanıcılar üzerinde işlem yapabilir.\r\n\r\nBunu yapmak istediğinizden emin misiniz?", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
