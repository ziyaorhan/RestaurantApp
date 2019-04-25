using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.DataAccess.Abstract
{
    public interface IBreakfastDal:IEntityRepository<Breakfast>
    {
    }
}
