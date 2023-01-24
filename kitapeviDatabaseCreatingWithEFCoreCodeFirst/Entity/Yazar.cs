using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Yazar : Baseclass
    {
        public Yazar()
        {
            Kitaplar = new HashSet<Kitap>();
        }
        public bool? YazarKadınMi { get; set; }
        public string? YazarAcıklama { get; set; }
        public int UlkeID { get; set; }
        public Ulke Ulke { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
