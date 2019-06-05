using RestaurantZ.Business.ValidationRules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public static class Global
    {
        //Herhangi bir dosyanın path'ini getirmek için.
        public static string GetPath(string subPath)
        {
            DirectoryInfo projectBinFolder = Directory.GetParent(Application.StartupPath);
            string projectFolderName = projectBinFolder.Parent.FullName;
            string returnPath = projectFolderName + subPath;
            return returnPath;
        }
        //Textbox'ta error mesajlarını göstermek için.
        public static void SetError(System.Windows.Forms.TextBox textBox, string errorMesage)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(textBox, errorMesage);
        } 
        public static void GetUpdateButton(DataGridView dataGridView)
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Name = "btnUpdate";
            btnUpdate.HeaderText = "Güncelle";
            btnUpdate.Text = "Güncelle";
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.DefaultCellStyle.ForeColor = Color.White;
            btnUpdate.DefaultCellStyle.BackColor = Color.Green;
            btnUpdate.UseColumnTextForButtonValue = true; //buton için tex özelliğini kullan.
            dataGridView.Columns.Add(btnUpdate);
        }
        public static void GetDeleteButton(DataGridView dataGridView)
        {
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Sil";
            btnDelete.Text = "Sil";
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.DefaultCellStyle.ForeColor = Color.White;
            btnDelete.DefaultCellStyle.BackColor = Color.Red;
            btnDelete.UseColumnTextForButtonValue = true; //buton için tex özelliğini kullan.
            btnDelete.Width = 30;
            dataGridView.Columns.Add(btnDelete);

        }
    }
}
