using RestaurantZ.Entities.Concrete;
using System.Collections.Generic;

namespace RestaurantZ.Business.Abstract
{
    public interface INightMaleService
    {
        void Add(NightMale nightMale);
        void Update(NightMale nightMale);
        NightMale Get(int id);
        List<NightMale> GetAll();
        void Delete(NightMale nightMale);
    }
}
