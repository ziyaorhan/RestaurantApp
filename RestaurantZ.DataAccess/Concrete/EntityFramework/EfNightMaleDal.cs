using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;

namespace RestaurantZ.DataAccess.Concrete.EntityFramework
{
    public class EfNightMaleDal : EfEntityRepositoryBase<NightMale, EfRestaurantContext>, INightMaleDal
    {
    }
}
