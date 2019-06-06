using RestaurantZ.Entities.Concrete;

namespace RestaurantZ.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        //Buradaki IEntityRepository<User> implementasyonu,
        //IUserDal'ın uygulandığı yerde görülecektir.
    }
}
