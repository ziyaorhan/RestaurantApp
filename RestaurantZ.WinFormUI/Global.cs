using RestaurantZ.Business.ValidationRules;
using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
