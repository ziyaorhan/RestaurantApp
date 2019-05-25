using RestaurantZ.Entities.Abstract;
using System;

namespace RestaurantZ.Entities.Concrete
{
   public class User:BaseEntity,IEntity
    {    
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
    }
}
