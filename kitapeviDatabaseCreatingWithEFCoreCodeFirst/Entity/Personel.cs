using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Personel : Baseclass
    {
        public Personel()
        {
            Satıslar = new HashSet<Satıs>();
        }

        [MaxLength(11)]
        public string CalisanTelNu { get; set; }

        [MaxLength(11)]
        public string? CalisanTC { get; set; }

        [MaxLength(25)]
        public string? CalisanSgkNu { get; set; }
        public DateTime? CalisanGirisTarihi { get; set; }
        public DateTime? CalisanCıkısTarihi { get; set; }
        public int CalisanMaas { get; set; }
        [MaxLength(400)]
        public string? CalisanAdres { get; set; }
        public bool CalısanAktifMi { get; set; }
        public DateTime CalısanDogumTarihi { get; set; }
        public bool? CalısanKadınMı { get; set; }
        [MaxLength(400)]
        public string CalısanAcıklama { get; set; }
        [MaxLength(70)]
        public string? CalısanMail { get; set; }
        public int? ReportsTo { get; set; }
        public int UnvanID { get; set; }
        public int? UlkeID { get; set; }
        public int? SehirID { get; set; }
        public int? IlceID { get; set; }
        public Unvan? Unvan { get; set; }
        public Ulke? Ulke { get; set; }
        public Sehir? Sehir { get; set; }
        public Ilce? Ilce { get; set; }
        public ICollection<Satıs>? Satıslar { get; set; }
    }
}
