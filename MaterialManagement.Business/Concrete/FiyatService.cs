using MaterialManagement.Business.Abstract;
using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Concrete
{
    public class FiyatService : IFiyatService
    {

        private readonly IFiyatService _fiyatService;

        public FiyatService(IFiyatService fiyatService) //DInjection
        {
            _fiyatService = fiyatService;
        }

        public async Task AddFiyatIdAsync(Fiyat fiyat)
        {
            await _fiyatService.AddFiyatIdAsync(fiyat);
        }

        public async Task DeleteFiyatAsync(int fiyatId)
        {
            await _fiyatService.DeleteFiyatAsync(fiyatId);
        }

        public async Task<List<Fiyat>> GetAllFiyatAsync()
        {
            return await _fiyatService.GetAllFiyatAsync();
        }

        public async Task<Fiyat> GetByFiyatIdAsync(int fiyatId)
        {
            return await _fiyatService.GetByFiyatIdAsync(fiyatId);
        }

        public async Task UpdateFiyatAsync(Fiyat fiyat)
        {
            await _fiyatService.UpdateFiyatAsync(fiyat);
        }
    }
}
