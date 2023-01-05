using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Context;
using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity;

kitapEviDbContext context = new();

//Ulke Ulke = new() { UlkeAd = "Türkiye" };
//Ulke.Sehirler.Add(new() { SehirAd = "Istanbul" });
//Ulke.Sehirler.Add(new() { SehirAd = "Burdur" });
//Ulke.Sehirler.Add(new() { SehirAd = "Kayseri" });
//Ulke.Sehirler.Add(new() { SehirAd = "Ankara" });
//Ulke.Sehirler.Add(new() { SehirAd = "Denizli" });

//Ulke Ulke2 = new() { UlkeAd = "Almanya" };
//Ulke2.Sehirler.Add(new() { SehirAd = "Berlin" });
//Ulke2.Sehirler.Add(new() { SehirAd = "Köln" });
//Ulke2.Sehirler.Add(new() { SehirAd = "Hamburg" });
//Ulke2.Sehirler.Add(new() { SehirAd = "Nuremberg" });

//await context.AddAsync(Ulke);
//await context.AddAsync(Ulke2);
//await context.SaveChangesAsync();

//Ilce ılce = new()
//{
//    SehirID = 1,
//    IlceAD = "Beykoz"
//};

//Ilce ılce2 = new()
//{
//    SehirID = 2,
//    IlceAD = "Merkez"
//};

//Ilce ılce3 = new()
//{
//    SehirID = 3,
//    IlceAD = "Kocasinan"
//};

//Ilce ılce4 = new()
//{
//    SehirID = 4,
//    IlceAD = "Mamak"
//};

//Ilce ılce5 = new()
//{
//    SehirID = 5,
//    IlceAD = "Merkez"
//};

//Ilce[] s = new Ilce[] {ılce, ılce2, ılce3, ılce4, ılce5 };

//foreach (var item in s)
//{
//    await context.AddAsync(item);
//}

//Unvan unvan = new() { UnvanAd = "Müdür" };
//Unvan unvan2 = new() { UnvanAd = "Müdür Yardımcısı" };
//Unvan unvan3 = new() { UnvanAd = "Satış Personeli" };
//Unvan unvan4 = new() { UnvanAd = "Stajyer" };
//Unvan[] unvans = new Unvan[] { unvan, unvan2, unvan3, unvan4 };

//foreach (var item in unvans)
//{
//    await context.AddAsync(item);
//}

//await context.SaveChangesAsync();

//DateTime a = new DateTime();
//a = Convert.ToDateTime("1997-01-01");
//Calisan calısan = new() { CalisanAdSoyad = "Ali Emre", SehirID = 1, UlkeID = 1, CalisanMaas = 8500, CalisanAdres = "Levent", CalisanGirisTarihi = DateTime.Now, CalisanSgkNu = "2151515", CalisanTC = "2121212", CalısanAktifMi = true, CalisanTelNu = "121212112", CalısanKadınMı = false, CalısanDogumTarihi = a, CalısanMail = "djf@gmail.com", CalısanAcıklama = "ilkcalısan", IlceID = 1, UnvanID = 1, };
//await context.AddAsync(calısan);
//await context.SaveChangesAsync();



Console.WriteLine("Hello, World!");

