using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Utilities;
using RestaurantZ.Business.ValidationRules.FluentValidation;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.DataAccess.Concrete.EntityFramework;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(new EfCustomerDal(), customer), customer);
            try
            {
                _customerDal.Add(customer);
            }
            catch
            {
                throw new Exception("Yeni bir müşteri eklenirken hata oluştu.");
            }
        }

        public void Delete(Customer customer)
        {
            try
            {
                _customerDal.Delete(customer);
            }
            catch
            {
                throw new Exception("Müşteri silinirken bir hata oluştu.");
            }
        }

        public Customer Get(int id)
        {
            Customer customer = new Customer();
            try
            {
                customer = _customerDal.Get(a => a.CustomerId == id);
            }
            catch (System.NullReferenceException)
            {
                customer = null;
            }
            catch
            {
                throw new Exception("Id'ye göre müşteri getirilirken bir hata oluştu.");
            }
            return customer;
        }

        public List<Customer> GetAll()
        {
            try
            {
                return _customerDal.GetAll();
            }
            catch
            {

                throw new Exception("Müşteriler listelenirken bir hata oluştu.");
            }
        }

        public List<Customer> GetAllByCustomerName(string customerName)
        {
            return _customerDal.GetAll(c => c.CustomerName.ToLower().Contains(customerName.ToLower()));
        }

        public List<Customer> GetAllRcvBrkfstByCstmrName(string customerName)
        {
            return _customerDal.GetAll(c => c.BreakfastPrice > 0 && c.CustomerName.ToLower().Contains(customerName.ToLower()));
        }

        public List<Customer> GetAllActiveAndReceivingBreakfast()
        {
            return _customerDal.GetAll(c => c.BreakfastPrice > 0 && c.IsActive == true);
        }

        public List<Customer> GetPassiveCustomers()
        {
            return _customerDal.GetAll(c => c.IsActive == false);
        }

        public void Update(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(new EfCustomerDal(), customer), customer);
            try
            {
                _customerDal.Update(customer);
            }
            catch
            {
                throw new Exception("Müşteri güncellenirken bir hata oluştu.");
            }
        }

        public object GetAllForDgv()
        {
            var customers = _customerDal.GetAll();
            var result = customers.Select(c => new { c.CustomerId, c.CustomerName, c.BreakfastPrice, c.LunchPrice, c.DinnerPrice, c.NightMalePrice, c.IsActive }).ToList();
            return result;
        }
    }
}
