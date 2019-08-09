using RestaurantZ.Business.Abstract;
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
    public partial class FrmReports : Form
    {
        private IJoinService _joinService;
        private ICustomerService _customerService;

        public FrmReports()
        {
            InitializeComponent();
            this.Icon = new Icon(Global.GetPath("\\Images\\chef.ico"));
            btnReportToExcel.Image = Image.FromFile(Global.GetPath("\\Images\\excel.png"));
            _joinService = InstanceFactory.GetInstance<IJoinService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            dtpFirst.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpSecond.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            ExcelButtonIsEnable();
            CbCustomersFill();
        }

        private void CbCustomersFill()
        {
            cbCustomers.DataSource = _customerService.GetAll();
            cbCustomers.DisplayMember = "CustomerName";
            cbCustomers.ValueMember = "CustomerId";
            cbCustomers.SelectedIndex = -1;
        }

        private void ExcelButtonIsEnable()
        {
            if (dgvReport.RowCount == 0 && dgvReport.ColumnCount == 0)
            {
                btnReportToExcel.Enabled = false;
            }
            else
            {
                btnReportToExcel.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain openedFrm = (FrmMain)Application.OpenForms["FrmMain"];
            openedFrm.Show();
        }

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

        private void chkAllCustomers_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkAllCustomers.Checked == true)
                {
                    cbCustomers.SelectedIndex = -1;
                    cbCustomers.Enabled = false;
                }
                else
                {
                    cbCustomers.SelectedIndex = 0;
                    cbCustomers.Enabled = true;
                }
            }
            catch
            {

                MessageBox.Show("Önce sisteme müşteri ekleyiniz.");
            }
        }

        private void btnDeatailedReport_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;
            if (chkAllCustomers.Checked)
            {
                dgvReport.DataSource = _joinService.GetDetailedReportByDate(dtpFirst.Value, dtpSecond.Value);
            }
            else
            {
                int customerId = Convert.ToInt32(cbCustomers.SelectedValue);
                dgvReport.DataSource = _joinService.GetDetailedReportByDate(dtpFirst.Value, dtpSecond.Value, customerId);
            }
            SheetName = "AyrıntılıRapor";
            dgvReport.Columns["ServiceName"].HeaderText = "Hizmet";
            dgvReport.Columns["CustomerName"].HeaderText = "Müşteri";
            dgvReport.Columns["NumberOfPerson"].HeaderText = "Kişi Sayısı";
            dgvReport.Columns["ExtraPrice"].HeaderText = "Ekstra(TL)";
            dgvReport.Columns["Description"].HeaderText = "Açıklama";
            dgvReport.Columns["nameSurname"].HeaderText = "İşlem Yapan";
            dgvReport.Columns["CreatedDate"].HeaderText = "İşlem Tarihi";
            //
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.RowHeadersWidth = 25;
            dgvReport.RowTemplate.ReadOnly = true;
            dgvReport.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.   
            dgvReport.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ExcelButtonIsEnable();
        }

        private void btnGroupedReport_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;
            if (chkAllCustomers.Checked)
            {
                dgvReport.DataSource = _joinService.GetDetailedReportByDateAsGrouped(dtpFirst.Value, dtpSecond.Value);

            }
            else
            {
                int customerId = Convert.ToInt32(cbCustomers.SelectedValue);
                dgvReport.DataSource = _joinService.GetDetailedReportByDateAsGrouped(dtpFirst.Value, dtpSecond.Value, customerId);
            }
            SheetName = "HesaplanmışRapor";
            dgvReport.Columns["customerId"].HeaderText = "Id";
            dgvReport.Columns["customerName"].HeaderText = "Müşteri";
            dgvReport.Columns["serviceName"].HeaderText = "Hizmet";
            dgvReport.Columns["unitPrice"].HeaderText = "Birim Fiyat(TL)";
            dgvReport.Columns["sumPerson"].HeaderText = "Toplam Kişi Sayısı";
            dgvReport.Columns["sumExtraPrice"].HeaderText = "Toplam Ekstra(TL)";
            dgvReport.Columns["grandTotal"].HeaderText = "Genel Toplam(TL)";
            dgvReport.Columns["dateRange"].HeaderText = "Tarih Aralığı";
            //
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.RowHeadersWidth = 25;
            dgvReport.RowTemplate.ReadOnly = true;
            dgvReport.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.   
            dgvReport.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ExcelButtonIsEnable();
        }

        private void dtpFirst_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFirst.Value > dtpSecond.Value)
            {
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden büyük olamaz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFirst.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
        }

        public string SheetName { get; set; }

        private void btnReportToExcel_Click(object sender, EventArgs e)
        {
            Global.ExportDataGridViewToExcel(dgvReport, SheetName, Global.GetPath("\\Files\\Reports"),SheetName);
        }
    }
}
