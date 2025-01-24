using MaterialManagement.Business.Abstract;
using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Concrete
{
    public class StokService : IStokService
    {

        private readonly IStokService _stokService;

        public StokService(IStokService stokService) //DInjection
        {
            _stokService = stokService;
        }

        public async Task AddStokAsync(Stok stok)
        {
            if(stok == null)
            {
                throw new ArgumentNullException(nameof(stok),"Stok nesnesi boş olmamalı");
            }   
            await _stokService.AddStokAsync(stok);
        }

        public async Task DeleteStokAsync(int stokId)
        {
            await _stokService.DeleteStokAsync(stokId);
        }

        public Task<List<Stok>> GetAllStokAsync()
        {
            return _stokService.GetAllStokAsync();
        }

        public async Task<Stok> GetByStokIdAsync(int stokId)
        {
           return await _stokService.GetByStokIdAsync(stokId);
        }

        public async Task UpdateStokAsync(Stok stok)
        {
            await _stokService.UpdateStokAsync(stok);
        }
    }
}
