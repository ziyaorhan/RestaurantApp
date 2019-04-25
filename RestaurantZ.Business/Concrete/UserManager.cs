
using RestaurantZ.Business.Abstract;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.DataAccess.Concrete.EntityFramework;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Concrete
{
    public class UserManager :IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public UserManager(EfBreakfastDal efBreakfastDal)
        {
        }

        public bool Add(User user)
        {
            _userDal.Add(user);
            return true;
        }
        //burası dal ile benzer de faklı da olabilir. önce business kodları gelir.
        // GetAll() gibi metotlar burada da olabilir.
        //UI tarafı business ile muhatap olur.
    }
}
