using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules.FluentValidation;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Abstract;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Concrete
{
    class BreakfastManager : IBreakfastService
    {
        private IBreakfastDal _breakfastDal;

        public BreakfastManager(IBreakfastDal breakfastDal)
        {
            _breakfastDal = breakfastDal;
        }
        public void Add(Breakfast breakfast)
        {
            ValidationTool.Validate(new IServiceValidator(), breakfast);
            _breakfastDal.Add(breakfast);
        }

        public void Delete(Breakfast breakfast)
        {
            _breakfastDal.Delete(breakfast);
        }

        public Breakfast Get(int id)
        {
            return _breakfastDal.Get(b => b.BreakfastId == id);
        }

        public List<Breakfast> GetAll()
        {
            return _breakfastDal.GetAll();
        }

        public void Update(Breakfast breakfast)
        {
            ValidationTool.Validate(new IServiceValidator(), breakfast);
            _breakfastDal.Update(breakfast);
        }
    }
}
