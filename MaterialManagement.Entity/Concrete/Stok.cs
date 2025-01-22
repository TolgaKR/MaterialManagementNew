using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Entity.Concrete
{
    public class Stok
    {
      
        public int Id { get; set; } // Birincil anahtar.

        
        public int MalzemeId { get; set; } // Stok hareketinin ilişkili olduğu malzeme.

        public Malzeme Malzeme { get; set; } // Malzeme tablosu ile ilişki.

        
        public string IslemTipi { get; set; } // İşlem tipi: giriş veya çıkış.

        
        public decimal Miktar { get; set; } // İşlem miktarı.

        public DateTime Tarih { get; set; } // İşlem tarihi.

        public string Aciklama { get; set; } // İşlemle ilgili açıklama.


        
    }
}


