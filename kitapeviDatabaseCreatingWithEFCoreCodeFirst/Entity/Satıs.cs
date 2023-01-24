using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;
using System.ComponentModel.DataAnnotations;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Satıs 
    {
        public int SatısID { get; set; }

        [MaxLength(13)]
        public string? SatısFaturaNu { get; set; }
        public int SatısFiyat { get; set; }
        public string? SatısKdvOrani { get; set; }
        public DateTime SatısTarih { get; set; }
        public int CalisanID { get; set; }
        public int MusteriID { get; set; }
        public int Indirim { get; set; }
        public Musteri Musteri { get; set; }
        public Personel Personel { get; set; }
    }
}
