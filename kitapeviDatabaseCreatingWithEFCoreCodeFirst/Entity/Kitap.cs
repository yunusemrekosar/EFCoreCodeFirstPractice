using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Kitap : Baseclass
    {
        public Kitap()
        {
            Yazarlar = new HashSet<Yazar>();
            Kategoriler = new HashSet<Kategori>();
            Musteriler = new HashSet<Musteri>();
        }

        public string? KitapBasimTarihi { get; set; }
        public decimal KitapFiyatı { get; set; }
        public int KitapSayfaSayısı { get; set; }
        public int KitapStok { get; set; }
        public string? KitapISBN { get; set; }
        public int YazarID { get; set; }
        public int YayineviID { get; set; }
        public ICollection<Yazar> Yazarlar { get; set; }
        public ICollection<Kategori> Kategoriler { get; set; }
        public Yayınevi? Yayınevi { get; set; }
        public ICollection<Musteri> Musteriler { get; set; }
    }
}
