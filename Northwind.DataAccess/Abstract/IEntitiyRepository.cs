using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntitiyRepository<T> where T : class, IEntity , new()
    {
        //burada genel isim verererk  tekrar tekrar yazmak kurtuluyoruz.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //bunun ilk defa görüyorsun bu yüzden kullanıcı istediğini yapabilir zorunlu değil
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
