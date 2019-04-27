using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.ValidationRules
{
    public static class MyCustomRules
    {
        public static bool RuleForPassword(string enteredPwd)
        {
            bool isThereABigLeter = false;
            bool isThereASmallLeter = false;
            bool isThereANumericChar = false;
            bool isThereASymbolChar = false;
            if (!String.IsNullOrEmpty(enteredPwd))
            {
                foreach (char item in enteredPwd)
                {
                    if (Char.IsUpper(item))
                    {
                        isThereABigLeter = true;
                    }
                    if (Char.IsLower(item))
                    {
                        isThereASmallLeter = true;
                    }
                    if (Char.IsNumber(item))
                    {
                        isThereANumericChar = true;
                    }
                    if (!Char.IsLetterOrDigit(item))
                    {
                        isThereASymbolChar = true;
                    }
                }
            }
            if (isThereABigLeter == true && isThereASmallLeter == true && isThereANumericChar == true && isThereASymbolChar == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
