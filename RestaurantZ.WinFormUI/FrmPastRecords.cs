using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmPastRecords : Form
    {
        private IJoinService _joinService;
        private ICustomerService _customerService;
        private IBreakfastService _breakfastService;
        private ILunchService _lunchService;
        private IDinnerService _dinnerService;
        private INightMaleService _nightMaleService;

        public FrmPastRecords()
        {
            InitializeComponent();
            _joinService = InstanceFactory.GetInstance<IJoinService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _breakfastService= InstanceFactory.GetInstance<IBreakfastService>();
            _lunchService = InstanceFactory.GetInstance<ILunchService>();
            _dinnerService= InstanceFactory.GetInstance<IDinnerService>();
            _nightMaleService= InstanceFactory.GetInstance<INightMaleService>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain frmMain = (FrmMain)Application.OpenForms["FrmMain"];
            frmMain.Show();
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

        private void FrmPastRecords_Load(object sender, EventArgs e)
        {
            dtpFirst.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpSecond.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            CbCustomersFill();
            CbServicesFill();
        }

        private void CbCustomersFill()
        {
            cbCustomers.DataSource = _customerService.GetAll();
            cbCustomers.DisplayMember = "CustomerName";
            cbCustomers.ValueMember = "CustomerId";
            cbCustomers.SelectedIndex = -1;
        }

        private void CbServicesFill()
        {
            cbServices.Items.Add("Kahvaltı");
            cbServices.Items.Add("Öğlen Yemeği");
            cbServices.Items.Add("Akşam Yemeği");
            cbServices.Items.Add("Gece Yemeği");
            cbServices.SelectedIndex = 0;
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

        private void dtpFirst_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFirst.Value > dtpSecond.Value)
            {
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden büyük olamaz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFirst.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
        }

        private string selectedService;

        private void btnList_Click(object sender, EventArgs e)
        {
            
            FillDgvPastRecord();
              
        }

        public void FillDgvPastRecord()
        {
            dgvPastRecords.Columns.Clear();
            if (chkAllCustomers.Checked)//tüm müşteriler için
            {
                if (selectedService == "Kahvaltı")
                {
                    dgvPastRecords.DataSource = _joinService.GetAllForBreakfastPastRecord(dtpFirst.Value, dtpSecond.Value);
                }
                else if (selectedService == "Öğlen Yemeği")
                {
                    dgvPastRecords.DataSource = _joinService.GetAllForLunchPastRecord(dtpFirst.Value, dtpSecond.Value);
                }
                else if (selectedService == "Akşam Yemeği")
                {
                    dgvPastRecords.DataSource = _joinService.GetAllForDinnerPastRecord(dtpFirst.Value, dtpSecond.Value);
                }
                else
                {
                    dgvPastRecords.DataSource = _joinService.GetAllForNightMalePastRecord(dtpFirst.Value, dtpSecond.Value);
                }
            }
            else//spesifik bir müşteri için
            {
                int customerId = Convert.ToInt32(cbCustomers.SelectedValue);

                if (selectedService == "Kahvaltı")
                {
                    dgvPastRecords.DataSource = _joinService.GetAllForBreakfastPastRecord(dtpFirst.Value, dtpSecond.Value, customerId);
                }
                else if (selectedService == "Öğlen Yemeği")
                {
                    dgvPastRecords.DataSource = _joinService.GetAllForLunchPastRecord(dtpFirst.Value, dtpSecond.Value, customerId);
                }
                else if (selectedService == "Akşam Yemeği")
                {
                    dgvPastRecords.DataSource = _joinService.GetAllForDinnerPastRecord(dtpFirst.Value, dtpSecond.Value, customerId);
                }
                else
                {
                    dgvPastRecords.DataSource = _joinService.GetAllForNightMalePastRecord(dtpFirst.Value, dtpSecond.Value, customerId);
                }
            }
            dgvPastRecords.Columns["ServiceName"].HeaderText = "Hizmet";
            dgvPastRecords.Columns["CustomerName"].HeaderText = "Müşteri";
            dgvPastRecords.Columns["NumberOfPerson"].HeaderText = "Kişi Sayısı";
            dgvPastRecords.Columns["ExtraPrice"].HeaderText = "Ekstra(TL)";
            dgvPastRecords.Columns["Description"].HeaderText = "Açıklama";
            dgvPastRecords.Columns["nameSurname"].HeaderText = "İşlem Yapan";
            dgvPastRecords.Columns["CreatedDate"].HeaderText = "İşlem Tarihi";
            //
            dgvPastRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPastRecords.RowHeadersWidth = 25;
            dgvPastRecords.RowTemplate.ReadOnly = true;
            dgvPastRecords.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.   
            dgvPastRecords.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Global.GetUpdateButton(dgvPastRecords);
            Global.GetDeleteButton(dgvPastRecords);
        }

        private void cbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedService = cbServices.SelectedItem.ToString();
        }

        private void dgvPastRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvPastRecords.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                string name = dgvPastRecords.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                string numberOfPerson = dgvPastRecords.Rows[e.RowIndex].Cells["NumberOfPerson"].Value.ToString();
                string extraPrice = dgvPastRecords.Rows[e.RowIndex].Cells["ExtraPrice"].Value.ToString();
                string message = String.Format("Bu işlem geri döndürülemez.\r\n\"{0} müşterisinin {1} kişi ve {2}TL ekstra harcama\" içeren kaydını silmek istediğinizden emin misiniz?", name, numberOfPerson, extraPrice);

                DialogResult dialogResult = MessageBox.Show(message, "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    int deletedId = Convert.ToInt32(dgvPastRecords.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                   
                    try
                    {
                        if (dgvPastRecords.Rows[e.RowIndex].Cells["ServiceName"].Value.ToString() == "Kahvaltı")
                        {
                            _breakfastService.Delete(_breakfastService.Get(deletedId));
                        }
                        else if (dgvPastRecords.Rows[e.RowIndex].Cells["ServiceName"].Value.ToString() == "Öğlen Yemeği")
                        {
                            _lunchService.Delete(_lunchService.Get(deletedId));
                        }
                        else if (dgvPastRecords.Rows[e.RowIndex].Cells["ServiceName"].Value.ToString() == "Akşam Yemeği")
                        {
                            _dinnerService.Delete(_dinnerService.Get(deletedId));
                        }
                        else
                        {
                            _nightMaleService.Delete(_nightMaleService.Get(deletedId));
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Kayıt silinirken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
                    }
                    FillDgvPastRecord();
                }
            }
            if (dgvPastRecords.Columns[e.ColumnIndex].Name == "btnUpdate")
            {
                int updatedId = Convert.ToInt32(dgvPastRecords.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                try
                {
                    if (dgvPastRecords.Rows[e.RowIndex].Cells["ServiceName"].Value.ToString() == "Kahvaltı")
                    {
                        FrmUpdatePastRecord frmUpdatePastRecord = new FrmUpdatePastRecord("breakfast", updatedId);
                        frmUpdatePastRecord.ShowDialog();
                    }
                    else if (dgvPastRecords.Rows[e.RowIndex].Cells["ServiceName"].Value.ToString() == "Öğlen Yemeği")
                    {
                        FrmUpdatePastRecord frmUpdatePastRecord = new FrmUpdatePastRecord("lunch", updatedId);
                        frmUpdatePastRecord.ShowDialog();
                    }
                    else if (dgvPastRecords.Rows[e.RowIndex].Cells["ServiceName"].Value.ToString() == "Akşam Yemeği")
                    {
                        FrmUpdatePastRecord frmUpdatePastRecord = new FrmUpdatePastRecord("dinner", updatedId);
                        frmUpdatePastRecord.ShowDialog();
                    }
                    else
                    {
                        FrmUpdatePastRecord frmUpdatePastRecord = new FrmUpdatePastRecord("nightMale", updatedId);
                        frmUpdatePastRecord.ShowDialog();
                    }
                }
                catch
                {
                    MessageBox.Show("Kayıt silinirken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
                }
                FillDgvPastRecord();
            }
        }
    }
}
