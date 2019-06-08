using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Entities.Concrete
{
   public class ModelForAllServices
    {
        public int NumberOfPerson { get; set; }
        public decimal ExtraPrice { get; set; }
        public string Description { get; set; }
        public string ServiceName { get; set; }
        public int CustomerId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
