using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.ValidationRules
{
    public static class MyCustomRules
    {
        public static bool RuleForPassword(string enteredStr)
        {
            bool isThereABigLeter = false;//büyük harf
            bool isThereASmallLeter = false;//küçük harf
            bool isThereANumericChar = false;//sayısal karakter
            bool isThereASymbolChar = false;//harf ya da rakam dışındaki karakterler.
            if (!String.IsNullOrEmpty(enteredStr))
            {
                foreach (char item in enteredStr)
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

        public static bool RuleForLetterOrDigit(string enteredStr)
        {
            if (!String.IsNullOrEmpty(enteredStr))
            {
                foreach (Char ch in enteredStr)
                {
                    if (!Char.IsLetterOrDigit(ch))
                    {
                        return false;//eğer harf ya da sayısal karakter dışında bir karakter var ise false dön ve çık.
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RuleForLetter(string enteredStr)
        {
            if (!String.IsNullOrEmpty(enteredStr))
            {
                foreach (Char ch in enteredStr)
                {
                    if (!Char.IsLetter(ch))
                    {
                        return false;//eğer harf dışında bir karakter var ise false dön ve çık.
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RuleForNumber(string enteredStr)
        {
            if (!String.IsNullOrEmpty(enteredStr))
            {
                foreach (Char ch in enteredStr)
                {
                    if (!Char.IsNumber(ch))
                    {
                        return false;//eğer sayısal karakter dışında bir karakter var ise false dön ve çık.
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RuleForDecimal(string enteredStr)
        {
            int pointCount = 0;
            if (!String.IsNullOrEmpty(enteredStr))
            {
                char firstChar = Convert.ToChar(enteredStr.Substring(0, 1));
                string otherChars = enteredStr.Substring(1, enteredStr.Length);
                if (!Char.IsNumber(firstChar))
                {
                    return false;//ilk karakter sayı değilse false dön.
                }
                else
                {
                    foreach (char ch in otherChars)
                    {
                        if (ch=='.')
                        {
                            pointCount += 1;
                            if (pointCount>1)
                            {
                                return false;//eğer '.' karakteri 1 den fazla ise false dön.
                            }
                        }
                        else
                        {
                            if (!Char.IsNumber(ch))
                            {
                                return false;//eğer sayısal karakter dışında bir karakter var ise false dön ve çık.
                            }
                        }
                    }
                    return true;//ilk karakterden sonra 1'den fazla nokta ya da rakam dışında karakter yok ise true dön.
                }
            }
            else
            {
                return false;//gelen değer boş ya da null ise false dön.
            }
        }
    }
}
