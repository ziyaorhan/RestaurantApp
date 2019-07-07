using RestaurantZ.Business.ValidationRules;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        public static void ExportDataGridViewToExcel(DataGridView dataGridView, string sheetName, string folderName, string fileName,int columnsCount)
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
                for (int i = 1; i <= columnsCount; i++)
                {
                    worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }
                // satırlar
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < columnsCount; j++)
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

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetHtmlStringForReports(List<ModelForGroupedReport> lst1, List<ModelForDetailedReport> lst2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<!DOCTYPE html><html lang='tr'><head><meta charset='UTF-8'><meta name='viewport' content='width=device-width, initial-scale=1.0'><meta http-equiv='X-UA-Compatible' content='ie=edge'><title>Hesaplı Rapor</title><style>");
            sb.Append("body {font-family: Verdana, Geneva, sans-serif;font-size: small;}");
            sb.Append("table {border-collapse: collapse;}");
            sb.Append("table,th,td {border: 1px solid silver;padding: 5px}");
            sb.Append("tr:nth-child(even) {background-color: #dddddd;}</style></head><body>");
            sb.Append("<h4>Merhaba,</h4><p>");
            sb.Append(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString());
            sb.Append(" - ");
            sb.Append(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToShortDateString());
            sb.Append(" tarih aralığına ait <b style='background-color: yellow'>hesaplı rapor</b> aşağıdaki gibidir. Lütfen içeriği kontrol ediniz.</p><table><tr>");
            sb.Append("<th>Müşteri Id</th>");
            sb.Append("<th>Müşteri Adı</th>");
            sb.Append("<th>Hizmet</th>");
            sb.Append("<th>Birim Fiyat</th>");
            sb.Append("<th>Toplam Kişi Sayısı</th>");
            sb.Append("<th>Toplam Ekstra(TL)</th>");
            sb.Append("<th>Genel Toplam(TL)</th>");
            sb.Append("<th>Tarih Aralığı</th></tr>");
            foreach (var row in lst1)
            {
                sb.Append("<tr><td>" + row.customerId.ToString() + "</td>");
                sb.Append("<td>" + row.customerName + "</td>");
                sb.Append("<td>" + row.serviceName + "</td>");
                sb.Append("<td>" + row.unitPrice.ToString() + "</td>");
                sb.Append("<td>" + row.sumPerson.ToString() + "</td>");
                sb.Append("<td>" + row.sumExtraPrice.ToString() + "</td>");
                sb.Append("<td>" + row.grandTotal.ToString() + "</td>");
                sb.Append("<td>" + row.dateRange + "</td></tr>");
            }
            sb.Append("</table><br><hr><br>");
            sb.Append(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString());
            sb.Append(" - ");
            sb.Append(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).ToShortDateString());
            sb.Append(" tarih aralığına ait <b style='background-color: yellow'>detaylı rapor</b> aşağıdaki gibidir. Lütfen içeriği kontrol ediniz.</p><table><tr>");
            sb.Append("<th>İşlem Tarihi</th>");
            sb.Append("<th>Hizmet</th>");
            sb.Append("<th>Müşteri Adı</th>");
            sb.Append("<th>Kişi Sayısı</th>");
            sb.Append("<th>Ekstra(TL)</th>");
            sb.Append("<th>Açıklama</th>");
            sb.Append("<th>İşlemi Yapan</th></tr>");
            foreach (var row in lst2)
            {
                sb.Append("<td>" + row.CreatedDate.ToString() + "</td>");
                sb.Append("<td>" + row.ServiceName + "</td>");
                sb.Append("<td>" + row.CustomerName + "</td>");
                sb.Append("<td>" + row.NumberOfPerson.ToString() + "</td>");
                sb.Append("<td>" + row.ExtraPrice.ToString() + "</td>");
                sb.Append("<td>" + row.Description + "</td>");
                sb.Append("<td>" + row.nameSurname + "</td></tr>");
            }

            sb.Append("</table><br><hr><br><p><b><i>Kevser Kebap</i></b><br><br>Not: Bu bir robot mesajdır. Lütfen yanıtlamayınız...</p></body></html>");
            return sb.ToString();
        }

        public static bool SendEmail(string subject, string htmlString, string toMailAdress)
        {
            bool returnValue = false;
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("bilgi@dogrucevaptuzla.com");
                message.To.Add(new MailAddress(toMailAdress));
                message.Subject = subject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "mail.dogrucevaptuzla.com"; //for gmail host  
                smtp.EnableSsl = false;// ssl sertifikası varsa true yapılacak
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("bilgi@dogrucevaptuzla.com", "%34dcTuzla");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                returnValue = true;
            }
            catch
            {
                MessageBox.Show("Mail gönderilirken bir hata oluştu.\r\nLütfen tekrar deneyiniz", "Gönderim Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                returnValue = false;
            }
            return returnValue;
        }
    }
}
