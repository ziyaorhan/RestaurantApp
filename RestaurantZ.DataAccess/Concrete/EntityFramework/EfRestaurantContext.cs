using RestaurantZ.Entities.Abstract;
using RestaurantZ.Entities.Concrete;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace RestaurantZ.DataAccess.Concrete.EntityFramework
{
    public class EfRestaurantContext : DbContext
    {
        public EfRestaurantContext() : base("name=RestaurantZConnStr")
        {
            Database.SetInitializer<EfRestaurantContext>(new CustomDBInitializer());
           // this.Configuration.LazyLoadingEnabled = false;
        }
        public class CustomDBInitializer : CreateDatabaseIfNotExists<EfRestaurantContext>
        {
            //Db oluşturulurken ilk verileri de oluştur.
            protected override void Seed(EfRestaurantContext context)
            {
                User user = new User()
                {
                    Name = "Developer",
                    Surname = "Developer",
                    Phone = "(505) 666-5308",
                    Mail = "zy.orhan@gmail.com",
                    UserName = "developer",
                    //kevserkebap34
                    Password = "5ff01e5c94cc72bb6a7a3b4016cb5b7f60819179fb01c9b371c1f2d484c8b79e36c7b7a0cb51fdf14272340bd6e599dddc040fa7ff365a4321022de57b1ecdcb",
                    Role = "Admin",
                    IsActive = true,
                    IsVisible = false
                };
                context.Users.Add(user);
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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //aşağıdaki işlemler bire çok ilişkili tablolarda veriyi siler fakat foreignKey değerini null atar, eğer true yapılırsa ilişkili tüm verileri siler.

            //modelBuilder.Entity<Breakfast>()
            //    .HasOptional<Customer>(s => s.Customer)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Lunch>()
            //    .HasOptional<Customer>(s => s.Customer)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Dinner>()
            //    .HasOptional<Customer>(s => s.Customer)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<NightMale>()
            //    .HasOptional<Customer>(s => s.Customer)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);

            //Aşağıdaki işlem bire çok ilişkili tablolarda silme işlemini yasaklayarak veri kaybını önler.
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

           // var currentUserId = LoginInfo.CurrentUserId != 0
               // ? LoginInfo.CurrentUserId
               // : 0;

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedDate = DateTime.Now;
                   // ((BaseEntity)entity.Entity).UserId = currentUserId;
                }
                ((BaseEntity)entity.Entity).ModifiedDate = DateTime.Now;
                //((BaseEntity)entity.Entity).ModifiedUserId = currentUserId;
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



