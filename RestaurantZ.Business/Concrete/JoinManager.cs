using RestaurantZ.Business.Abstract;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Concrete
{
    public class JoinManager : IJoinService
    {
        private IUserDal _userDal;
        private ICustomerDal _customerDal;
        private IBreakfastDal _breakfastDal;
        private ILunchDal _lunchDal;

        public JoinManager(IUserDal userDal, ICustomerDal customerDal, IBreakfastDal breakfastDal,ILunchDal lunchDal)
        {
            _userDal = userDal;
            _customerDal = customerDal;
            _breakfastDal = breakfastDal;
            _lunchDal = lunchDal;
        }

        public object GetAllForBreakfastFormDgv()
        {
            var customers = _customerDal.GetAll();
            var breakfasts = _breakfastDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in breakfasts
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.CreatedUserId equals u.UserId
                         where b.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             b.BreakfastId,
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForBreakfastFormDgv(string customerName)
        {
            var customers = _customerDal.GetAll(c => c.CustomerName.ToLower().Contains(customerName.ToLower()));
            var breakfasts = _breakfastDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in breakfasts
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.CreatedUserId equals u.UserId
                         where b.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             b.BreakfastId,
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForLunchFormDgv()
        {
            var customers = _customerDal.GetAll();
            var lunches = _lunchDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from l in lunches
                         join c in customers
                         on l.CustomerId equals c.CustomerId
                         join u in users
                         on l.CreatedUserId equals u.UserId
                         where l.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby l.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             l.LunchId,
                             c.CustomerName,
                             l.NumberOfPerson,
                             l.ExtraPrice,
                             l.Description,
                             l.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForLunchFormDgv(string customerName)
        {
            var customers = _customerDal.GetAll(c => c.CustomerName.ToLower().Contains(customerName.ToLower()));
            var lunches = _lunchDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from l in lunches
                         join c in customers
                         on l.CustomerId equals c.CustomerId
                         join u in users
                         on l.CreatedUserId equals u.UserId
                         where l.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby l.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             l.LunchId,
                             c.CustomerName,
                             l.NumberOfPerson,
                             l.ExtraPrice,
                             l.Description,
                             l.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }
    }
}
