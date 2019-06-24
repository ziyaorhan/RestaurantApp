using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Entities.Concrete;
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
    public partial class FrmLunch : Form
    {
        private ILunchService _lunchService;
        private ICustomerService _customerService;
        private IJoinService _joinService;
        public FrmLunch()
        {
            InitializeComponent();
            InitializeCustom();
            _lunchService = InstanceFactory.GetInstance<ILunchService>();
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
                Lunch lunch = new Lunch()
                {
                    NumberOfPerson = Convert.ToUInt16(nudNumberOfPerson.Value),
                    ExtraPrice = Convert.ToDecimal(txtExtraPrice.Text),
                    Description = rTxtDescription.Text,
                    CustomerId = Convert.ToInt32(txtCustomerDetail.Tag),
                    UserId = Variables.CurrentUser.UserId
                };
                _lunchService.Add(lunch);
                //
                DgvLunchFill();
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

        private void FrmLunch_Load(object sender, EventArgs e)
        {
            DgvLunchFill();
            Global.GetDeleteButton(dgvLunch);
            CbCustomerFill();
            GetDefaultValue();
        }

        private void CbCustomerFill()
        {
            cbCustomer.DataSource = _customerService.GetAllActiveAndReceivingLunch();
            cbCustomer.ValueMember = "CustomerId";
            cbCustomer.DisplayMember = "CustomerName";
            cbCustomer.SelectedIndex = -1;//hiçbir şey seçili olmasın.
        }
       
        private void DgvLunchFill()
        {
            dgvLunch.DataSource = _joinService.GetAllForLunchFormDgv();
            dgvLunch.Columns["LunchId"].HeaderText = "Id";
            dgvLunch.Columns["CustomerName"].HeaderText = "Müşteri";
            dgvLunch.Columns["NumberOfPerson"].HeaderText = "K.Sayısı";
            dgvLunch.Columns["ExtraPrice"].HeaderText = "Ekstra(TL)";
            dgvLunch.Columns["Description"].HeaderText = "Açıklama";
            dgvLunch.Columns["nameSurname"].HeaderText = "İşlem Yapan";
            dgvLunch.Columns["CreatedDate"].HeaderText = "İşlem Tarihi";
            //
            dgvLunch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvLunch.RowHeadersWidth = 25;
            dgvLunch.Columns["LunchId"].Width = 30;
            dgvLunch.Columns["CustomerName"].Width = 130;
            dgvLunch.Columns["NumberOfPerson"].Width = 50;
            dgvLunch.Columns["ExtraPrice"].Width = 60;
            dgvLunch.Columns["Description"].Width = 145;
            dgvLunch.Columns["nameSurname"].Width = 90;
            dgvLunch.Columns["CreatedDate"].Width = 90;
            //
            dgvLunch.RowTemplate.ReadOnly = true;
            dgvLunch.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.   
            dgvLunch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
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
                dgvLunch.DataSource = _joinService.GetAllForLunchFormDgv(txtSearch.Text.Trim());
            }
            else
            {
                dgvLunch.DataSource = _joinService.GetAllForLunchFormDgv();
            }
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void dgvLunch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvLunch.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                string name = dgvLunch.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                string numberOfPerson = dgvLunch.Rows[e.RowIndex].Cells["NumberOfPerson"].Value.ToString();
                string extraPrice = dgvLunch.Rows[e.RowIndex].Cells["ExtraPrice"].Value.ToString();
                string message = String.Format("Bu işlem geri döndürülemez.\r\n\"{0} müşterisinin {1} kişi ve {2}TL ekstra harcama\" içeren kaydını silmek istediğinizden emin misiniz?", name, numberOfPerson, extraPrice);

                DialogResult dialogResult = MessageBox.Show(message, "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    int deletedLunchId = Convert.ToInt32(dgvLunch.Rows[e.RowIndex].Cells["LunchId"].Value.ToString());
                    try
                    {
                        _lunchService.Delete(_lunchService.Get(deletedLunchId));
                    }
                    catch
                    {
                        MessageBox.Show("Öğlen yemeği silinirken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
                    }
                    DgvLunchFill();
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
