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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
          
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            #region Style
            pbLogo.BackgroundImage = Image.FromFile(Global.GetPath("\\Images\\chef.png"));
            //
            tsBtnMin.Image = Image.FromFile(Global.GetPath("\\Images\\minimize.png"));
            //
            tsBtnMax.Image = Image.FromFile(Global.GetPath("\\Images\\maximise.png"));
            //
            tsBtnClose.Image = Image.FromFile(Global.GetPath("\\Images\\close.png"));
            //
            tsBtnHelp.Image = Image.FromFile(Global.GetPath("\\Images\\help.png"));
            //
            tsBtnInfo.Image = Image.FromFile(Global.GetPath("\\Images\\info.png"));
            //
            tsLblSessionName.Image = Image.FromFile(Global.GetPath("\\Images\\person.png"));
            //
            tsBtnSessionOut.Image = Image.FromFile(Global.GetPath("\\Images\\logout.png"));
            //
            tsLblSearch.Image= Image.FromFile(Global.GetPath("\\Images\\search.png"));
            //
            tsBtnClear.Image = Image.FromFile(Global.GetPath("\\Images\\clear.png"));
            //
            bilgilerimiGuncelleToolStripMenuItem.Image = Image.FromFile(Global.GetPath("\\Images\\updateUserInfo.png"));
            //
            tsLblSync.Image = Image.FromFile(Global.GetPath("\\Images\\sync-darkred.png"));
            //
            //MenuItem'ların renk ve icon ayarları
            //mouse eventler user control tarafında yapıldı.
            menuItemBreakFast.lblLabel.Text = "KAHVALTI";
            menuItemBreakFast.pbIcon.Image = Image.FromFile(Global.GetPath("\\Images\\kahvalti.png"));
            //
            menuItemLaunch.lblLabel.Text = "ÖĞLEN YEMEĞİ";
            menuItemLaunch.pbIcon.Image = Image.FromFile(Global.GetPath("\\Images\\oglen.png"));
            //
            menuItemDinner.lblLabel.Text = "AKŞAM YEMEĞİ";
            menuItemDinner.pbIcon.Image = Image.FromFile(Global.GetPath("\\Images\\aksam-2.png"));
            //
            menuItemNightMeal.lblLabel.Text = "GECE YEMEĞİ";
            menuItemNightMeal.pbIcon.Image = Image.FromFile(Global.GetPath("\\Images\\gece.png"));
            //
            tsLblDate.Text = DateTime.Now.ToString("dd MMMMMMM yyyy ddddddddd"); 
            #endregion
        }

        private void tsLblSync_Click(object sender, EventArgs e)
        {
            tsLblSync.Image= Image.FromFile(Global.GetPath("\\Images\\sync-green.gif"));
        }

        // Title bar özelliği(controlbox) kapalı iken formu hareket ettirebilmek için
        // ControlBox=false
        // FormBorderStyle=none
        private void tsTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                tsTop.Capture = false; //select control

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static bool isMax = false;

        private void tsBtnMax_Click(object sender, EventArgs e)
        {
            if (isMax == false)
            {
                this.WindowState = FormWindowState.Maximized;
                isMax = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMax = false;
            }
        }

        private void tsBtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tsBtnInfo_Click(object sender, EventArgs e)
        {

        }

        private void tsBtnHelp_Click(object sender, EventArgs e)
        {

        }

        private void tsBtnSessionOut_Click(object sender, EventArgs e)
        {

        }

        private void tsBtnClear_Click(object sender, EventArgs e)
        {
            tsTxtSearch.Text = "";
        }
    }
}

