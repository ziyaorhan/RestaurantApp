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
    class BreakfastManager : IBreakfastService
    {
        private IBreakfastDal _breakfastDal;
        public BreakfastManager(IBreakfastDal breakfastDal)
        {
            _breakfastDal = breakfastDal;
        }
        public bool Add(Breakfast breakfast)
        {
            _breakfastDal.Add(breakfast);
            return true;
        }
    }
}
