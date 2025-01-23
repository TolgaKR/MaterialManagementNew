using MaterialManagement.Business.Abstract;
using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Concrete
{
    public class MalzemeService : IMalzemeService
    {
        private readonly IMalzemeService _malzemeService;
        
        public MalzemeService(IMalzemeService malzemeService)
        {
            _malzemeService = malzemeService;
        }

        public async Task AddMalzemeAsync(Malzeme malzeme)
        {
              if(malzeme == null)
            {                
                throw new ArgumentNullException(nameof(malzeme),"Malzeme nesnesi boş olamaz.");
            } //Eklemede Malzeme Nesnesi kontrolü
            
            await _malzemeService.AddMalzemeAsync(malzeme);
        }

        public async Task DeleteMalzemeAsync(int malzemeId)
        {
            await _malzemeService.DeleteMalzemeAsync(malzemeId);
        }

        public async Task<List<Malzeme>> GetAllMalzemeAsync()
        {
            return await _malzemeService.GetAllMalzemeAsync();    
        }

        public async Task<Malzeme> GetByMalzemeIdAsync(int malzemeId)
        {
            return await _malzemeService.GetByMalzemeIdAsync(malzemeId);
        }

        public async Task UpdateMalzemeAsync(Malzeme malzeme)
        {
            await _malzemeService.UpdateMalzemeAsync(malzeme);
        }
    }
}
