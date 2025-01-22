using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Entity.Concrete
{
    public class Fiyat
    {
       
        public int FiyatId { get; set; } // Birincil anahtar

        
       
        public ICollection< Malzeme> Malzemes { get; set; } // Malzeme tablosu ile ilişki.

        public decimal MalzemeFiyat { get; set; } // Malzemenin fiyatı.
    
        public DateTime BaslangicTarihi { get; set; } // Fiyatın geçerli olmaya başladığı tarih.

        public DateTime? BitisTarihi { get; set; } // Fiyatın geçerliliği sona erdiği tarih (Opsiyonel).

       
        public string Aciklama { get; set; } // Fiyatla ilgili açıklama.

        
        public bool Aktif { get; set; } // Fiyatın aktif olup olmadığını belirten alan.
    }
}
