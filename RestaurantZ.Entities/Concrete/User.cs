using RestaurantZ.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace RestaurantZ.Entities.Concrete
{
   public class User:BaseEntity,IEntity
    {
        public User()
        {
            this.Breakfasts = new HashSet<Breakfast>();
            this.Lunches = new HashSet<Lunch>();
            this.Dinners = new HashSet<Dinner>();
            this.NightMales = new HashSet<NightMale>();
            this.Customers = new HashSet<Customer>();
        }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
        //
        public ICollection<Breakfast> Breakfasts { get; set; }
        public ICollection<Lunch> Lunches { get; set; }
        public ICollection<Dinner> Dinners { get; set; }
        public ICollection<NightMale> NightMales { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
