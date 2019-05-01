using Ninject;


namespace RestaurantZ.Business.DependencyResolvers.Ninject
{
   public class InstanceFactory
    {
        // GetInstance metodu ilgili formda çağrıldığı zaman BusinessModule içerisindeki ilgili Bind'lar çalıştırılır. Örneğin FrmNewUser'daki IUserService _userService; için;
        // Bind<IUserService>().To<UserManager>(); ve Bind<IUserDal>().To<EfUserDal>(); çalıştırılır.
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
