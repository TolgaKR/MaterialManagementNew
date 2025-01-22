using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Entity.Concrete
{
    public class ReceteKalem
    {
        [Key]
        public int Id { get; set; }

        
        public int ReceteBaslikId { get; set; }
        public ReceteBaslik ReceteBaslik { get; set; } 
        public int MalzemeId { get; set; }
        public Malzeme Malzeme { get; set; } 

        public decimal Miktar { get; set; } 

        [Required, MaxLength(50)]
        public string Birim { get; set; } 




    }
}
