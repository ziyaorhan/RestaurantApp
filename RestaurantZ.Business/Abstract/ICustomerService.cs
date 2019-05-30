using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Abstract
{
   public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        Customer Get(int id);
        List<Customer> GetAll();
        void Delete(Customer customer);
        List<Customer> GetAllByCustomerName(string customerName);
        List<Customer> GetPassiveCustomers();
    }
}
