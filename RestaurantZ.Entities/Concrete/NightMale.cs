using RestaurantZ.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantZ.Entities.Concrete
{
    public class NightMale : BaseEntity, IService,IEntity
    {
        public int NightMaleId { get; set; }
        //IService
        public ushort NumberOfPerson { get; set; }
        public decimal ExtraPrice { get; set; }
        public string Description { get; set; }
        //
        //[ForeignKey("Customer")]
        public Customer Customer { get; set; }
    }
}
