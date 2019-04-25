using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.DataAccess.Concrete.EntityFramework
{
   public class EfRestaurantContext : DbContext
    {

        public EfRestaurantContext() : base("name=RestaurantZConnStr")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerService> CustomerServices { get; set; }
        public DbSet<Breakfast> Breakfasts { get; set; }
        public DbSet<Lunch> Lunch { get; set; }
        public DbSet<Dinner> Dinners { get; set; }
        public DbSet<NightMale> NightMales { get; set; }
    }
}
