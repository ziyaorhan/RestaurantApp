using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;

namespace RestaurantZ.DataAccess.Concrete.EntityFramework
{
    public class EfLunchDal : EfEntityRepositoryBase<Lunch, EfRestaurantContext>, ILunchDal
    {

    }
}
