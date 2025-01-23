using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Abstract
{
    public interface IUrunTipiTablosuService
    {

        Task<List<UrunTipiTablosu>> GetAllUrunTablsouAsync();
        Task<UrunTipiTablosu> GetByUrunTipiTablosuId();

        Task AddUrunTipiTablosuAsync(UrunTipiTablosu urunTipiTablosu);
        Task UpdateUrunTipiTablosuAsync(UrunTipiTablosu urunTipiTablosu);
        Task DeleteUrunTipiTablosuAsync(int urunTipiTablosuId);


    }
}
