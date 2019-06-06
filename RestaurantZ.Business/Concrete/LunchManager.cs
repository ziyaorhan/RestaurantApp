using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules.FluentValidation;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;
using System.Collections.Generic;

namespace RestaurantZ.Business.Concrete
{
    public class LunchManager : ILunchService
    {
        private ILunchDal _lunchDal;

        public LunchManager(ILunchDal lunchDal)
        {
            _lunchDal = lunchDal;
        }
        public void Add(Lunch lunch)
        {
            ValidationTool.Validate(new IServiceValidator(), lunch);
            _lunchDal.Add(lunch);
        }

        public void Delete(Lunch lunch)
        {
            _lunchDal.Delete(lunch);
        }

        public Lunch Get(int id)
        {
            return _lunchDal.Get(l => l.LunchId == id);
        }

        public List<Lunch> GetAll()
        {
          return  _lunchDal.GetAll();
        }

        public void Update(Lunch lunch)
        {
            ValidationTool.Validate(new IServiceValidator(), lunch);
            _lunchDal.Update(lunch);
        }
    }
}
