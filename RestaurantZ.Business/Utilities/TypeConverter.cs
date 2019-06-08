using RestaurantZ.Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Utilities
{
    public static class TypeConverter
    {
        public static List<MainFormDgv> ConvertDgvModel(IEnumerable list)
        {
            List<MainFormDgv> mainFormDgvs = new List<MainFormDgv>();
            foreach (var item in list)
            {
                mainFormDgvs.Add((MainFormDgv)item);
            }
            return mainFormDgvs;  
        }
    }
}
