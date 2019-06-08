﻿using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
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
        private IJoinService _joinService;
        public FrmMain()
        {
            InitializeComponent();
            InitializeCustom();
            _joinService = InstanceFactory.GetInstance<IJoinService>();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DgvFrmMainFill();
            RecordCountsFill();
        }

        public void RecordCountsFill()
        {
            lblAllRecord.Text = _joinService.GetRecordCount().AllCount.ToString();
            lblBreakfastRecord.Text = _joinService.GetRecordCount().BreakfastCount.ToString();
            lblLunchRecord.Text = _joinService.GetRecordCount().LunchCount.ToString();
            lblDinnerRecord.Text = _joinService.GetRecordCount().DinnerCount.ToString();
            lblNightMaleRecord.Text = _joinService.GetRecordCount().NightMaleCount.ToString();
        }

        public void DgvFrmMainFill()
        {
            dgvMain.DataSource = _joinService.GetAllForMainDgv();
            dgvMain.Columns["ServiceName"].HeaderText = "Hizmet";
            dgvMain.Columns["CustomerName"].HeaderText = "Müşteri";
            dgvMain.Columns["NumberOfPerson"].HeaderText = "Kişi Sayısı";
            dgvMain.Columns["ExtraPrice"].HeaderText = "Ekstra(TL)";
            dgvMain.Columns["Description"].HeaderText = "Açıklama";
            dgvMain.Columns["nameSurname"].HeaderText = "İşlem Yapan";
            dgvMain.Columns["CreatedDate"].HeaderText = "İşlem Tarihi";
            //
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMain.RowHeadersWidth = 25;
            //dgvMain.Columns["ServiceName"].Width = 70;
            //dgvMain.Columns["CustomerName"].Width = 130;
            //dgvMain.Columns["NumberOfPerson"].Width = 50;
            //dgvMain.Columns["ExtraPrice"].Width = 60;
            //dgvMain.Columns["Description"].Width = 145;
            //dgvMain.Columns["nameSurname"].Width = 100;
            //dgvMain.Columns["CreatedDate"].Width = 100;
            //
            dgvMain.RowTemplate.ReadOnly = true;
            dgvMain.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.   
            dgvMain.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void InitializeCustom()
        {
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
            tsLblSearch.Image = Image.FromFile(Global.GetPath("\\Images\\search.png"));
            //
            tsBtnClear.Image = Image.FromFile(Global.GetPath("\\Images\\clear.png"));
            //
            bilgilerimiGuncelleToolStripMenuItem.Image = Image.FromFile(Global.GetPath("\\Images\\updateUserInfo.png"));
            //
            tsLblSync.Image = Image.FromFile(Global.GetPath("\\Images\\sync-darkred.png"));
            //
            //btnBreakfast.Image = Image.FromFile(Global.GetPath("\\Images\\kahvalti.png"));
            //MenuItem'ların renk ve icon ayarları
            //mouse eventler user control tarafında yapıldı.

            //
            lblDateNow.Text = DateTime.Now.ToString("dd MMMMMMM yyyy ddddddddd");
            //
            btnBreakfast.Image= Image.FromFile(Global.GetPath("\\Images\\kahvalti2.png"));
            btnBreakfast.ImageAlign = ContentAlignment.MiddleLeft;
            //
            btnLunch.Image = Image.FromFile(Global.GetPath("\\Images\\oglen.png"));
            btnLunch.ImageAlign = ContentAlignment.MiddleLeft;
            //
            btnDinner.Image = Image.FromFile(Global.GetPath("\\Images\\aksam-2.png"));  
            btnDinner.ImageAlign = ContentAlignment.MiddleLeft;
            //
            btnNightMale.Image = Image.FromFile(Global.GetPath("\\Images\\gece.png"));
            btnNightMale.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void tsLblSync_Click(object sender, EventArgs e)
        {
            tsLblSync.Image = Image.FromFile(Global.GetPath("\\Images\\sync-green.gif"));
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

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            // Cursor.Current = Cursors.WaitCursor;
            this.Hide();
            FrmUsers frmUsers = new FrmUsers();
            frmUsers.ShowDialog();
            //Cursor.Current = Cursors.Default;
        }

        private void tsmiCustomers_Click(object sender, EventArgs e)
        {
            // Cursor.Current = Cursors.WaitCursor;
            this.Hide();
            FrmCustomers frmCustomers = new FrmCustomers();
            frmCustomers.ShowDialog();
            // Cursor.Current = Cursors.Default;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBreakfast frmBreakfast = new FrmBreakfast();
            frmBreakfast.ShowDialog();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLunch frmLunch = new FrmLunch();
            frmLunch.ShowDialog();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDinner frmDinner = new FrmDinner();
            frmDinner.ShowDialog();
        }

        private void btnNightMale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNightMale frmNightMale = new FrmNightMale();
            frmNightMale.ShowDialog();
        }

        private void tsTxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tsTxtSearch.Text.Trim()))
            {
                dgvMain.DataSource = _joinService.GetAllForMainDgv(tsTxtSearch.Text.Trim());
            }
            else
            {
                dgvMain.DataSource = _joinService.GetAllForMainDgv();
            }
        }
    }
}

