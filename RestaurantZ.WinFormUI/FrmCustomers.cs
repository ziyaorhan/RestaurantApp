using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.DependencyResolvers.Ninject;
using RestaurantZ.DataAccess.Concrete.EntityFramework;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantZ.WinFormUI
{
    public partial class FrmCustomers : Form
    {
        private ICustomerService _customerService;
        private IUserService _userService;

        public FrmCustomers()
        {
            InitializeComponent();
            _customerService= InstanceFactory.GetInstance<ICustomerService>();
            _userService= InstanceFactory.GetInstance<IUserService>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            btnNewCustomer.Image = Image.FromFile(Global.GetPath("\\Images\\add.png"));
            dgvCustomers.DataSource = _customerService.GetAll();
            //using (EfRestaurantContext context = new EfRestaurantContext())
            //{
            //    try
            //    {
            //        CustomerService customerService = new CustomerService()
            //        {
            //            HaveBreakfast = true,
            //            BreakfastPrice = 10,
            //            HaveLunch = true,
            //            LunchPrice = 15,
            //            HaveDinner = true,
            //            DinnerPrice = 12,
            //            HaveNightMale = true,
            //            NightMalePrice = 17,
            //            SyncId = "kjhkjhjkhjkhjhk337389678",
            //            TransactionDate = DateTime.Now,
            //        };
            //        context.CustomerServices.Add(customerService);

            //        Customer customer = new Customer()
            //        {
            //            CustomerName = "Abc Firması",
            //            CustomerRepresentative = "Felan Bey",
            //            Phone1 = "2123443435",
            //            Phone2 = "2163456789",
            //            Address = "Tuzla Sanayi",
            //            Notes = "Bu firma ödemeleri her ayın 24'ünde yapıyor.",
            //            CustomerService = customerService,
            //            SyncId = "kjhkjhjkhjkhjhk337389678",
            //            IsActive = true,
            //            TransactionDate = DateTime.Now,

            //        };
            //        context.Customers.Add(customer);
            //        context.SaveChanges();
            //    }
            //    catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            //    {
            //        Exception raise = dbEx;
            //        foreach (var validationErrors in dbEx.EntityValidationErrors)
            //        {
            //            foreach (var validationError in validationErrors.ValidationErrors)
            //            {
            //                string message = string.Format("{0}:{1}",
            //                    validationErrors.Entry.Entity.ToString(),
            //                    validationError.ErrorMessage);
            //                // raise a new exception nesting
            //                // the current instance as InnerException
            //                raise = new InvalidOperationException(message, raise);
            //            }
            //        }
            //        throw raise;
            //    }

            //}

            using (EfRestaurantContext context = new EfRestaurantContext())
            {
                //var data= from i in context.Customers join j in context.CustomerServices on i.CustomerId equals j.CustomerServiceId select new {MüsteriNo= i.CustomerId, i.CustomerName, i.CustomerRepresentative, i.Phone1, j.BreakfastPrice, j.LunchPrice, j.DinnerPrice, j.NightMalePrice };
                //dgvCustomers.DataSource = data.ToList();

            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            FrmNewCustomer frmNewCustomer = new FrmNewCustomer();
            frmNewCustomer.ShowDialog();
        }
    }
}
