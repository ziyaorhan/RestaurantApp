using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Abstract
{
    public interface IJoinService
    {
        object GetAllForBreakfastFormDgv();
        object GetAllForBreakfastFormDgv(string customerName);
    }
}
