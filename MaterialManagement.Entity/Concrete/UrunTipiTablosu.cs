using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Entity.Concrete
{
    public class UrunTipiTablosu
    {
        public int Id { get; set; } // Birincil anahtar.
        public string UrunAdi { get; set; } // Ürün tipinin adı (örneğin, Nihai Ürün, Yan Ürün, Hammadde).
        public  List<Malzeme> Malzemes { get; set; }

    }
}
