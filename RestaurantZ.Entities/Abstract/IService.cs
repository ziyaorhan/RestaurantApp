using RestaurantZ.Entities.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantZ.Entities.Abstract
{
    //Businesstaki Service'ten farklı anlam taşımaktadır. Restoranda 4 farklı kategoride hizmet verilmektedir: kahvaltı, öğlen, akşam ve gece yemekleri. tüm bu classlara implemente edildi.
    public interface IService
    {
        int NumberOfPerson { get; set; }
        decimal ExtraPrice { get; set; }
        string Description { get; set; }
        int CustomerId { get; set; }
        Customer Customer { get; set; }
    }
}
