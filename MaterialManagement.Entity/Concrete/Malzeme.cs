using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Entity.Concrete
{
    public class Malzeme
    {

        public int Id { get; set; } //pk


        public string MalzemeAdi { get; set; }


        public int MalzemeGrupId { get; set; }

        public MalzemeGrup MalzemeGrup { get; set; }

        public decimal StokMiktari { get; set; }

        public string Birim { get; set; }//madde birimi

        public decimal Price { get; set; }
        public string Aciklama { get; set; }

        public string Fotograf { get; set; }

        public int FiyatId { get; set; }
        public Fiyat Fiyat { get; set; }

        public ICollection<ReceteKalem> ReceteKalems { get; set; }

        public ICollection<Stok> Stoks { get; set; }

        public int UrunTipiTablosuId { get; set; }

        public UrunTipiTablosu UrunTipiTablosu { get; set; }


    }
}
