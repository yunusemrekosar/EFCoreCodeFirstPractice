using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Yayınevi : Baseclass
    {
        public Yayınevi()
        {
            Kitaplar = new HashSet<Kitap>();
        } 

        [MaxLength(400)]
        public string? YayıneviAdres { get; set; }
        [MaxLength(11)]
        public string? YayıneviTelefon { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }

    }
}
