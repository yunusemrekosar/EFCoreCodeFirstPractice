using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity;
using Microsoft.EntityFrameworkCore;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Context
{
    internal class kitapEviDbContext : DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Unvan> Unvanlar { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=KitabeviDB;User Id=sa;Password=123456;Trust Server Certificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sehir>()
                .HasOne(s => s.Ulke)
                .WithMany(u => u.Sehirler)
                .HasForeignKey(u => u.UlkeID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ilce>()
                .HasOne(i => i.Sehir)
                .WithMany(s => s.Ilceler)
                .HasForeignKey(i=>i.SehirID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Personel>()
                .HasOne(c => c.Unvan)
                .WithMany(u => u.Personeller)
                .HasForeignKey(c => c.UnvanID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Personel>()
                .HasOne(c => c.Ilce)
                .WithMany(c => c.Personeller)
                .HasForeignKey(c=>c.IlceID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Personel>()
                .HasOne(c=>c.Sehir)
                .WithMany(s=>s.Personeller)
                .HasForeignKey(c=>c.SehirID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Personel>()
                .HasOne(c => c.Ulke)
                .WithMany(u => u.Personeller)
                .HasForeignKey(u => u.UlkeID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Yazar>()
                .HasOne(y => y.Ulke)
                .WithMany(u => u.Yazarlar)
                .HasForeignKey(y => y.UlkeID)
                .OnDelete(DeleteBehavior.ClientSetNull);
                
            modelBuilder.Entity<Yazar>()
                .HasMany(y => y.Kitaplar)
                .WithMany(k => k.Yazarlar);

            modelBuilder.Entity<Kitap>()
                .HasMany<Kategori>(k=>k.Kategoriler)
                .WithMany(ka=>ka.Kitaplar);

            modelBuilder.Entity<Kitap>()
                .HasOne(k => k.Yayınevi)
                .WithMany(y => y.Kitaplar)
                .HasForeignKey(k=>k.YayineviID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Musteri>()
                .HasOne(m=> m.Sehir)
                .WithMany(s=> s.Musteriler)
                .HasForeignKey(m => m.SehirID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Musteri>()
                .HasOne(m => m.Ilce)
                .WithMany(s => s.Musteriler)
                .HasForeignKey(m => m.IlceID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Musteri>()
                .HasOne(m => m.Ulke)
                .WithMany(u => u.Musteriler)
                .HasForeignKey(m=>m.UlkeID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Musteri>()
                .HasMany(m => m.Kitaplar)
                .WithMany(k => k.Musteriler);

            modelBuilder.Entity<Satıs>()
                .HasOne(s => s.Personel)
                .WithMany(c => c.Satıslar)
                .HasForeignKey(s => s.CalisanID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Satıs>()
                .HasOne(s => s.Musteri)
                .WithMany(m => m.Satıslar)
                .HasForeignKey(s=>s.MusteriID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Personel>()
                .HasOne(c => c.Unvan)
                .WithMany(u => u.Personeller)
                .HasForeignKey(c=>c.UnvanID)
                .OnDelete(DeleteBehavior.Cascade);






        }
    }
}
