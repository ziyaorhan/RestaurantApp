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
                    Name = "Admin",
                    Surname = "Admin",
                    Phone = "(505) 666-5308",
                    Mail = "zy.orhan@gmail.com",
                    UserName = "admin",
                    Password = "0e282527abe49e04f3b6abfde22d4a04145bdbd4f0131b0a2b77fd2f051b18fbaa5455999a50152e73db5531a74bf00ddd8d5a07b0c8f73ef103382a69a787d8",
                    Role = "Admin",
                    IsActive = true,
                    IsVisible = true
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



