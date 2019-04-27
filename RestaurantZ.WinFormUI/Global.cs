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
        public static string GetPath(string subPath)
        {
            DirectoryInfo projectBinFolder = Directory.GetParent(Application.StartupPath);
            string projectFolderName = projectBinFolder.Parent.FullName;
            string returnPath = projectFolderName + subPath;
            return returnPath;
        }
        public static string GetExceptionsByProperty(List<MyExceptionModel> exceptions,string propertyName)
        {
            string message = "";
                foreach (var exception in exceptions)
                {
                    if (exception.PropertyName == propertyName)
                    {
                        message += "-" + exception.ErrorMessage+Environment.NewLine;
                    }
                } 
            return message;
        }
        public static bool IsThereAExceptionByProperty(List<MyExceptionModel> exceptions,string propertyName)
        {
            if (exceptions!=null)
            {
                foreach (var exception in exceptions)
                {
                    if (exception.PropertyName ==propertyName)
                    {
                        return true; 
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
