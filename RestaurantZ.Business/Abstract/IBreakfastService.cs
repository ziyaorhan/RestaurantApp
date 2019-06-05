using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
