using System;

namespace RestaurantZ.Entities.Concrete
{
    public class MainFormDgv
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string CustomerName { get; set; }
        public int NumberOfPerson { get; set; }
        public decimal ExtraPrice { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string NameSurname { get; set; }
    }
}
