using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Musteri : Baseclass
    {
        public Musteri()
        {
            Kitaplar = new HashSet<Kitap>();
            Satıslar = new HashSet<Satıs>();

        }
        [MaxLength(11)]
        public string MusteriTelNu { get; set; }
        [MaxLength(11)]
        public string MusteriTC { get; set; }
        [MaxLength(90)]
        public string? MusteriMail { get; set; }
        [MaxLength(8)]
        public string MusteriParola { get; set; }
        [MaxLength(400)]
        public string? MusteriAdres { get; set; }
        public DateTime? MusteriDogumTarihi { get; set; }
        public bool? MusteriKadinMi { get; set; }
        public bool MusteriKurumsalMi { get; set; }
        public int UlkeID { get; set; }
        public int SehirID { get; set; }
        public int IlceID { get; set; }
        public Ulke Ulke { get; set; }
        public Sehir Sehir { get; set; }
        public Ilce Ilce { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
        public ICollection<Satıs> Satıslar { get; set; }

    }
}
