using System;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI.CustomTools
{
    class LetterTextBox: System.Windows.Forms.TextBox
    {
        public LetterTextBox()
        {
            this.KeyPress += LetterTextBox_KeyPress;
        }

        private void LetterTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //harf ya da back tuşu değilse engelle
            if (!char.IsLetter(e.KeyChar) && Convert.ToInt32(e.KeyChar) != 8&& e.KeyChar!=(char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
