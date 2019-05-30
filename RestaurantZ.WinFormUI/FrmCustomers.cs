﻿using RestaurantZ.Business.Abstract;
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
            btnNewCustomer.Image = Image.FromFile(Global.GetPath("\\Images\\add.png"));
            pbSearch.BackgroundImage = Image.FromFile(Global.GetPath("\\Images\\search.png"));
            pbSearch.BackgroundImageLayout = ImageLayout.Stretch;
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            _userService = InstanceFactory.GetInstance<IUserService>();
            DgvCustomerFill();
            Global.GetUpdateButton(dgvCustomers);
            Global.GetDeleteButton(dgvCustomers);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain refreshedFrm = (FrmMain)Application.OpenForms["FrmMain"];
            refreshedFrm.Show();
        }

        public void DgvCustomerFill()
        {
            dgvCustomers.DataSource = _customerService.GetAll();
            dgvCustomers.Columns["CustomerRepresentative"].Visible = false;
            dgvCustomers.Columns["Phone1"].Visible = false;
            dgvCustomers.Columns["Phone1Intercom"].Visible = false;
            dgvCustomers.Columns["Phone2"].Visible = false;
            dgvCustomers.Columns["Mail"].Visible = false;
            dgvCustomers.Columns["Address"].Visible = false;
            dgvCustomers.Columns["Notes"].Visible = false;
            dgvCustomers.Columns["IsVisible"].Visible = false;
            dgvCustomers.Columns["CreatedDate"].Visible = false;
            dgvCustomers.Columns["CreatedUserId"].Visible = false;
            dgvCustomers.Columns["ModifiedDate"].Visible = false;
            dgvCustomers.Columns["ModifiedUserId"].Visible = false;
            dgvCustomers.Columns["SyncId"].Visible = false;
            dgvCustomers.Columns["IsSync"].Visible = false;
            //
            dgvCustomers.Columns["CustomerId"].HeaderText = "Müşteri Id";
            dgvCustomers.Columns["CustomerName"].HeaderText = "Müşteri Adı";
            dgvCustomers.Columns["BreakfastPrice"].HeaderText = "Kahvaltı Fiyatı";
            dgvCustomers.Columns["LunchPrice"].HeaderText = "Öğlen Y. Fiyatı";
            dgvCustomers.Columns["DinnerPrice"].HeaderText = "Akşam Y. Fiyatı";
            dgvCustomers.Columns["NightMalePrice"].HeaderText = "Gece Y. Fiyatı";
            dgvCustomers.Columns["IsActive"].HeaderText = "Aktif mi?";
            //
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
                        MessageBox.Show("Kullanıcı silinirken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
                    }
                    DgvCustomerFill();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                dgvCustomers.DataSource = _customerService.GetAllByCustomerName(txtSearch.Text.Trim().ToString());
            }
            else
            {
                dgvCustomers.DataSource = _customerService.GetAll();
            }
        }

        private void chkPassiveCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassiveCustomer.Checked)
            {
                dgvCustomers.DataSource = _customerService.GetPassiveCustomers();
            }
            else
            {
                dgvCustomers.DataSource = _customerService.GetAll();
            }
        }
    }
}
