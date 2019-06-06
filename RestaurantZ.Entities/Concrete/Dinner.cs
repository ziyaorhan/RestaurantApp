using RestaurantZ.Entities.Abstract;

namespace RestaurantZ.Entities.Concrete
{
    public class Dinner : BaseEntity, IService, IEntity
    {
        public int DinnerId { get; set; }
        //IService
        public int NumberOfPerson { get; set; }
        public decimal ExtraPrice { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
