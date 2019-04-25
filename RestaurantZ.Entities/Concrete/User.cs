using RestaurantZ.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Entities.Concrete
{
   public class User:ITable,IEntity
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(25)]
        [Required]
        public string Name { get; set; }
        [MaxLength(25)]
        [Required]
        public string Surname { get; set; }
        [MaxLength(20)]
        [Required]
        public string Phone { get; set; }
        [MaxLength(50)]
        [Required]
        public string Mail { get; set; }
        [MaxLength(20)]
        [Required]
        public string UserName { get; set; }
        [MinLength(6)]
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public bool IsActive { get; set; }
        //ITable'dan geliyor tüm tablolar için zorunlu.
        [Required]
        public string SyncId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; } 
        //Bir kullanıcının aşağıdaki tablolarda birden çok işlemi olabilir.
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Breakfast> Breakfasts { get; set; }
        public virtual ICollection<Lunch> Lunchs { get; set; }
        public virtual ICollection<Dinner> Dinners { get; set; }
        public virtual ICollection<NightMale> NigtMales { get; set; }
    }
}
