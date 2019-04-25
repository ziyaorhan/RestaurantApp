using RestaurantZ.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantZ.Entities.Concrete
{
    public class Breakfast : ITable, IService,IEntity
    {
        [Key]
        public int BreakfastId { get; set; }     
        //ITable'dan geliyor tüm tablolar için zorunlu.
        [Required]
        public string SyncId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        //IService
        [Required]
        public ushort NumberOfPerson { get; set; }
        public decimal ExtraPrice { get; set; }// not: default 0 durumuna bakılacak.
        [MaxLength(250)]
        public string Description { get; set; }
        //Her kahvaltı girişi için müşteri ve işlemi yapan personel belirli olmalı
        [Required]
        public virtual Customer Customer { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}
