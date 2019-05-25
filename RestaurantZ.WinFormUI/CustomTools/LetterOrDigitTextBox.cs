using System;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI.CustomTools
{
    class LetterOrDigitTextBox: System.Windows.Forms.TextBox
    {
        public LetterOrDigitTextBox()
        {
            this.KeyPress += LetterOrDigitTextBox_KeyPress;
        }

        private void LetterOrDigitTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //girilen karakter harf sayı ya da back tuşu değilse engelle.
            if (!char.IsLetterOrDigit(e.KeyChar) && Convert.ToInt32(e.KeyChar) != 8)
            {
                e.Handled = true;
            }
        }
    }
}
