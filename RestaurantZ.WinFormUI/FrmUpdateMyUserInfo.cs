using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules;
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
    public partial class FrmUpdateMyUserInfo : Form
    {
        private IUserService _userService;

        public List<MessagesAndProperties> allExceptions;

        public FrmUpdateMyUserInfo()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void FrmUpdateMyUserInfo_Load(object sender, EventArgs e)
        {
            var currentUser = _userService.Get(Variables.CurrentUser.UserId);
            txtName.Text = currentUser.Name;
            txtSurname.Text = currentUser.Surname;
            txtPhone.Text = currentUser.Phone;
            txtMail.Text = currentUser.Mail;
            txtUserName.Text = currentUser.UserName;
            if (currentUser.Role == Variables.UserType.Employee.ToString())
            {
                rbEmployee.Checked = true;
            }
            else if (currentUser.Role == Variables.UserType.Manager.ToString())
            {
                rbManager.Checked = true;
            }
            else
            {
                rbAdmin.Checked = true;
            }
            if (currentUser.IsActive == true)
            {
                chkIsActive.Checked = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
            frmMain.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var updatedUser = _userService.Get(Variables.CurrentUser.UserId);
                updatedUser.Name = txtName.Text.Trim();
                updatedUser.Surname = txtSurname.Text.Trim();
                updatedUser.Phone = txtPhone.Text.Trim();
                updatedUser.Mail = txtMail.Text.Trim();
                updatedUser.UserName = txtUserName.Text.Trim();
                if (txtPwd1.Text.Trim() != "")
                {
                    updatedUser.Password = CryptTool.EncryptSha(CryptTool.EncryptMd5(txtPwd1.Text.Trim()));
                }
                if (PasswordsAreSame())
                {  
                _userService.Update(updatedUser);
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleştirilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
                frmMain.tsLblSessionName.Text = "Hoşgeldin " + updatedUser.Name;
                frmMain.Show();
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
            //
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

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                pnlTop.Capture = false; //select control

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
    }
}
