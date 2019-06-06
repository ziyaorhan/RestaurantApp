
using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules.FluentValidation;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.DataAccess.Concrete.EntityFramework;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;

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
            ValidationTool.Validate(new UserValidator(new EfUserDal(),user), user);//Burada if else kullanmadık. Çünkü Validate metodu void bir metod olmasına rağmen validasyon sağlanmadığı takdirde throw ile hata fırlatan bir metot dolayısı ile doğrulanma olmaz ise aşağıdaki satıra geçilmeyeceltir. içerisindeki throw
            //data access
            try
            {
                _userDal.Add(user);
            }
            catch 
            {
                throw new Exception("Yeni bir kullanıcı eklenirken hata oluştu.");
            }
        }

        public User Get(int id)
        {
            User user = new User();
            try
            {
                user = _userDal.Get(a => a.UserId == id);
            }
            catch (System.NullReferenceException)
            {
                user = null;
            }
            catch
            {
                throw new Exception("Kullanıcı getirilirken bir hata oluştu");
            }
            return user;
        }

        public void Update(User user)
        {
            ValidationTool.Validate(new UserValidator(new EfUserDal(),user), user);
            try
            {
                _userDal.Update(user);
            }
            catch 
            {
                throw new Exception("Kullanıcı güncellenirken bir hata oluştu.");
            }
        }

        public void Delete(User user)
        {
            try
            {
                _userDal.Delete(user);
            }
            catch (Exception)
            {
                throw new Exception("Kullanıcı silinirken bir hata oluştu.");
            }
        }

        public List<User> GetAll()
        {
            try
            {
                return _userDal.GetAll();
            }
            catch 
            {
                throw new Exception("Kullanıcılar listelenirken bir hata oluştu.");
            }
        }

        //burası dal ile benzer de faklı da olabilir. önce business kodları gelir.
        // GetAll() gibi metotlar burada da olabilir.
        //UI tarafı business ile muhatap olur.
    }
}
