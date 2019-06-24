﻿using RestaurantZ.Entities.Abstract;

namespace RestaurantZ.Entities.Concrete
{
    public class NightMale : BaseEntity, IService, IEntity
    {
        public int NightMaleId { get; set; }
        //IService
        public int NumberOfPerson { get; set; }
        public decimal ExtraPrice { get; set; }
        public string Description { get; set; }
        //
        public int UserId { get; set; }
        public User User { get; set; }
        //
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
