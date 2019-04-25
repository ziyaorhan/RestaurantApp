using RestaurantZ.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;


namespace RestaurantZ.Entities.Concrete
{
    public class Customer : ITable,IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(75)]
        public string CustomerName { get; set; }
        [MaxLength(50)]
        public string CustomerRepresentative { get; set; }
        [MaxLength(20)]
        public string Phone1 { get; set; }
        [MaxLength(20)]
        public string Phone2 { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        public string Notes { get; set; }
        [Required]
        public bool IsActive { get; set; }
        //ITable
        [Required]
        public string SyncId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        //Bire bir ilişki için, herbir müşterinin aldığı hizmetlerle ilgili satırı temsil eder.
        [Required]
        public virtual CustomerService CustomerService { get; set; }
       
    }
}
