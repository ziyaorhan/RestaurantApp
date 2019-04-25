using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RestaurantZ.Entities.Abstract;
namespace RestaurantZ.DataAccess.Abstract
{
    //generic interface verilen tipe göre imzaları oluştruyor.
    //bu interface'in amacı I...Dal şeklindeki diğer interface lere ortak imza oluşturmaktır. dolayısı ile bu interface doğrudan classlara uygulanmaz. 
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
