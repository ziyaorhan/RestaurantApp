using System;
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
    }
}
