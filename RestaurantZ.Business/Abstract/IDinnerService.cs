using RestaurantZ.Entities.Concrete;
using System.Collections.Generic;

namespace RestaurantZ.Business.Abstract
{
    public interface IDinnerService
    {
        void Add(Dinner dinner);
        void Update(Dinner dinner);
        Dinner Get(int id);
        List<Dinner> GetAll();
        void Delete(Dinner dinner);
    }
}
