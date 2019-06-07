using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules.FluentValidation;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;
using System.Collections.Generic;

namespace RestaurantZ.Business.Concrete
{
    class DinnerManager : IDinnerService
    {
        private IDinnerDal _dinnerDal;

        public DinnerManager(IDinnerDal dinnerDal)
        {
            _dinnerDal = dinnerDal;
        }

        public void Add(Dinner dinner)
        {
            ValidationTool.Validate(new IServiceValidator(), dinner);
            _dinnerDal.Add(dinner);
        }

        public void Delete(Dinner dinner)
        {
            _dinnerDal.Delete(dinner);
        }

        public Dinner Get(int id)
        {
           return _dinnerDal.Get(d => d.DinnerId == id);
        }

        public List<Dinner> GetAll()
        {
            return _dinnerDal.GetAll();
        }

        public void Update(Dinner dinner)
        {
            ValidationTool.Validate(new IServiceValidator(), dinner);
            _dinnerDal.Update(dinner);
        }
    }
}
