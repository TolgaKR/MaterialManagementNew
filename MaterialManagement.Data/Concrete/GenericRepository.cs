using MaterialManagement.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Data.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

     
        private readonly AppDbContext _appDbContext;   // AppDbContext nesnesi için Dependency Injection kullanıldı.
        private readonly DbSet<T> _dbSet;

        // Constructor
        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();
        }
        public void Delete(T entity) //Tamamlandı
        {
            var deletedEntity = _appDbContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _appDbContext.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _dbSet.FirstOrDefault(filter);
            //Bir dizide veya listede bir tane değer döndüren komuttur.
        }

        public void Insert(T entity) //Tamamlandı
        {
        //    _dbSet.Add(entity);
        //    _appDbContext.SaveChanges();
        //    
        
            var addedEntity = _appDbContext.Entry(entity);
            addedEntity.State=EntityState.Added;
            _appDbContext.SaveChanges();

        }

        public List<T> List() //Tamamlandı
        {
            return _dbSet.ToList<T>();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).ToList(); //Filtreleme
        }

        public void Update(T entity) //Tamamlandı.
        {
           var updateEntity=_appDbContext.Entry(entity);
           updateEntity.State=EntityState.Modified; 
           _appDbContext.SaveChanges();
        }
    }
}
