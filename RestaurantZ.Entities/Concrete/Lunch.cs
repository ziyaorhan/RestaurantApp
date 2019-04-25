using RestaurantZ.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantZ.Entities.Concrete
{
   public class Lunch:ITable,IService,IEntity
    {
        [Key]
        public int LunchId { get; set; }
        //ITable
        [Required]
        public string SyncId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        //IService
        [Required]
        public ushort NumberOfPerson { get; set; }
        public decimal ExtraPrice { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public virtual Customer Customer { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}
