using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        User Get(int id);
        List<User> GetAll();
        void Delete(User user);
        User GetByUserNameAndPwd(string enteredUserName, string enteredPwd);
        //void UpdateRoleAndActivityById(User user);
    }
}
