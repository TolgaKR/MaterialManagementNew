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
    public class EfReceteKalemRepo : GenericRepository<ReceteKalem>, IReceteKalemDal
    {
        public EfReceteKalemRepo(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
