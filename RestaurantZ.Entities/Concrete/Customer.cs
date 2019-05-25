using RestaurantZ.Entities.Abstract;
using System;

namespace RestaurantZ.Entities.Concrete
{
    public class Customer : BaseEntity,IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerRepresentative { get; set; }
        public string Phone1 { get; set; }
        public string Phone1Intercom { get; set; }
        public string Phone2 { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        //
        public decimal BreakfastPrice { get; set; }
        public decimal LunchPrice { get; set; }
        public decimal DinnerPrice { get; set; }
        public decimal NightMalePrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
    }
}
