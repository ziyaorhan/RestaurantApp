using RestaurantZ.Business.Abstract;
using RestaurantZ.DataAccess.Abstract;
using System;
using System.Linq;

namespace RestaurantZ.Business.Concrete
{
    public class JoinManager : IJoinService
    {
        private IUserDal _userDal;
        private ICustomerDal _customerDal;
        private IBreakfastDal _breakfastDal;
        private ILunchDal _lunchDal;
        private IDinnerDal _dinnerDal;
        private INightMaleDal _nightMaleDal;

        public JoinManager(IUserDal userDal, ICustomerDal customerDal, IBreakfastDal breakfastDal, ILunchDal lunchDal, IDinnerDal dinnerDal,INightMaleDal nightMaleDal)
        {
            _userDal = userDal;
            _customerDal = customerDal;
            _breakfastDal = breakfastDal;
            _lunchDal = lunchDal;
            _dinnerDal = dinnerDal;
            _nightMaleDal = nightMaleDal;
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

        public object GetAllForDinnerFormDgv()
        {
            var customers = _customerDal.GetAll();
            var dinners = _dinnerDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from d in dinners
                         join c in customers
                         on d.CustomerId equals c.CustomerId
                         join u in users
                         on d.CreatedUserId equals u.UserId
                         where d.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby d.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             d.DinnerId,
                             c.CustomerName,
                             d.NumberOfPerson,
                             d.ExtraPrice,
                             d.Description,
                             d.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForDinnerFormDgv(string customerName)
        {
            var customers = _customerDal.GetAll(c => c.CustomerName.ToLower().Contains(customerName.ToLower()));
            var dinners = _dinnerDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from d in dinners
                         join c in customers
                         on d.CustomerId equals c.CustomerId
                         join u in users
                         on d.CreatedUserId equals u.UserId
                         where d.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby d.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             d.DinnerId,
                             c.CustomerName,
                             d.NumberOfPerson,
                             d.ExtraPrice,
                             d.Description,
                             d.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForNightMaleFormDgv()
        {
            var customers = _customerDal.GetAll();
            var nightMales = _nightMaleDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from n in nightMales
                         join c in customers
                         on n.CustomerId equals c.CustomerId
                         join u in users
                         on n.CreatedUserId equals u.UserId
                         where n.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby n.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             n.NightMaleId,
                             c.CustomerName,
                             n.NumberOfPerson,
                             n.ExtraPrice,
                             n.Description,
                             n.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForNightMaleFormDgv(string customerName)
        {
            var customers = _customerDal.GetAll(c => c.CustomerName.ToLower().Contains(customerName.ToLower()));
            var nightMales = _nightMaleDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from n in nightMales
                         join c in customers
                         on n.CustomerId equals c.CustomerId
                         join u in users
                         on n.CreatedUserId equals u.UserId
                         where n.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby n.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             n.NightMaleId,
                             c.CustomerName,
                             n.NumberOfPerson,
                             n.ExtraPrice,
                             n.Description,
                             n.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }
    }
}
