using MaterialManagement.Data.Abstract;
using MaterialManagement.Data.Concrete;
using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Data.EntityFramework
{
    public class EfFiyatRepo : GenericRepository<Fiyat>, IFiyatDal
    {
        public EfFiyatRepo(AppDbContext appDbContext) : base(appDbContext) //Generete Const.
        {

        }
    }
}
