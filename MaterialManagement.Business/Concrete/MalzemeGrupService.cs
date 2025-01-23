using MaterialManagement.Business.Abstract;
using MaterialManagement.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Business.Concrete
{
    public class MalzemeGrupService : IMalzemeGrupService
    {
        private readonly IMalzemeGrupService _malzemeGrupService;

        public MalzemeGrupService(IMalzemeGrupService malzemeGrupService) //DInjection
        {
            _malzemeGrupService = malzemeGrupService;
        }


        public async Task AddMalzemeGrupAsync(MalzemeGrup malzemeGrup) //Ekleme işlemi
        {
            if(malzemeGrup==null)
            {
                throw new ArgumentNullException(nameof(malzemeGrup),"Malzeme Grup nesnesi null olamaz.");//malzemegrupid kontrol edilip hata durumunda mesaj dönüyor.
            }
            await _malzemeGrupService.AddMalzemeGrupAsync(malzemeGrup);
        }

        public async Task DeleteMalzemeGrupAsync(int malzemeGrupId)//Silme İşlemi
        {
            await _malzemeGrupService.DeleteMalzemeGrupAsync(malzemeGrupId);
        }

        public async Task<List<MalzemeGrup>> GetAllMalzemeGrupAsync()
        {
            return await _malzemeGrupService.GetAllMalzemeGrupAsync();
        }

        public async Task<MalzemeGrup> GetByMalzemeGrupIdAsync(int malzemeGrupId)//Id'ye göre getirme işlemi
        {
            return await _malzemeGrupService.GetByMalzemeGrupIdAsync(malzemeGrupId);
        }

        public async Task UpdateMalzemeGrupAsync(MalzemeGrup malzemeGrup) //Güncelleme işlemi
        {
            await _malzemeGrupService.UpdateMalzemeGrupAsync(malzemeGrup);
        }
    }
}
