using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialManagement.Entity.Concrete
{
    public class MalzemeGrup
    {


        
        public int Id { get; set; }

        
        public string GrupAdi { get; set; }

        public string Aciklama { get; set; }

        public ICollection<Malzeme> Malzemeler { get; set; }  //Bir grupta birden fazla malzeme oldugundan yazıyoruz.


    }
}
