using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Entities.Concrete;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmNightMale : Form
    {
        private INightMaleService _nightMaleService;
        private ICustomerService _customerService;
        private IJoinService _joinService;

        public FrmNightMale()
        {
            InitializeComponent();
            InitializeCustom();
            _nightMaleService = InstanceFactory.GetInstance<INightMaleService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _joinService = InstanceFactory.GetInstance<IJoinService>();
        }

        private void InitializeCustom()
        {
            pbSearch.Image = Image.FromFile(Global.GetPath("\\Images\\search.png"));
            pbClear.Image = Image.FromFile(Global.GetPath("\\Images\\clear.png"));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain openedFrm = (FrmMain)Application.OpenForms["FrmMain"];
            openedFrm.DgvFrmMainFill();
            openedFrm.RecordCountsFill();
            openedFrm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FillPrize();
            if (txtCustomerDetail.Tag != null && txtCustomerDetail.Text != null)
            {
                NightMale nightMale=new NightMale ()
                {
                    NumberOfPerson = Convert.ToUInt16(nudNumberOfPerson.Value),
                    ExtraPrice = Convert.ToDecimal(txtExtraPrice.Text),
                    Description = rTxtDescription.Text,
                    CustomerId = Convert.ToInt32(txtCustomerDetail.Tag),
                };
                _nightMaleService.Add(nightMale);
                //
                DgvNightMaleFill();
            }
            //kayıttan sonra textbox ve combobox'ı eski haline döndür.
            GetDefaultValue();
        }

        private void GetDefaultValue()
        {
            txtCustomerDetail.Tag = null;
            txtCustomerDetail.Text = null;
            txtCustomerDetail.BackColor = SystemColors.Control;
            cbCustomer.SelectedIndex = -1;
            txtExtraPrice.Text = "";
            nudNumberOfPerson.Value = 1;
            rTxtDescription.Text = "";
        }

        private void FillPrize()
        {
            if (txtExtraPrice.Text == "." || txtExtraPrice.Text == "")
            {
                txtExtraPrice.Text = "0.00";
            }
        }

        private void FrmNightMale_Load(object sender, EventArgs e)
        {
            DgvNightMaleFill();
            Global.GetDeleteButton(dgvNightMale);
            CbCustomerFill();
            GetDefaultValue();
        }
        
        private void CbCustomerFill()
        {
            cbCustomer.DataSource = _customerService.GetAllActiveAndReceivingNightMale();
            cbCustomer.ValueMember = "CustomerId";
            cbCustomer.DisplayMember = "CustomerName";
            cbCustomer.SelectedIndex = -1;//hiçbir şey seçili olmasın.
        }
        
        private void DgvNightMaleFill()
        {
            dgvNightMale.DataSource = _joinService.GetAllForNightMaleFormDgv();
            dgvNightMale.Columns["NightMaleId"].HeaderText = "Id";
            dgvNightMale.Columns["CustomerName"].HeaderText = "Müşteri";
            dgvNightMale.Columns["NumberOfPerson"].HeaderText = "K.Sayısı";
            dgvNightMale.Columns["ExtraPrice"].HeaderText = "Ekstra(TL)";
            dgvNightMale.Columns["Description"].HeaderText = "Açıklama";
            dgvNightMale.Columns["nameSurname"].HeaderText = "İşlem Yapan";
            dgvNightMale.Columns["CreatedDate"].HeaderText = "İşlem Tarihi";
            //
            dgvNightMale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvNightMale.RowHeadersWidth = 25;
            dgvNightMale.Columns["NightMaleId"].Width = 30;
            dgvNightMale.Columns["CustomerName"].Width = 130;
            dgvNightMale.Columns["NumberOfPerson"].Width = 50;
            dgvNightMale.Columns["ExtraPrice"].Width = 60;
            dgvNightMale.Columns["Description"].Width = 145;
            dgvNightMale.Columns["nameSurname"].Width = 90;
            dgvNightMale.Columns["CreatedDate"].Width = 90;
            //
            dgvNightMale.RowTemplate.ReadOnly = true;
            dgvNightMale.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.   
            dgvNightMale.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerDetail.Text = cbCustomer.Text;
            txtCustomerDetail.Tag = cbCustomer.SelectedValue;
            if (cbCustomer.Text == "")
            {
                txtCustomerDetail.BackColor = SystemColors.Control;//başlangıçta
            }
            else
            {
                txtCustomerDetail.BackColor = Color.GreenYellow;//index değiştiğinde
            }

        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                dgvNightMale.DataSource = _joinService.GetAllForNightMaleFormDgv(txtSearch.Text.Trim());
            }
            else
            {
                dgvNightMale.DataSource = _joinService.GetAllForNightMaleFormDgv();
            }
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void dgvNightMale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvNightMale.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                string name = dgvNightMale.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                string numberOfPerson = dgvNightMale.Rows[e.RowIndex].Cells["NumberOfPerson"].Value.ToString();
                string extraPrice = dgvNightMale.Rows[e.RowIndex].Cells["ExtraPrice"].Value.ToString();
                string message = String.Format("Bu işlem geri döndürülemez.\r\n\"{0} müşterisinin {1} kişi ve {2}TL ekstra harcama\" içeren kaydını silmek istediğinizden emin misiniz?", name, numberOfPerson, extraPrice);

                DialogResult dialogResult = MessageBox.Show(message, "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    int deletedNightMaleId = Convert.ToInt32(dgvNightMale.Rows[e.RowIndex].Cells["NightMaleId"].Value.ToString());
                    try
                    {
                        _nightMaleService.Delete(_nightMaleService.Get(deletedNightMaleId));
                    }
                    catch
                    {
                        MessageBox.Show("Gece yemeği silinirken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
                    }
                    DgvNightMaleFill();
                }
            }
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
    }
}
