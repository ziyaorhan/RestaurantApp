using System;


namespace RestaurantZ.WinFormUI.CustomTools
{
    class LetterTextBox:PlaceHolderTextBox
    {
        public LetterTextBox()
        {
            this.KeyPress += LetterTextBox_KeyPress;
        }

        private void LetterTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            //harf ya da back tuşu değilse engelle
            if (!char.IsLetter(e.KeyChar) && Convert.ToInt32(e.KeyChar) != 8)
            {
                e.Handled = true;
            }
        }
    }
}
