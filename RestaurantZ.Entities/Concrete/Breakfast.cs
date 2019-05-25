using RestaurantZ.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantZ.Entities.Concrete
{
    public class Breakfast : BaseEntity, IService,IEntity
    {
        public int BreakfastId { get; set; }     
        //IService
        public ushort NumberOfPerson { get; set; }
        public decimal ExtraPrice { get; set; }// not: default 0 durumuna bakılacak.
        public string Description { get; set; }
        //
        //[ForeignKey("Customer")]
        public Customer Customer { get; set; }
    }
}
