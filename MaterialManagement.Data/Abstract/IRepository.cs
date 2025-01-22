using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Data.Abstract
{
    public interface IRepository<T> where T: class
    {
        List<T> List();//Bu veri tabanındaki tüm kayıtları döner filtreleme yapmaz.
        T Get(Expression<Func<T, bool>> filter); //filter sayesinde LINQ kullanarak kriter belirtebilirsin. Belirli kriteri sağlayan tek kaydı döner.
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        List<T> List(Expression<Func<T, bool>> filter); //Belirli şarta uygun tüm kayıtları döner. Listeler şartlardan sonra geleni.

    }
}
