﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.ValidationRules
{
    public static class MyMessages
    {
        public static string NotEmty = "Boş geçilemez.";
        public static string EMail = "Geçerli bir E-Posta adresi giriniz.";
        public static string MaxLength(int maxLength)
        {
            return String.Format("En fazla {0} karakter olmalıdır.",maxLength.ToString());
        }
        public static string MinLength(int minLength)
        {
            return String.Format("En az {0} karakter olmalıdır.", minLength.ToString());
        }
        public static string Length(int length)
        {
            return String.Format("Toplam {0} karakter olmalıdır.", length.ToString());
        }
    }
}
