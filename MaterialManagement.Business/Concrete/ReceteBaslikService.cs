using MaterialManagement.Business.Abstract;
using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Concrete
{
    public class ReceteBaslikService : IReceteBaslikService
    {
        private readonly IReceteBaslikService _receteBaslikService;

        public ReceteBaslikService(IReceteBaslikService receteBaslikService)
        {
            _receteBaslikService = receteBaslikService;
        }


        public async Task AddReceteBaslikAsync(ReceteBaslik receteBaslik)
        {
            if(receteBaslik==null)
            {
                throw new ArgumentNullException(nameof(receteBaslik), "ReceteBaslik nesnesi null olamaz.");
            }
            await _receteBaslikService.AddReceteBaslikAsync(receteBaslik);
        }

        public async Task DeleteReceteBaslikAsync(int receteBaslikId)
        {
            await _receteBaslikService.DeleteReceteBaslikAsync(receteBaslikId);
        }

        public async Task<List<ReceteBaslik>> GetAllReceteBaslikAsync()
        {
            return await _receteBaslikService.GetAllReceteBaslikAsync();
        }

        public async Task<ReceteBaslik> GetByReceteBaslikIdAsync(int receteBaslikId)
        {
           return await _receteBaslikService.GetByReceteBaslikIdAsync(receteBaslikId);
        }

        public async Task UpdateReceteBaslikAsync(ReceteBaslik receteBaslik)
        {
            await _receteBaslikService.UpdateReceteBaslikAsync(receteBaslik);
        }
    }
}
