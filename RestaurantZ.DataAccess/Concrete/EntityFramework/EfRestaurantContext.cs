using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.DataAccess.Concrete.EntityFramework
{
    public class EfRestaurantContext : DbContext
    {
        public EfRestaurantContext() : base("name=RestaurantZConnStr")
        {
            Database.SetInitializer<EfRestaurantContext>(new CustomDBInitializer());
        }
        public class CustomDBInitializer : CreateDatabaseIfNotExists<EfRestaurantContext>
        {
            //Db oluşturulurken ilk verileri de oluştur.
            protected override void Seed(EfRestaurantContext context)
            {
                User user = new User()
                {
                    Name = "admin",
                    Surname = "admin",
                    Phone = "(505) 666-5308",
                    Mail = "zy.orhan@gmail.com",
                    UserName = "admin",
                    Password = "kevserkebap",
                    Role = "Manager",
                    IsActive = true,
                    IsVisible = true
                };
                context.Users.Add(user);
                //
                Customer customer = new Customer()
                {
                    CustomerName = "Kayıtsız Müşteri",
                    CustomerRepresentative = "Abdullah Şahin",
                    Phone1 = "(111) 111-1111",
                    Notes = "Herhangi bir hesabı olmayan, dışarıdan gelen müşteri tutarları kayıt altına alınmak istenirse bu seçenek seçilmelidir.",
                    IsActive = true,
                    IsVisible = true
                };
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Breakfast> Breakfasts { get; set; }
        public DbSet<Lunch> Lunch { get; set; }
        public DbSet<Dinner> Dinners { get; set; }
        public DbSet<NightMale> NightMales { get; set; }

        //"değişiklikleri kaydet" metodu ovveride edilerek; zaman damgası ekleme işlemi ve senkronizasyon için gerekli syncid ve issync özelliklerine değer atama işi otomatize edildi.
        public override int SaveChanges()
        {
            AddTimestamps();
            AddSyncProperties();
            //SaveChances(); yapmadan önce yukarıdaki işlemleri yap.
            return base.SaveChanges();
        }
        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentUserId = LoginInfo.CurrentUserId != 0
                ? LoginInfo.CurrentUserId
                : 0;

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedDate = DateTime.Now;
                    ((BaseEntity)entity.Entity).CreatedUserId = currentUserId;
                }
                ((BaseEntity)entity.Entity).ModifiedDate = DateTime.Now;
                ((BaseEntity)entity.Entity).ModifiedUserId = currentUserId;
            }
        }
        private void AddSyncProperties()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && x.State == EntityState.Added);

            string guidForSync = Guid.NewGuid().ToString();
            bool isSync = false;

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).SyncId = guidForSync;
                    ((BaseEntity)entity.Entity).IsSync = isSync;
                }
            }
        }
    }
}
