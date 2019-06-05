using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI.CustomTools
{
    public class DecimalPlaceHolderTextBox:PlaceHolderTextBox
    {
        public DecimalPlaceHolderTextBox()
        {
            this.KeyPress += DecimalTextBox_KeyPress;
        }

        private void DecimalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğere  karakter Control, digit ya da nokta değilse girişi engelle.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.') && Convert.ToInt32(e.KeyChar) != 8)
            {
                e.Handled = true;
            }
            string enteredStr = (sender as System.Windows.Forms.TextBox).Text;//girilen metni al.

            if (!String.IsNullOrWhiteSpace(enteredStr))
            {
                //ilk karakter nokta ile başlıyorsa 
                char firstChar = Convert.ToChar(enteredStr.Substring(0, 1));
                if (firstChar == '.')
                {
                    (sender as System.Windows.Forms.TextBox).Text = "0.";
                    (sender as System.Windows.Forms.TextBox).SelectionStart = 2;//nokatadan sonra fokusla (index)
                    (sender as System.Windows.Forms.TextBox).Focus();
                }
            }

            // eğer nokta karakteri birden fazla girilirse engelle(== -1 ise 1 defa)
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (enteredStr.Length > 7 && Convert.ToInt32(e.KeyChar) != 8)
            {
                e.Handled = true;
            }
        }
    }
}
