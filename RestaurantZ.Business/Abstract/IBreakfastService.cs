using RestaurantZ.Entities.Concrete;
using System.Collections.Generic;

namespace RestaurantZ.Business.Abstract
{
    public interface IBreakfastService
    {
        void Add(Breakfast breakfast);
        void Update(Breakfast breakfast);
        Breakfast Get(int id);
        List<Breakfast> GetAll();
        void Delete(Breakfast breakfast);
    }
}
