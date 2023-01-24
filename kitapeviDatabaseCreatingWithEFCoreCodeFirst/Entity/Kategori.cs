using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Kategori : Baseclass
    {
        public Kategori()
        {
            Kitaplar = new HashSet<Kitap>();
        }
        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
