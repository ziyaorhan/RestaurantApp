using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Business.Utilities;
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
    public partial class FrmLogin : Form
    {
        private IUserService _userService;

        public FrmLogin()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pbLogo.BackgroundImage = Image.FromFile(Global.GetPath("\\Images\\login.png"));
            this.ActiveControl = txtUserName;//başlangıçta fokuslamak için
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUserName = txtUserName.Text.Trim();
            string enteredPwd = CryptTool.EncryptSha(CryptTool.EncryptMd5(txtPwd.Text.Trim()));
            try
            {
                this.Cursor = Cursors.WaitCursor;
                var result = _userService.GetByUserNameAndPwd(enteredUserName, enteredPwd);
                if (result != null)
                {
                    Variables.CurrentUser = result;
                    Thread.Sleep(1000);
                    this.Hide();
                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                   // this.Close();
                }
                else
                {
                    MessageBox.Show("Giriş bilgileriniz doğrulanamadı.\r\nLütfen tekrar deneyiniz...", "Hatalı Doğrulama!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                this.Cursor = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("Form açılırken bir hata oluştu.\r\nLütfen tekrar deneyiniz...", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
