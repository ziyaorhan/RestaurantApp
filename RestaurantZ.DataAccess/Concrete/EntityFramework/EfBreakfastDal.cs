using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.DataAccess.Concrete.EntityFramework
{
    public class EfBreakfastDal :EfEntityRepositoryBase<Breakfast,EfRestaurantContext>, IBreakfastDal
    {

    }
}
