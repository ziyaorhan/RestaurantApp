﻿using RestaurantZ.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantZ.Entities.Concrete
{
   public class Lunch:BaseEntity,IService,IEntity
    {
        public int LunchId { get; set; }
        //IService
        public int NumberOfPerson { get; set; }
        public decimal ExtraPrice { get; set; }
        public string Description { get; set; }
        //
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
