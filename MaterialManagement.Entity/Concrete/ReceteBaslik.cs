using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Entity.Concrete
{
    public class ReceteBaslik
    {
    
        public int Id { get; set; }

        
        public string ReceteAdi { get; set; }

        public string ReceteAciklama { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        public int VersiyonNo { get; set; }

          public ICollection<ReceteKalem> ReceteKalems { get; set;}

    }
}
