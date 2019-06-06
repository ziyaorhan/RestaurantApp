using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;

namespace RestaurantZ.DataAccess.Concrete.EntityFramework
{
    //inheritence + implementation
    public class EfUserDal : EfEntityRepositoryBase<User, EfRestaurantContext>,IUserDal
    {
        //EfEntityRepositoryBase classından kalıtım aldığı için içi boş
    }
}
