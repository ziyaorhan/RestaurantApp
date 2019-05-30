﻿using System;
using System.Drawing;
using System.Windows.Forms;
using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.Business.Utilities;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmUsers : Form
    {
        public IUserService _userService;

        public FrmUsers()
        {
            InitializeComponent();
            try
            {
                _userService = InstanceFactory.GetInstance<IUserService>();
            }
            catch
            {
                MessageBox.Show("Form açılırken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmNewUser frmNewUser = new FrmNewUser();
            frmNewUser.ShowDialog();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            btnNewUser.Image = Image.FromFile(Global.GetPath("\\Images\\add.png"));
            DgvUsersFill();
            //
            Global.GetUpdateButton(dgvUsers);
            Global.GetDeleteButton(dgvUsers);
        }

        public void DgvUsersFill()
        {
            dgvUsers.DataSource = _userService.GetAll();
            dgvUsers.Columns["CreatedDate"].Visible = false;
            dgvUsers.Columns["CreatedUserId"].Visible = false;
            dgvUsers.Columns["ModifiedDate"].Visible = false;
            dgvUsers.Columns["ModifiedUserId"].Visible = false;
            dgvUsers.Columns["SyncId"].Visible = false;
            dgvUsers.Columns["IsSync"].Visible = false;
            dgvUsers.Columns["Password"].Visible = false;
            dgvUsers.Columns["IsVisible"].Visible = false;
            //
            dgvUsers.Columns["UserId"].HeaderText = "Id";
            dgvUsers.Columns["Name"].HeaderText = "Ad";
            dgvUsers.Columns["Surname"].HeaderText = "Soyad";
            dgvUsers.Columns["Phone"].HeaderText = "Telefon";
            dgvUsers.Columns["Mail"].HeaderText = "E-Posta";
            dgvUsers.Columns["UserName"].HeaderText = "Kullanıcı Adı";
            dgvUsers.Columns["Role"].HeaderText = "Yetki";
            dgvUsers.Columns["IsActive"].HeaderText = "Aktif mi?";
            //
            for (int i = 0; i < dgvUsers.RowCount; i++)
            {
                if (dgvUsers["Role", i].Value.ToString() == Variables.UserType.Employee.ToString())
                {
                    dgvUsers["Role", i].Value = "Çalışan";
                }
                else
                {
                    dgvUsers["Role", i].Value = "Yönetici";
                }
            }
            //
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvUsers.RowTemplate.ReadOnly = true;
            dgvUsers.RowsDefaultCellStyle.SelectionBackColor = Color.Silver;//seçilen hücrenin arka plan rengi.
            dgvUsers.RowHeadersWidth = 25;
            dgvUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain refreshedFrm =(FrmMain) Application.OpenForms["FrmMain"];
            refreshedFrm.Show();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (dgvUsers.Columns[e.ColumnIndex].Name == "btnUpdate")
            {
                int updatedUseerId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserId"].Value.ToString());
                FrmUpdateUserByAdmin frmUpdateUserByAdmin = new FrmUpdateUserByAdmin(updatedUseerId);
                frmUpdateUserByAdmin.ShowDialog();
            }
            //Sil
            if (dgvUsers.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                string name = dgvUsers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bu işlem geri döndürülemez.\r\n\"" + name + "\" isimli kullanıcıyı silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int deletedUseerId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserId"].Value.ToString());
                    try
                    {
                        _userService.Delete(_userService.Get(deletedUseerId));
                    }
                    catch
                    {
                        MessageBox.Show("Kullanıcı silinirken bir hata oluştu.\r\nLütfen tekrar deneyiniz.");
                    }
                    DgvUsersFill();
                }
            }
        }
    }
}
