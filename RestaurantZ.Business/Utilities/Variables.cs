using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Utilities
{
    public static class Variables
    {
        public enum UserType
        {
            Employee = 0,
            Manager = 1,
            Admin=2
        }

        public static User CurrentUser { get; set; }
    }
}
