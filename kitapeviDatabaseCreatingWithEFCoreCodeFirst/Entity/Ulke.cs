using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Ulke : Baseclass
    {
        public Ulke()
        {
            Sehirler = new HashSet<Sehir>();
            Personeller = new HashSet<Personel>();
            Musteriler = new HashSet<Musteri>();
            Yazarlar = new HashSet<Yazar>();
        }

        public ICollection<Sehir>? Sehirler { get; set; }
        public ICollection<Personel>? Personeller { get; set; }
        public ICollection<Yazar>? Yazarlar { get; set; }
        public ICollection<Musteri>? Musteriler { get; set; }

    }
}
