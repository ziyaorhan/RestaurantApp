using RestaurantZ.Entities.Abstract;
using System.Collections.Generic;

namespace RestaurantZ.Entities.Concrete
{
    public class Customer : BaseEntity, IEntity
    {
        public Customer()
        {
            this.Breakfasts = new HashSet<Breakfast>();
            this.Lunches = new HashSet<Lunch>();
            this.Dinners = new HashSet<Dinner>();
            this.NightMales = new HashSet<NightMale>();
        }

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

        public ICollection<Breakfast> Breakfasts { get; set; }
        public ICollection<Lunch> Lunches { get; set; }
        public ICollection<Dinner> Dinners { get; set; }
        public ICollection<NightMale> NightMales { get; set; }
    }
}
