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

        public static void ExportDataGridViewToExcel(DataGridView dataGridView, string sheetName, string folderName, string fileName)
        {
            try
            {
                //excel uygulaması oluştur.
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                //excel uygulaması içinde bir çalışma kitabı oluştur.  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                //çalışma kitabında yeni bir excel sayfası oluştur. şimdilik null değeri ata.
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                //programın arkasında excel sayfasına bak.  
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                // aktif sayfa adını değiştir 
                worksheet.Name = sheetName;
                // kolon isimleri
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }
                // satırlar
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                string fileTimeStamp = DateTime.Now.ToShortDateString() + "_" + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString();

                workbook.SaveAs(folderName + "\\" + fileTimeStamp + "-" + fileName + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                // app.Quit();
            }
            catch 
            {
               
            }
        }


    }
}
