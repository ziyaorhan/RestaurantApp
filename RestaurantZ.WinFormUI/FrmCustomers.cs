using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmCustomers : Form
    {
        private ICustomerService _customerService;
        private IUserService _userService;

        public FrmCustomers()
        {
            InitializeComponent();
            InitializeCustom();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _userService = InstanceFactory.GetInstance<IUserService>();           
        }

        private void InitializeCustom()
        {
            btnNewCustomer.Image = Image.FromFile(Global.GetPath("\\Images\\add.png"));
            btnExportToExcel.Image = Image.FromFile(Global.GetPath("\\Images\\excel.png"));
            pbSearch.BackgroundImage = Image.FromFile(Global.GetPath("\\Images\\search.png"));
            pbSearch.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            GetAllCustomer();
        }

        public void GetAllCustomer()
        {
            dgvCustomers.Columns.Clear();
            dgvCustomers.DataSource = _customerService.GetAll();
            GetDgvSettings();
            Global.GetUpdateButton(dgvCustomers);
            Global.GetDeleteButton(dgvCustomers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain refreshedFrm = (FrmMain)Application.OpenForms["FrmMain"];
            refreshedFrm.DgvFrmMainFill();
            refreshedFrm.Show();
        }

        private void GetDgvSettings()
        {
            dgvCustomers.Columns["IsVisible"].Visible = false;
            dgvCustomers.Columns["UserId"].Visible = false;
            dgvCustomers.Columns["CreatedDate"].Visible = false;
            dgvCustomers.Columns["ModifiedDate"].Visible = false;
            dgvCustomers.Columns["SyncId"].Visible = false;
            dgvCustomers.Columns["IsSync"].Visible = false;
            dgvCustomers.Columns["User"].Visible = false;
            dgvCustomers.Columns["Breakfasts"].Visible = false;
            dgvCustomers.Columns["Lunches"].Visible = false;
            dgvCustomers.Columns["Dinners"].Visible = false;
            dgvCustomers.Columns["NightMales"].Visible = false;
            //
            dgvCustomers.Columns["CustomerId"].HeaderText = "Müşteri Id";
            dgvCustomers.Columns["CustomerName"].HeaderText = "Müşteri Adı";
            dgvCustomers.Columns["CustomerRepresentative"].HeaderText = "Firma Temsilcisi";
            dgvCustomers.Columns["Phone1"].HeaderText = "Sabit T.";
            dgvCustomers.Columns["Phone1Intercom"].HeaderText = "Dahili";
            dgvCustomers.Columns["Phone2"].HeaderText = "Cep T.";
            dgvCustomers.Columns["Mail"].HeaderText = "E-Mail";
            dgvCustomers.Columns["Address"].HeaderText = "Adres";
            dgvCustomers.Columns["BreakfastPrice"].HeaderText = "Kahvaltı Birim Fiyatı";
            dgvCustomers.Columns["LunchPrice"].HeaderText = "Öğlen Y.Birim Fiyatı";
            dgvCustomers.Columns["DinnerPrice"].HeaderText = "Akşam Y.Birim Fiyatı";
            dgvCustomers.Columns["NightMalePrice"].HeaderText = "Gece Y.Birim Fiyatı";
            dgvCustomers.Columns["IsActive"].HeaderText = "Aktif mi?";
            dgvCustomers.Columns["Notes"].HeaderText = "Notlar";
            //
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.RowTemplate.ReadOnly = true;
            dgvCustomers.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.
            dgvCustomers.RowHeadersWidth = 25;
            dgvCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FrmNewCustomer frmNewCustomer = new FrmNewCustomer();
            frmNewCustomer.ShowDialog();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.RowIndex < 0)
            {
                return;
            }
            //Güncelle
            if (dgvCustomers.Columns[e.ColumnIndex].Name == "btnUpdate")
            {
                int updatedCustomerId = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
                FrmUpdateCustomers frmUpdateCustomer = new FrmUpdateCustomers(updatedCustomerId);
                frmUpdateCustomer.ShowDialog();
            }
            //Sil
            if (dgvCustomers.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                string name = dgvCustomers.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bu işlem geri döndürülemez.\r\n\"" + name + "\" isimli müşteriyi silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int deletedCustomerId = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
                    try
                    {
                        _customerService.Delete(_customerService.Get(deletedCustomerId));
                    }
                    catch
                    {
                        MessageBox.Show("Bu müşteriye ait geçmiş kayıtlar olduğu için silinemez.\r\nEğer müşteriye bundan sonra hizmet verilmeyecekse, güncelleme formundan pasif yapabilirsiniz...","İşlem Durduruldu!", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    } 
                }
            }
            //
            GetAllCustomer();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.Columns.Clear();
            if (!String.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                dgvCustomers.DataSource = _customerService.GetAllByCustomerName(txtSearch.Text.Trim().ToString());
            }
            else
            {
                dgvCustomers.DataSource = _customerService.GetAll();
            }
            GetDgvSettings();
            Global.GetUpdateButton(dgvCustomers);
            Global.GetDeleteButton(dgvCustomers);
        }

        private void chkPassiveCustomer_CheckedChanged(object sender, EventArgs e)
        {
            dgvCustomers.Columns.Clear();
            if (chkPassiveCustomer.Checked)
            {
                dgvCustomers.DataSource = _customerService.GetPassiveCustomers();
            }
            else
            {
                dgvCustomers.DataSource = _customerService.GetAll();
            }
            GetDgvSettings();
            Global.GetUpdateButton(dgvCustomers);
            Global.GetDeleteButton(dgvCustomers);
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

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            Global.ExportDataGridViewToExcel(dgvCustomers, "Müşteriler", Global.GetPath("\\Files\\Reports"), "Müşteriler",14);
        }
    }
}
