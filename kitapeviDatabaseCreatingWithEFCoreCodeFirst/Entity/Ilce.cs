using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Ilce : Baseclass
    {
        public Ilce()
        {
            Personeller = new HashSet<Personel>();
            Musteriler = new HashSet<Musteri>();
        }

        public Sehir Sehir { get; set; }
        public int SehirID { get; set; }
        public ICollection<Personel> Personeller { get; set; }
        public ICollection<Musteri> Musteriler { get; set; }
    }
}
