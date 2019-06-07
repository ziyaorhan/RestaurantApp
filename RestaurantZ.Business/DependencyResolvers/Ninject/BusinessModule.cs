using Ninject.Modules;
using RestaurantZ.Business.Abstract;
using RestaurantZ.Business.Concrete;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.DataAccess.Concrete.EntityFramework;

namespace RestaurantZ.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            //UI(burada windows form) içerisindeki dependency(bağımlılık) durumunu yani new'leyerek tabakaların birbirine bağımlı olması durumunu ortadan kaldırmak için oluşturuldu.
            //Eğer soyut bir IUserService istenirse somut bir UserManager oluştur ve dönder.
            // Bind<SoyutNesne>().To<DönüştürülecekSomutNesne>().InSingletonScope()(nesneyi bir defa üretir ve performansı arttırır.)
            Bind<IUserService>().To<UserManager>().InSingletonScope();//İleride servis odaklı bir mimariye geçilirse değiştirilmesi gereken yer UserManager olacaktır.
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();//İleride NHibernate gibi bir ORM ile çalışılacaksa değiştirilecek yer EfUserDal olacaktır.
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();

            Bind<IBreakfastDal>().To<EfBreakfastDal>().InSingletonScope();
            Bind<IBreakfastService>().To<BreakfastManager>().InSingletonScope();
            //
            Bind<IJoinService>().To<JoinManager>().InSingletonScope();
            //
            Bind<ILunchService>().To<LunchManager>().InSingletonScope();
            Bind<ILunchDal>().To<EfLunchDal>().InSingletonScope();
            //
            Bind<IDinnerService>().To<DinnerManager>().InSingletonScope();
            Bind<IDinnerDal>().To<EfDinnerDal>().InSingletonScope();
            //
            Bind<INightMaleService>().To<NightMaleManager>().InSingletonScope();
            Bind<INightMaleDal>().To<EfNightMaleDal>().InSingletonScope();
        }
    }
}
