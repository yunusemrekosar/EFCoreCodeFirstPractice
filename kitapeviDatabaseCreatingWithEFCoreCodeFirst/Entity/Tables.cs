using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Calisan
    {
        public Calisan() 
        {
            Satıslar = new HashSet<Satıs>();
        }
        public Int16 CalisanID { get; set; }
        public string CalisanAdSoyad { get; set; }

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
        public Int16? ReportsTo { get; set; }
        public Int16 UnvanID { get; set; }
        public Int16? UlkeID { get; set; }
        public Int16? SehirID { get; set; }
        public Int16? IlceID { get; set; }
        public Unvan? Unvan { get; set; }
        public Ulke? Ulke { get; set; }
        public Sehir? Sehir { get; set; }
        public Ilce? Ilce { get; set; }
        public ICollection<Satıs>? Satıslar { get; set; }
    }

    public class Unvan
    {
        public Unvan()
        {
            Calisanlar = new HashSet<Calisan>();
        }
        public short UnvanID { get; set; }

        [MaxLength(40)]
        public string UnvanAd { get; set; }
        public ICollection<Calisan> Calisanlar { get; set; }
    }

    public class Ulke
    {
        public Ulke()
        {
            Sehirler = new HashSet<Sehir>();
            Calisanlar = new HashSet<Calisan>();
            Musteriler = new HashSet<Musteri>();
            Yazarlar = new HashSet<Yazar>();
        }
        public Int16 UlkeID { get; set; }
        [MaxLength(50)]
        public string UlkeAd { get; set; }

        public ICollection<Sehir>? Sehirler { get; set; }
        public ICollection<Calisan>? Calisanlar { get; set; }
        public ICollection<Yazar>? Yazarlar { get; set; }
        public ICollection<Musteri>? Musteriler { get; set; }

    }

    public class Sehir
    {
        public Sehir()
        {
            Calisanlar = new HashSet<Calisan>();
            Musteriler = new HashSet<Musteri>();
            Ilceler = new HashSet<Ilce>();
        }
        public Int16 SehirID { get; set; }
        [MaxLength(70)]
        public string SehirAd { get; set; }
        public Ulke Ulke { get; set; }

        public Int16? UlkeID { get; set; }
        public ICollection<Ilce> Ilceler { get; set; }
        public ICollection<Calisan>? Calisanlar { get; set; }
        public ICollection<Musteri>? Musteriler { get; set; }
    }

    public class Ilce
    {
        public Ilce()
        {
            Calisanlar = new HashSet<Calisan>();
            Musteriler = new HashSet<Musteri>();
        }

        public Int16 IlceID { get; set; }
        [MaxLength(70)]
        public string IlceAD { get; set; }
        public Sehir Sehir { get; set; }
        public Int16 SehirID { get; set; }
        public ICollection<Calisan>? Calisanlar { get; set; }
        public ICollection<Musteri>? Musteriler { get; set; }
    }

    public class Yazar
    {
        public Yazar()
        {
            Kitaplar = new HashSet<Kitap>();
        }
        public int YazarID { get; set; }
        public string YazarAdıSoyadı { get; set; }
        public bool? YazarKadınMi { get; set; }
        [MaxLength(250)]
        public string? YazarAcıklama { get; set; }
        public Int16 UlkeID { get; set; }
        public Ulke Ulke { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
    }

    public class Kitap
    {
        public Kitap()
        {
            Yazarlar = new HashSet<Yazar>();
            Kategoriler = new HashSet<Kategori>();
            Musteriler = new HashSet<Musteri>();
        }
        public int KitapID { get; set; }
        [MaxLength(80)]
        public string KitapAd { get; set; }
        [MaxLength(4)]
        public string? KitapBasimTarihi { get; set; }
        public decimal KitapFiyatı { get; set; }
        public Int16 KitapSayfaSayısı { get; set; }
        public Int16 KitapStok { get; set; }
        [MaxLength(13)]
        public string? KitapISBN { get; set; }
        public int YazarID { get; set; }
        public int YayineviID { get; set; }
        public ICollection<Yazar> Yazarlar { get; set; }
        public ICollection<Kategori>? Kategoriler { get; set; }
        public Yayınevi? Yayınevi { get; set; }
        public ICollection<Musteri> Musteriler { get; set; }
    }

    public class Kategori
    {
        public Kategori()
        {
            Kitaplar = new HashSet<Kitap>();
        }

        public Int16 KategoriID { get; set; }
        [MaxLength(70)]
        public string KategoriAdı { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
    }

    public class Yayınevi
    {
        public Yayınevi()
        {
            Kitaplar = new HashSet<Kitap>();
        }
        public int YayıneviID { get; set; }
        [MaxLength(70)]
        public string YayıneviAdı { get; set; }
        [MaxLength(400)]
        public string? YayıneviAdres { get; set; }
        [MaxLength(11)]
        public string? YayıneviTelefon { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }

    }

    public class Musteri
    {
        public Musteri()
        {
            Kitaplar = new HashSet<Kitap>();
            Satıslar = new HashSet<Satıs>();

        }
        public int MusteriID { get; set; }
        [MaxLength(90)]
        public string MusteriAdıSoyadı { get; set; }
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
        public Int16 UlkeID { get; set; }
        public Int16 SehirID { get; set; }
        public Int16 IlceID { get; set; }
        public Ulke Ulke { get; set; }
        public Sehir Sehir { get; set; }
        public Ilce Ilce { get; set; }
        public ICollection<Kitap> Kitaplar { get; set; }
        public ICollection<Satıs> Satıslar { get; set; }
        
    }

    public class Satıs
    {
        public int SatısID { get; set; }
        [MaxLength(13)]
        public string? SatısFaturaNu { get; set; }
        public int SatısFiyat { get; set; }
        public string? SatısKdvOrani { get; set; }
        public DateTime SatısTarih { get; set; }
        public Int16 CalisanID { get; set; }
        public int MusteriID{ get; set; }
        public Int16 Indirim { get; set; }
        public Musteri Musteri { get; set; }
        public Calisan Calisan { get; set; }
    }
}
