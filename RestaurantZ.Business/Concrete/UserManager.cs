
using RestaurantZ.Business.Abstract;
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
            UserValidator userValidator = new UserValidator();
            var result = userValidator.Validate(user);
            var ex = new List<MyExceptionModel>();
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ex.Add(new MyExceptionModel
                    {
                        PropertyName = error.PropertyName,
                        ErrorMessage = error.ErrorMessage
                    });
                }
                throw new MyException(ex);
            }
            else
            {
                _userDal.Add(user);
            }

        }
        //burası dal ile benzer de faklı da olabilir. önce business kodları gelir.
        // GetAll() gibi metotlar burada da olabilir.
        //UI tarafı business ile muhatap olur.
    }
}
