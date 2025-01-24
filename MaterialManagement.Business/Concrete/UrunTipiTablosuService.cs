using MaterialManagement.Business.Abstract;
using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Concrete
{
    public class UrunTipiTablosuService : IUrunTipiTablosuService
    {
        private readonly IUrunTipiTablosuService _urunTipiTablosu;

        public UrunTipiTablosuService(IUrunTipiTablosuService urunTipiTablosu)
        {
            _urunTipiTablosu = urunTipiTablosu;
        }


        public async Task AddUrunTipiTablosuAsync(UrunTipiTablosu urunTipiTablosu)
        {
            if (urunTipiTablosu == null)
            {
                throw new ArgumentNullException(nameof(urunTipiTablosu), "UrunTipiTablosu nesnesi null olamaz.");
            }

            await _urunTipiTablosu.AddUrunTipiTablosuAsync(urunTipiTablosu);
        }


        public async Task DeleteUrunTipiTablosuAsync(int urunTipiTablosuId)
        {
            await _urunTipiTablosu.DeleteUrunTipiTablosuAsync(urunTipiTablosuId);
        }

        public async Task<List<UrunTipiTablosu>> GetAllUrunTablsouAsync()
        {
            return await _urunTipiTablosu.GetAllUrunTablsouAsync();
        }

        public async Task<UrunTipiTablosu> GetByUrunTipiTablosuId()
        {
            return await _urunTipiTablosu.GetByUrunTipiTablosuId();
        }

        public async Task UpdateUrunTipiTablosuAsync(UrunTipiTablosu urunTipiTablosu)
        {
           await _urunTipiTablosu.UpdateUrunTipiTablosuAsync(urunTipiTablosu);
        }
    }
}
