using RestaurantZ.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RestaurantZ.Business.ValidationRules
{
    public static class CustomRules
    {
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
                        if (ch == '.')
                        {
                            pointCount += 1;
                            if (pointCount > 1)
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
