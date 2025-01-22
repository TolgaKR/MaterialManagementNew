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
    public class EfMalzemeRepo : GenericRepository<Malzeme>, IMalzemeDal
    {
        public EfMalzemeRepo(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
