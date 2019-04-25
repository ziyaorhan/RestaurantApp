using RestaurantZ.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestaurantZ.Entities.Concrete
{
    //Bu tabloya doğrudan erişim yoktur. Customer tablosunu tamamlar.(bire bir ilişki var.)
   public class CustomerService:ITable
    {
        [ForeignKey("Customer")]
        public int CustomerServiceId { get; set; }
        [Required]
        public bool HaveBreakfast { get; set; }
        public decimal BreakfastPrice { get; set; }
        [Required]
        public bool HaveLunch { get; set; }
        public decimal LunchPrice { get; set; }
        [Required]
        public bool HaveDinner { get; set; }
        public decimal DinnerPrice { get; set; }
        [Required]
        public bool HaveNightMale { get; set; }
        public decimal NightMalePrice { get; set; }
        [Required]
        public string SyncId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public Customer Customer { get; set; }
    }
}
