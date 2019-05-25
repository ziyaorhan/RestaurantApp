using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Business.Utilities;
using System;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmUpdateUserByAdmin : Form
    {
        public IUserService _userService;

        public int updatedUserId { get; set; }

        public FrmUpdateUserByAdmin(int id)
        {
            InitializeComponent();
            try
            {
                updatedUserId = id;
                _userService = InstanceFactory.GetInstance<IUserService>();
            }
            catch 
            {
                MessageBox.Show("Form açılırken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
            }
        }

        private void FrmUpdateUserByAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                var updatedUser = _userService.Get(updatedUserId);
                txtName.Text = updatedUser.Name;
                txtSurname.Text = updatedUser.Surname;
                txtPhone.Text = updatedUser.Phone;
                txtMail.Text = updatedUser.Mail;
                txtUserName.Text = updatedUser.UserName;
                if (updatedUser.Role == Variables.UserType.Employee.ToString())
                {
                    rbEmployee.Checked = true;
                }
                else
                {
                    rbManager.Checked = true;
                }
                if (updatedUser.IsActive == true)
                {
                    chkIsActive.Checked = true;
                }
            }
            catch 
            {
                MessageBox.Show("Bilgiler veri tabanından çekilirken bir hata oluştu.\r\nTekrar deneyiniz.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                var updatedUser = _userService.Get(updatedUserId);
                if (updatedUser != null)
                {
                    updatedUser.Role = rbEmployee.Checked ?
                        Variables.UserType.Employee.ToString() :
                        Variables.UserType.Manager.ToString();
                    updatedUser.IsActive = chkIsActive.Checked;
                    _userService.Update(updatedUser);
                    FrmUsers refreshedFrm = (FrmUsers)Application.OpenForms["FrmUsers"];
                    refreshedFrm.DgvUsersFill();
                }
                Cursor.Current = Cursors.Default;
                this.Close();
            }
            catch
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Kullanıcı durum güncellemesinde bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
                this.Close();
            }
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkIsActive.Checked)
            {
                MessageBox.Show("Bir kullanıcıyı pasif olarak belirlediğinizde, kullanıcı programa artık giriş yapamaz. Bunu yapmak istediğinizden emin misiniz?", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbManager_Click(object sender, EventArgs e)
        {
            if (rbManager.Checked)
            {
                MessageBox.Show("Bir kullanıcıyı yönetici olarak belirlediğinizde, program üzerinde tüm değişiklikleri yapabilecek yetkileri vermiş olursunuz. Bunu yapmak istediğinizden emin misiniz?", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
