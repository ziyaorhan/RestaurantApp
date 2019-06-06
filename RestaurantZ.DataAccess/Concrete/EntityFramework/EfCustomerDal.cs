using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;

namespace RestaurantZ.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, EfRestaurantContext>, ICustomerDal
    {
    }
}
