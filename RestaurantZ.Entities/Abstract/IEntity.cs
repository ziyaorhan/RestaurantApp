//
namespace RestaurantZ.Entities.Abstract
{
    public interface IEntity
    {
        //DataAccess layerda IEntityRepository içinde generic classları filtrelemek için kullanıldı. Yani IEntity tipinde Class istemek için.
        //Entities.Concrete'te doğrudan işlem yapılacak(select,update,delete,...) tüm tablolara(class) implemente edildi.
    }
}
