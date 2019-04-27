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
    //inheritence + implementation
    public class EfUserDal : EfEntityRepositoryBase<User, EfRestaurantContext>,IUserDal
    {
        //EfEntityRepositoryBase classından kalıtım aldığı için içi boş
    }
}
