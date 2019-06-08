using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Entities.Concrete;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmDinner : Form
    {
        private IDinnerService _dinnerService;
        private ICustomerService _customerService;
        private IJoinService _joinService;

        public FrmDinner()
        {
            InitializeComponent();
            InitializeCustom();
            _dinnerService = InstanceFactory.GetInstance<IDinnerService>();
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
                Dinner dinner=new Dinner()
                {
                    NumberOfPerson = Convert.ToUInt16(nudNumberOfPerson.Value),
                    ExtraPrice = Convert.ToDecimal(txtExtraPrice.Text),
                    Description = rTxtDescription.Text,
                    CustomerId = Convert.ToInt32(txtCustomerDetail.Tag),
                };
                _dinnerService.Add(dinner);
                //
                DgvDinnerFill();
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

        private void FrmDinner_Load(object sender, EventArgs e)
        {
            DgvDinnerFill();
            Global.GetDeleteButton(dgvDinner);
            CbCustomerFill();
            GetDefaultValue();
        }
      
        private void CbCustomerFill()
        {
            cbCustomer.DataSource = _customerService.GetAllActiveAndReceivingDinner();
            cbCustomer.ValueMember = "CustomerId";
            cbCustomer.DisplayMember = "CustomerName";
            cbCustomer.SelectedIndex = -1;//hiçbir şey seçili olmasın.
        }
        
        private void DgvDinnerFill()
        {
            dgvDinner.DataSource = _joinService.GetAllForDinnerFormDgv();
            dgvDinner.Columns["DinnerId"].HeaderText = "Id";
            dgvDinner.Columns["CustomerName"].HeaderText = "Müşteri";
            dgvDinner.Columns["NumberOfPerson"].HeaderText = "K.Sayısı";
            dgvDinner.Columns["ExtraPrice"].HeaderText = "Ekstra(TL)";
            dgvDinner.Columns["Description"].HeaderText = "Açıklama";
            dgvDinner.Columns["nameSurname"].HeaderText = "İşlem Yapan";
            dgvDinner.Columns["CreatedDate"].HeaderText = "İşlem Tarihi";
            //
            dgvDinner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvDinner.RowHeadersWidth = 25;
            dgvDinner.Columns["DinnerId"].Width = 30;
            dgvDinner.Columns["CustomerName"].Width = 130;
            dgvDinner.Columns["NumberOfPerson"].Width = 50;
            dgvDinner.Columns["ExtraPrice"].Width = 60;
            dgvDinner.Columns["Description"].Width = 145;
            dgvDinner.Columns["nameSurname"].Width = 90;
            dgvDinner.Columns["CreatedDate"].Width = 90;
            //
            dgvDinner.RowTemplate.ReadOnly = true;
            dgvDinner.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.   
            dgvDinner.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
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
                dgvDinner.DataSource = _joinService.GetAllForDinnerFormDgv(txtSearch.Text.Trim());
            }
            else
            {
                dgvDinner.DataSource = _joinService.GetAllForDinnerFormDgv();
            }
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void dgvDinner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvDinner.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                string name = dgvDinner.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                string numberOfPerson = dgvDinner.Rows[e.RowIndex].Cells["NumberOfPerson"].Value.ToString();
                string extraPrice = dgvDinner.Rows[e.RowIndex].Cells["ExtraPrice"].Value.ToString();
                string message = String.Format("Bu işlem geri döndürülemez.\r\n\"{0} müşterisinin {1} kişi ve {2}TL ekstra harcama\" içeren kaydını silmek istediğinizden emin misiniz?", name, numberOfPerson, extraPrice);

                DialogResult dialogResult = MessageBox.Show(message, "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    int deletedDinnerId = Convert.ToInt32(dgvDinner.Rows[e.RowIndex].Cells["DinnerId"].Value.ToString());
                    try
                    {
                        _dinnerService.Delete(_dinnerService.Get(deletedDinnerId));
                    }
                    catch
                    {
                        MessageBox.Show("Akşam yemeği silinirken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
                    }
                    DgvDinnerFill();
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
