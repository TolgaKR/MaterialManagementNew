using MaterialManagement.Business.Abstract;
using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Concrete
{
    public class ReceteKalemService : IReceteKalemService
    {
        private readonly IReceteKalemService _receteKalemService;

        public ReceteKalemService(IReceteKalemService receteKalemService) //DInjection
        {
            _receteKalemService = receteKalemService;
        }


        public async Task AddReceteKalemAsync(ReceteKalem receteKalem)
        {
            if(receteKalem== null)
            {
                throw new ArgumentNullException(nameof(receteKalem),"receteKalem nesnesi boş geçemez.");
            }
            await _receteKalemService.AddReceteKalemAsync(receteKalem);
        }

        public async Task DeleteReceteKalemAsync(int receteKalemId)
        {
            await _receteKalemService.DeleteReceteKalemAsync(receteKalemId);
        }

        public async Task<List<ReceteKalem>> GetAllReceteKalemAsync()
        {
            return await _receteKalemService.GetAllReceteKalemAsync();
        }

        public async Task<ReceteKalem> GetByReceteKalemIdAsync(int receteKalemId)
        {
            return await   _receteKalemService.GetByReceteKalemIdAsync(receteKalemId);
        }

        public async Task UpdateReceteKalemAsync(ReceteKalem receteKalem)
        {
         await _receteKalemService.UpdateReceteKalemAsync(receteKalem);
        }
    }
}
