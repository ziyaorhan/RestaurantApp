
namespace RestaurantZ.Entities.Concrete
{
    public class ModelForGroupedReport
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string serviceName { get; set; }
        public decimal unitPrice { get; set; }
        public int sumPerson { get; set; }
        public decimal sumExtraPrice { get; set; }
        public decimal grandTotal { get; set; }
        public string dateRange { get; set; }
    }
}
