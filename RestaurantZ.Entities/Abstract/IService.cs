using RestaurantZ.Entities.Concrete;


namespace RestaurantZ.Entities.Abstract
{
    //Businesstaki Service'ten farklı anlam taşımaktadır. Restoranda 4 farklı kategoride hizmet verilmektedir: kahvaltı, öğlen, akşam ve gece yemekleri. tüm bu classlara implemente edildi.
    public interface IService
    {
        ushort NumberOfPerson { get; set; }
        decimal ExtraPrice { get; set; }
        string Description { get; set; }
        Customer Customer { get; set; }
        User User { get; set; }
    }
}
