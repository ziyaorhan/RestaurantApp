using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Business.Abstract;
using RestaurantZ.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantZ.Entities.Concrete;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmBreakfast : Form
    {
        private IBreakfastService _breakfastService;
        private ICustomerService _customerService;
        private IJoinService _joinService;

        public FrmBreakfast()
        {
            InitializeComponent();
            InitializeCustom();
            _breakfastService = InstanceFactory.GetInstance<IBreakfastService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _joinService = InstanceFactory.GetInstance<IJoinService>();
        }

        private void InitializeCustom()
        {
            pbSearch.Image= Image.FromFile(Global.GetPath("\\Images\\search.png"));
            pbClear.Image = Image.FromFile(Global.GetPath("\\Images\\clear.png"));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain openedFrm = (FrmMain)Application.OpenForms["FrmMain"];
            openedFrm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FillPrize();
            if (txtCustomerDetail.Tag != null && txtCustomerDetail.Text != null)
            {
                Breakfast breakfast = new Breakfast()
                {
                    NumberOfPerson = Convert.ToUInt16(nudNumberOfPerson.Value),
                    ExtraPrice = Convert.ToDecimal(txtExtraPrice.Text),
                    Description = rTxtDescription.Text,
                    CustomerId = Convert.ToInt32(txtCustomerDetail.Tag),
                };
                _breakfastService.Add(breakfast);
                //
                DgvBreakfastFill();
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

        private void FrmBreakfast_Load(object sender, EventArgs e)
        {
            DgvBreakfastFill();
            Global.GetDeleteButton(dgvBreakfast);
            CbCustomerFill();
            GetDefaultValue();
        }

        private void CbCustomerFill()
        {
            cbCustomer.DataSource = _customerService.GetAllActiveAndReceivingBreakfast();
            cbCustomer.ValueMember = "CustomerId";
            cbCustomer.DisplayMember = "CustomerName";
            cbCustomer.SelectedIndex = -1;//hiçbir şey seçili olmasın.
        }
        //Pasif
        private void CbCustomerFill(string customerName)
        {
            cbCustomer.DataSource = _customerService.GetAllRcvBrkfstByCstmrName(customerName);
            cbCustomer.ValueMember = "CustomerId";
            cbCustomer.DisplayMember = "CustomerName";
            cbCustomer.SelectedIndex = -1;//hiçbir şey seçili olmasın.
        }

        private void DgvBreakfastFill()
        {
            dgvBreakfast.DataSource =_joinService.GetAllForBreakfastFormDgv();
            dgvBreakfast.Columns["BreakfastId"].HeaderText = "Id";
            dgvBreakfast.Columns["CustomerName"].HeaderText = "Müşteri";
            dgvBreakfast.Columns["NumberOfPerson"].HeaderText = "K.Sayısı";
            dgvBreakfast.Columns["ExtraPrice"].HeaderText = "Ekstra(TL)";
            dgvBreakfast.Columns["Description"].HeaderText = "Açıklama";
            dgvBreakfast.Columns["nameSurname"].HeaderText = "İşlem Yapan";
            dgvBreakfast.Columns["CreatedDate"].HeaderText = "İşlem Tarihi";
            //
            dgvBreakfast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvBreakfast.RowHeadersWidth = 25;
            dgvBreakfast.Columns["BreakfastId"].Width = 30;
            dgvBreakfast.Columns["CustomerName"].Width = 130;
            dgvBreakfast.Columns["NumberOfPerson"].Width = 50;
            dgvBreakfast.Columns["ExtraPrice"].Width = 60;
            dgvBreakfast.Columns["Description"].Width = 145;
            dgvBreakfast.Columns["nameSurname"].Width = 90;
            dgvBreakfast.Columns["CreatedDate"].Width = 90;
            //
            dgvBreakfast.RowTemplate.ReadOnly = true;
            dgvBreakfast.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.   
            dgvBreakfast.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
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
                dgvBreakfast.DataSource = _joinService.GetAllForBreakfastFormDgv(txtSearch.Text.Trim());
            }
            else
            {
                dgvBreakfast.DataSource = _joinService.GetAllForBreakfastFormDgv();
            }
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void dgvBreakfast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvBreakfast.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                string name = dgvBreakfast.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                string numberOfPerson= dgvBreakfast.Rows[e.RowIndex].Cells["NumberOfPerson"].Value.ToString();
                string extraPrice= dgvBreakfast.Rows[e.RowIndex].Cells["ExtraPrice"].Value.ToString();
                string message = String.Format("Bu işlem geri döndürülemez.\r\n\"{0} müşterisinin {1} kişi ve {2}TL ekstra harcama\" içeren kaydını silmek istediğinizden emin misiniz?", name, numberOfPerson, extraPrice);

                DialogResult dialogResult = MessageBox.Show(message, "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    int deletedBreakfastId = Convert.ToInt32(dgvBreakfast.Rows[e.RowIndex].Cells["BreakfastId"].Value.ToString());
                    try
                    {
                        _breakfastService.Delete(_breakfastService.Get(deletedBreakfastId));
                    }
                    catch
                    {
                        MessageBox.Show("Kullanıcı silinirken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
                    }
                    DgvBreakfastFill();
                }
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
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
