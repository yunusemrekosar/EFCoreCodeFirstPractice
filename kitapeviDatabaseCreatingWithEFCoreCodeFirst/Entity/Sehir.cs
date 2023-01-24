using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Sehir;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Sehir : Baseclass
    {
        public Sehir()
        {
            Personeller = new HashSet<Personel>();
            Musteriler = new HashSet<Musteri>();
            Ilceler = new HashSet<Ilce>();
        }

        public Ulke Ulke { get; set; }

        public int UlkeID { get; set; }
        public ICollection<Ilce> Ilceler { get; set; }
        public ICollection<Personel>? Personeller { get; set; }
        public ICollection<Musteri>? Musteriler { get; set; }
    }
}
