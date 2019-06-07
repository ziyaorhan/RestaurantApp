using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules.FluentValidation;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Concrete
{
   public class NightMaleManager:INightMaleService
    {
        private INightMaleDal _nightMaleDal;

        public NightMaleManager(INightMaleDal nightMaleDal)
        {
            _nightMaleDal = nightMaleDal;
        }

        public void Add(NightMale nightMale)
        {
            ValidationTool.Validate(new IServiceValidator(), nightMale);
            _nightMaleDal.Add(nightMale);
        }

        public void Delete(NightMale nightMale)
        {
            _nightMaleDal.Delete(nightMale);
        }

        public NightMale Get(int id)
        {
            return _nightMaleDal.Get(n => n.NightMaleId == id);
        }

        public List<NightMale> GetAll()
        {
            return _nightMaleDal.GetAll();
        }

        public void Update(NightMale nightMale)
        {
            ValidationTool.Validate(new IServiceValidator(), nightMale);
            _nightMaleDal.Update(nightMale);
        }
    }
}
