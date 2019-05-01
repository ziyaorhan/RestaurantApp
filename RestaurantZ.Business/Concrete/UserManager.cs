
using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules;
using RestaurantZ.Business.ValidationRules.FluentValidation;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.DataAccess.Concrete.EntityFramework;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            //business kodları
            ValidationTool.Validate(new UserValidator(), user);//Burada if else kullanmadık. Çünkü Validate metodu void bir metod olmasına rağmen validasyon sağlanmadığı takdirde throw ile hata fırlatan bir metot dolayısı ile doğrulanma olmaz ise aşağıdaki satıra geçilmeyeceltir. içerisindeki throw
            //data access
            _userDal.Add(user);
        }
        //burası dal ile benzer de faklı da olabilir. önce business kodları gelir.
        // GetAll() gibi metotlar burada da olabilir.
        //UI tarafı business ile muhatap olur.
    }
}
