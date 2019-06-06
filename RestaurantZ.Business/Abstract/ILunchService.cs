using RestaurantZ.Entities.Concrete;
using System.Collections.Generic;

namespace RestaurantZ.Business.Abstract
{
  public  interface ILunchService
    {
        void Add(Lunch lunch);
        void Update(Lunch lunch);
        Lunch Get(int id);
        List<Lunch> GetAll();
        void Delete(Lunch lunch);
    }
}
