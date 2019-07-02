using RestaurantZ.Business.Abstract;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public JoinManager(IUserDal userDal, ICustomerDal customerDal, IBreakfastDal breakfastDal, ILunchDal lunchDal, IDinnerDal dinnerDal, INightMaleDal nightMaleDal)
        {
            _userDal = userDal;
            _customerDal = customerDal;
            _breakfastDal = breakfastDal;
            _lunchDal = lunchDal;
            _dinnerDal = dinnerDal;
            _nightMaleDal = nightMaleDal;
        }
        //
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
                         on b.UserId equals u.UserId
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
                         on b.UserId equals u.UserId
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

        public object GetAllForBreakfastPastRecord(DateTime firstDate, DateTime secondDate)
        {
            var customers = _customerDal.GetAll();
            var breakfasts = _breakfastDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in breakfasts
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.UserId equals u.UserId
                         where Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             Id = b.BreakfastId,
                             ServiceName = "Kahvaltı",
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForBreakfastPastRecord(DateTime firstDate, DateTime secondDate, int customerId)
        {
            var customers = _customerDal.GetAll().Where(c => c.CustomerId == customerId);
            var breakfasts = _breakfastDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in breakfasts
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.UserId equals u.UserId
                         where Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             Id = b.BreakfastId,
                             ServiceName = "Kahvaltı",
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }
        //
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
                         on l.UserId equals u.UserId
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
                         on l.UserId equals u.UserId
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

        public object GetAllForLunchPastRecord(DateTime firstDate, DateTime secondDate)
        {
            var customers = _customerDal.GetAll();
            var lunches = _lunchDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in lunches
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.UserId equals u.UserId
                         where Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             Id = b.LunchId,
                             ServiceName = "Öğlen Yemeği",
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForLunchPastRecord(DateTime firstDate, DateTime secondDate, int customerId)
        {
            var customers = _customerDal.GetAll().Where(c => c.CustomerId == customerId);
            var lunches = _lunchDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in lunches
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.UserId equals u.UserId
                         where Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             Id = b.LunchId,
                             ServiceName = "Öğlen Yemeği",
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }
        //
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
                         on d.UserId equals u.UserId
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
                         on d.UserId equals u.UserId
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

        public object GetAllForDinnerPastRecord(DateTime firstDate, DateTime secondDate)
        {
            var customers = _customerDal.GetAll();
            var dinners = _dinnerDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in dinners
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.UserId equals u.UserId
                         where Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             Id = b.DinnerId,
                             ServiceName = "Akşam Yemeği",
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForDinnerPastRecord(DateTime firstDate, DateTime secondDate, int customerId)
        {
            var customers = _customerDal.GetAll().Where(c => c.CustomerId == customerId);
            var dinners = _dinnerDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in dinners
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.UserId equals u.UserId
                         where Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             Id = b.DinnerId,
                             ServiceName = "Akşam Yemeği",
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }
        //
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
                         on n.UserId equals u.UserId
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
                         on n.UserId equals u.UserId
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

        public object GetAllForNightMalePastRecord(DateTime firstDate, DateTime secondDate)
        {
            var customers = _customerDal.GetAll();
            var nightMale = _nightMaleDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in nightMale
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.UserId equals u.UserId
                         where Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             Id = b.NightMaleId,
                             ServiceName = "Gece Yemeği",
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForNightMalePastRecord(DateTime firstDate, DateTime secondDate, int customerId)
        {
            var customers = _customerDal.GetAll().Where(c => c.CustomerId == customerId);
            var nightMale = _nightMaleDal.GetAll();
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from b in nightMale
                         join c in customers
                         on b.CustomerId equals c.CustomerId
                         join u in users
                         on b.UserId equals u.UserId
                         where Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(b.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())
                         orderby b.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             Id = b.NightMaleId,
                             ServiceName = "Gece Yemeği",
                             c.CustomerName,
                             b.NumberOfPerson,
                             b.ExtraPrice,
                             b.Description,
                             b.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }
        //
        public object GetAllForMainDgv()
        {
            var customers = _customerDal.GetAll();
            var breakfasts = _breakfastDal.GetAll();
            var lunches = _lunchDal.GetAll();
            var dinners = _dinnerDal.GetAll();
            var nigthMales = _nightMaleDal.GetAll();
            var allServices = GetAllServices(breakfasts, lunches, dinners, nigthMales);
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from a in allServices
                         join c in customers
                         on a.CustomerId equals c.CustomerId
                         join u in users
                         on a.CreatedUserId equals u.UserId
                         where a.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby a.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             a.ServiceName,
                             c.CustomerName,
                             a.NumberOfPerson,
                             a.ExtraPrice,
                             a.Description,
                             a.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetAllForMainDgv(string customerName)
        {
            var customers = _customerDal.GetAll(c => c.CustomerName.ToLower().Contains(customerName.ToLower()));
            var breakfasts = _breakfastDal.GetAll();
            var lunches = _lunchDal.GetAll();
            var dinners = _dinnerDal.GetAll();
            var nigthMales = _nightMaleDal.GetAll();
            var allServices = GetAllServices(breakfasts, lunches, dinners, nigthMales);
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from a in allServices
                         join c in customers
                         on a.CustomerId equals c.CustomerId
                         join u in users
                         on a.CreatedUserId equals u.UserId
                         where a.CreatedDate.Value.ToShortDateString() == dateTimeNow//bu günün kayıtları
                         orderby a.CreatedDate descending// tarihe göre tersten sırala
                         select new
                         {
                             a.ServiceName,
                             c.CustomerName,
                             a.NumberOfPerson,
                             a.ExtraPrice,
                             a.Description,
                             a.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        private static List<ModelForAllServices> GetAllServices(List<Breakfast> breakfasts, List<Lunch> lunches, List<Dinner> dinners, List<NightMale> nigthMales)
        {
            List<ModelForAllServices> allService = new List<ModelForAllServices>();
            foreach (var item in breakfasts)
            {
                allService.Add(new ModelForAllServices
                {
                    NumberOfPerson = item.NumberOfPerson,
                    ExtraPrice = item.ExtraPrice,
                    Description = item.Description,
                    CustomerId = item.CustomerId,
                    ServiceName = "Kahvaltı",
                    CreatedUserId = item.UserId,
                    CreatedDate = item.CreatedDate
                });
            }
            foreach (var item in lunches)
            {
                allService.Add(new ModelForAllServices
                {
                    NumberOfPerson = item.NumberOfPerson,
                    ExtraPrice = item.ExtraPrice,
                    Description = item.Description,
                    CustomerId = item.CustomerId,
                    ServiceName = "Öğlen Y.",
                    CreatedUserId = item.UserId,
                    CreatedDate = item.CreatedDate
                });
            }
            foreach (var item in dinners)
            {
                allService.Add(new ModelForAllServices
                {
                    NumberOfPerson = item.NumberOfPerson,
                    ExtraPrice = item.ExtraPrice,
                    Description = item.Description,
                    CustomerId = item.CustomerId,
                    ServiceName = "Akşam Y.",
                    CreatedUserId = item.UserId,
                    CreatedDate = item.CreatedDate
                });
            }
            foreach (var item in nigthMales)
            {
                allService.Add(new ModelForAllServices
                {
                    NumberOfPerson = item.NumberOfPerson,
                    ExtraPrice = item.ExtraPrice,
                    Description = item.Description,
                    CustomerId = item.CustomerId,
                    ServiceName = "Gece Y.",
                    CreatedUserId = item.UserId,
                    CreatedDate = item.CreatedDate
                });
            }
            return allService;
        }

        public ModelForRecordCount GetRecordCount()
        {
            var dateTimeNow = DateTime.Now.ToShortDateString().ToString();
            int breakfasts = _breakfastDal.GetAll().Where(a => a.CreatedDate.Value.ToShortDateString().ToString() == dateTimeNow).ToList().Count;
            int lunches = _lunchDal.GetAll().Where(a => a.CreatedDate.Value.ToShortDateString().ToString() == dateTimeNow).ToList().Count;
            int dinners = _dinnerDal.GetAll().Where(a => a.CreatedDate.Value.ToShortDateString().ToString() == dateTimeNow).ToList().Count;
            int nigthMales = _nightMaleDal.GetAll().Where(a => a.CreatedDate.Value.ToShortDateString().ToString() == dateTimeNow).ToList().Count;
            int all = breakfasts + lunches + dinners + nigthMales;
            var result = new ModelForRecordCount
            {
                BreakfastCount = breakfasts,
                LunchCount = lunches,
                DinnerCount = dinners,
                NightMaleCount = nigthMales,
                AllCount = all
            };
            return result;
        }

        public object GetDetailedReportByDate(DateTime firstDate, DateTime secondDate)
        {
            var customers = _customerDal.GetAll();
            var breakfasts = _breakfastDal.GetAll();
            var lunches = _lunchDal.GetAll();
            var dinners = _dinnerDal.GetAll();
            var nigthMales = _nightMaleDal.GetAll();
            var allServices = GetAllServices(breakfasts, lunches, dinners, nigthMales);
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from a in allServices
                         join c in customers
                         on a.CustomerId equals c.CustomerId
                         join u in users
                         on a.CreatedUserId equals u.UserId
                         where (Convert.ToDateTime(a.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(a.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())) //verilen tarih aralığında
                         orderby a.CreatedDate ascending// tarihe göre sırala
                         select new
                         {
                             a.ServiceName,
                             c.CustomerName,
                             a.NumberOfPerson,
                             a.ExtraPrice,
                             a.Description,
                             a.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }   

        public object GetDetailedReportByDate(DateTime firstDate, DateTime secondDate, int customerId)
        {
            var customers = _customerDal.GetAll(c => c.CustomerId == customerId);
            var breakfasts = _breakfastDal.GetAll();
            var lunches = _lunchDal.GetAll();
            var dinners = _dinnerDal.GetAll();
            var nigthMales = _nightMaleDal.GetAll();
            var allServices = GetAllServices(breakfasts, lunches, dinners, nigthMales);
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from a in allServices
                         join c in customers
                         on a.CustomerId equals c.CustomerId
                         join u in users
                         on a.CreatedUserId equals u.UserId
                         where (Convert.ToDateTime(a.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(a.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())) //verilen tarih aralığında
                         orderby a.CreatedDate ascending// tarihe göre sırala
                         select new
                         {
                             a.ServiceName,
                             c.CustomerName,
                             a.NumberOfPerson,
                             a.ExtraPrice,
                             a.Description,
                             a.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            return result.ToList();
        }

        public object GetDetailedReportByDateAsGrouped(DateTime firstDate, DateTime secondDate)
        {
            var grupedBreakfasts = _breakfastDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Kahvaltı",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).BreakfastPrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).BreakfastPrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var grupedLunches = _lunchDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Öğlen Y.",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).LunchPrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).LunchPrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var grupedDinners = _dinnerDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Akşam Y.",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).DinnerPrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).DinnerPrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var grupedNightMale = _lunchDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Gece Y.",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).NightMalePrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).NightMalePrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var allServiceGruped = grupedBreakfasts.Concat(grupedLunches).Concat(grupedDinners).Concat(grupedNightMale).OrderBy(a => a.customerName).ToList();
            return allServiceGruped;
        }
      
        public object GetDetailedReportByDateAsGrouped(DateTime firstDate, DateTime secondDate, int customerId)
        {
            var grupedBreakfasts = _breakfastDal.GetAll()
                 .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                 .GroupBy(g => g.CustomerId)
                 .Select(a => new
                 {
                     customerId = a.Key,
                     customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                     serviceName = "Kahvaltı",
                     unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).BreakfastPrice,
                     sumPerson = a.Sum(t => t.NumberOfPerson),
                     sumExtraPrice = a.Sum(p => p.ExtraPrice),
                     grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).BreakfastPrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                     dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                 }).ToList();
            //
            var grupedLunches = _lunchDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Öğlen Y.",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).LunchPrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).LunchPrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var grupedDinners = _dinnerDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Akşam Y.",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).DinnerPrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).DinnerPrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var grupedNightMale = _lunchDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Gece Y.",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).NightMalePrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).NightMalePrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var allServiceGruped = grupedBreakfasts
                .Concat(grupedLunches)
                .Concat(grupedDinners)
                .Concat(grupedNightMale)
                .Where(c => c.customerId == customerId)
                .OrderBy(a => a.customerName)

                .ToList();
            return allServiceGruped;
        }
        //
        public List<ModelForDetailedReport> GetDetailedReportForMail(DateTime firstDate, DateTime secondDate)
        {
            List<ModelForDetailedReport> lst = new List<ModelForDetailedReport>();
            var customers = _customerDal.GetAll();
            var breakfasts = _breakfastDal.GetAll();
            var lunches = _lunchDal.GetAll();
            var dinners = _dinnerDal.GetAll();
            var nigthMales = _nightMaleDal.GetAll();
            var allServices = GetAllServices(breakfasts, lunches, dinners, nigthMales);
            var users = _userDal.GetAll();
            var dateTimeNow = DateTime.Now.ToShortDateString();
            var result = from a in allServices
                         join c in customers
                         on a.CustomerId equals c.CustomerId
                         join u in users
                         on a.CreatedUserId equals u.UserId
                         where (Convert.ToDateTime(a.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(a.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString())) //verilen tarih aralığında
                         orderby a.CreatedDate ascending// tarihe göre sırala
                         select new
                         {
                             a.ServiceName,
                             c.CustomerName,
                             a.NumberOfPerson,
                             a.ExtraPrice,
                             a.Description,
                             a.CreatedDate,
                             nameSurname = u.Name + " " + u.Surname
                         };
            lst = result as List<ModelForDetailedReport>;
            return lst;
        }

        public List<ModelForGroupedReport> GetGroupedReportForMail(DateTime firstDate, DateTime secondDate)
        {
            List<ModelForGroupedReport> lst = new List<ModelForGroupedReport>();
            var grupedBreakfasts = _breakfastDal.GetAll()
               .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
               .GroupBy(g => g.CustomerId)
               .Select(a => new
               {
                   customerId = a.Key,
                   customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                   serviceName = "Kahvaltı",
                   unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).BreakfastPrice,
                   sumPerson = a.Sum(t => t.NumberOfPerson),
                   sumExtraPrice = a.Sum(p => p.ExtraPrice),
                   grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).BreakfastPrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                   dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
               }).ToList();
            //
            var grupedLunches = _lunchDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Öğlen Y.",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).LunchPrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).LunchPrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var grupedDinners = _dinnerDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Akşam Y.",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).DinnerPrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).DinnerPrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var grupedNightMale = _lunchDal.GetAll()
                .Where(t => Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) >= Convert.ToDateTime(firstDate.ToShortDateString()) && Convert.ToDateTime(t.CreatedDate.Value.ToShortDateString()) <= Convert.ToDateTime(secondDate.ToShortDateString()))
                .GroupBy(g => g.CustomerId)
                .Select(a => new
                {
                    customerId = a.Key,
                    customerName = _customerDal.Get(c => c.CustomerId == a.Key).CustomerName,
                    serviceName = "Gece Y.",
                    unitPrice = _customerDal.Get(c => c.CustomerId == a.Key).NightMalePrice,
                    sumPerson = a.Sum(t => t.NumberOfPerson),
                    sumExtraPrice = a.Sum(p => p.ExtraPrice),
                    grandTotal = ((_customerDal.Get(c => c.CustomerId == a.Key).NightMalePrice) * (a.Sum(t => t.NumberOfPerson))) + (a.Sum(p => p.ExtraPrice)),
                    dateRange = firstDate.ToShortDateString() + "-" + secondDate.ToShortDateString()
                }).ToList();
            //
            var allServiceGruped = grupedBreakfasts.Concat(grupedLunches).Concat(grupedDinners).Concat(grupedNightMale).OrderBy(a => a.customerName).ToList();
            foreach (var item in allServiceGruped)
            {
                lst.Add(
                    new ModelForGroupedReport
                    {
                        customerId = item.customerId,
                        customerName = item.customerName,
                        dateRange = item.dateRange,
                        grandTotal = item.grandTotal,
                        serviceName = item.serviceName,
                        sumExtraPrice = item.sumExtraPrice,
                        sumPerson = item.sumPerson,
                        unitPrice = item.unitPrice
                    });
            }
            return lst;
        }
    }
}
