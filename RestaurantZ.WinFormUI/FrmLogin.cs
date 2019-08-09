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
using System.ServiceProcess;
using System.Diagnostics;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmLogin : Form
    {
        private IUserService _userService;

        public FrmLogin()
        {
            InitializeComponent();
            this.Icon = new Icon(Global.GetPath("\\Images\\chef.ico"));
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

        private string enteredUserName;

        private string enteredPwd;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string serviceName = "wampmysqld64";
          //  string machineName = "c:\\wamp64\\bin\\mysql\\mysql5.7.23\\bin\\mysqld.exe";
            try
            {
                if (IsRun(serviceName))
                {
                    Login();
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Veritabanı servisleri başlatılamadı. Lütfen servisleri başlatınız.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
        }

        private static bool IsRun(string serviceName)
        {
            ServiceController controller = new ServiceController(serviceName);
            if (controller.Status== ServiceControllerStatus.Running)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool RunService(string serviceName, string machineName)
        {
            bool returnValue = false;
            try
            {
                ServiceController service = new ServiceController(serviceName, machineName);
                if (service.Status == ServiceControllerStatus.Stopped)
                {
                    Process myProcess = new Process();
                    myProcess.StartInfo.UseShellExecute = false;
                    // You can start any process, HelloWorld is a do-nothing example.
                    myProcess.StartInfo.FileName = "c:\\wamp64\\bin\\mysql\\mysql5.7.23\\bin\\mysqld.exe";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    Thread.Sleep(1500);
                }
                //    service.Start();
                //Thread.Sleep(2000);
                //service.Refresh();
                //TimeSpan timeout = TimeSpan.FromMilliseconds(2000);
                //service.WaitForStatus(ServiceControllerStatus.StartPending, timeout);
                //

                returnValue = true;
            }
            catch
            {
                returnValue = false;
                throw new Exception("Veritabanı servisi başlatılamadı.");
            }
            return returnValue;
        }

        private void Login()
        {
            enteredUserName = txtUserName.Text.Trim();
            enteredPwd = CryptTool.EncryptSha(CryptTool.EncryptMd5(txtPwd.Text.Trim()));
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
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
