﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Context;

#nullable disable

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Migrations
{
    [DbContext(typeof(kitapEviDbContext))]
    partial class kitapEviDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KategoriKitap", b =>
                {
                    b.Property<short>("KategorilerKategoriID")
                        .HasColumnType("smallint");

                    b.Property<int>("KitaplarKitapID")
                        .HasColumnType("int");

                    b.HasKey("KategorilerKategoriID", "KitaplarKitapID");

                    b.HasIndex("KitaplarKitapID");

                    b.ToTable("KategoriKitap");
                });

            modelBuilder.Entity("KitapMusteri", b =>
                {
                    b.Property<int>("KitaplarKitapID")
                        .HasColumnType("int");

                    b.Property<int>("MusterilerMusteriID")
                        .HasColumnType("int");

                    b.HasKey("KitaplarKitapID", "MusterilerMusteriID");

                    b.HasIndex("MusterilerMusteriID");

                    b.ToTable("KitapMusteri");
                });

            modelBuilder.Entity("KitapYazar", b =>
                {
                    b.Property<int>("KitaplarKitapID")
                        .HasColumnType("int");

                    b.Property<int>("YazarlarYazarID")
                        .HasColumnType("int");

                    b.HasKey("KitaplarKitapID", "YazarlarYazarID");

                    b.HasIndex("YazarlarYazarID");

                    b.ToTable("KitapYazar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Calisan", b =>
                {
                    b.Property<short>("CalisanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("CalisanID"));

                    b.Property<string>("CalisanAdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalisanAdres")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<DateTime?>("CalisanCıkısTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CalisanGirisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("CalisanMaas")
                        .HasColumnType("int");

                    b.Property<string>("CalisanSgkNu")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CalisanTC")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("CalisanTelNu")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("CalısanAcıklama")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<bool>("CalısanAktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CalısanDogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("CalısanKadınMı")
                        .HasColumnType("bit");

                    b.Property<string>("CalısanMail")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<short?>("IlceID")
                        .HasColumnType("smallint");

                    b.Property<short?>("ReportsTo")
                        .HasColumnType("smallint");

                    b.Property<short?>("SehirID")
                        .HasColumnType("smallint");

                    b.Property<short?>("UlkeID")
                        .HasColumnType("smallint");

                    b.Property<short>("UnvanID")
                        .HasColumnType("smallint");

                    b.HasKey("CalisanID");

                    b.HasIndex("IlceID");

                    b.HasIndex("SehirID");

                    b.HasIndex("UlkeID");

                    b.HasIndex("UnvanID");

                    b.ToTable("Calisanlar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ilce", b =>
                {
                    b.Property<short>("IlceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("IlceID"));

                    b.Property<string>("IlceAD")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<short>("SehirID")
                        .HasColumnType("smallint");

                    b.HasKey("IlceID");

                    b.HasIndex("SehirID");

                    b.ToTable("Ilceler");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kategori", b =>
                {
                    b.Property<short>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("KategoriID"));

                    b.Property<string>("KategoriAdı")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kitap", b =>
                {
                    b.Property<int>("KitapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapID"));

                    b.Property<string>("KitapAd")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("KitapBasimTarihi")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<decimal>("KitapFiyatı")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("KitapISBN")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<short>("KitapSayfaSayısı")
                        .HasColumnType("smallint");

                    b.Property<short>("KitapStok")
                        .HasColumnType("smallint");

                    b.Property<int>("YayineviID")
                        .HasColumnType("int");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("KitapID");

                    b.HasIndex("YayineviID");

                    b.ToTable("Kitap");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Musteri", b =>
                {
                    b.Property<int>("MusteriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MusteriID"));

                    b.Property<short>("IlceID")
                        .HasColumnType("smallint");

                    b.Property<string>("MusteriAdres")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("MusteriAdıSoyadı")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<DateTime?>("MusteriDogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("MusteriKadinMi")
                        .HasColumnType("bit");

                    b.Property<bool>("MusteriKurumsalMi")
                        .HasColumnType("bit");

                    b.Property<string>("MusteriMail")
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("MusteriParola")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("MusteriTC")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("MusteriTelNu")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<short>("SehirID")
                        .HasColumnType("smallint");

                    b.Property<short>("UlkeID")
                        .HasColumnType("smallint");

                    b.HasKey("MusteriID");

                    b.HasIndex("IlceID");

                    b.HasIndex("SehirID");

                    b.HasIndex("UlkeID");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Satıs", b =>
                {
                    b.Property<int>("SatısID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SatısID"));

                    b.Property<short>("CalisanID")
                        .HasColumnType("smallint");

                    b.Property<short>("Indirim")
                        .HasColumnType("smallint");

                    b.Property<int>("MusteriID")
                        .HasColumnType("int");

                    b.Property<string>("SatısFaturaNu")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("SatısFiyat")
                        .HasColumnType("int");

                    b.Property<string>("SatısKdvOrani")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SatısTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("SatısID");

                    b.HasIndex("CalisanID");

                    b.HasIndex("MusteriID");

                    b.ToTable("Satıs");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Sehir", b =>
                {
                    b.Property<short>("SehirID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("SehirID"));

                    b.Property<string>("SehirAd")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<short?>("UlkeID")
                        .IsRequired()
                        .HasColumnType("smallint");

                    b.HasKey("SehirID");

                    b.HasIndex("UlkeID");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ulke", b =>
                {
                    b.Property<short>("UlkeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("UlkeID"));

                    b.Property<string>("UlkeAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UlkeID");

                    b.ToTable("Ulkeler");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Unvan", b =>
                {
                    b.Property<short>("UnvanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("UnvanID"));

                    b.Property<string>("UnvanAd")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("UnvanID");

                    b.ToTable("Unvanlar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yayınevi", b =>
                {
                    b.Property<int>("YayıneviID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YayıneviID"));

                    b.Property<string>("YayıneviAdres")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("YayıneviAdı")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("YayıneviTelefon")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("YayıneviID");

                    b.ToTable("Yayınevi");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarID"));

                    b.Property<short>("UlkeID")
                        .HasColumnType("smallint");

                    b.Property<string>("YazarAcıklama")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("YazarAdıSoyadı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("YazarKadınMi")
                        .HasColumnType("bit");

                    b.HasKey("YazarID");

                    b.HasIndex("UlkeID");

                    b.ToTable("Yazar");
                });

            modelBuilder.Entity("KategoriKitap", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerKategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarKitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KitapMusteri", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarKitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Musteri", null)
                        .WithMany()
                        .HasForeignKey("MusterilerMusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KitapYazar", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarKitapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yazar", null)
                        .WithMany()
                        .HasForeignKey("YazarlarYazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Calisan", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ilce", "Ilce")
                        .WithMany("Calisanlar")
                        .HasForeignKey("IlceID");

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Sehir", "Sehir")
                        .WithMany("Calisanlar")
                        .HasForeignKey("SehirID");

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ulke", "Ulke")
                        .WithMany("Calisanlar")
                        .HasForeignKey("UlkeID");

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Unvan", "Unvan")
                        .WithMany("Calisanlar")
                        .HasForeignKey("UnvanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilce");

                    b.Navigation("Sehir");

                    b.Navigation("Ulke");

                    b.Navigation("Unvan");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ilce", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Sehir", "Sehir")
                        .WithMany("Ilceler")
                        .HasForeignKey("SehirID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kitap", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yayınevi", "Yayınevi")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YayineviID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yayınevi");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Musteri", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ilce", "Ilce")
                        .WithMany("Musteriler")
                        .HasForeignKey("IlceID")
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Sehir", "Sehir")
                        .WithMany("Musteriler")
                        .HasForeignKey("SehirID")
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ulke", "Ulke")
                        .WithMany("Musteriler")
                        .HasForeignKey("UlkeID")
                        .IsRequired();

                    b.Navigation("Ilce");

                    b.Navigation("Sehir");

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Satıs", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Calisan", "Calisan")
                        .WithMany("Satıslar")
                        .HasForeignKey("CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Musteri", "Musteri")
                        .WithMany("Satıslar")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calisan");

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Sehir", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ulke", "Ulke")
                        .WithMany("Sehirler")
                        .HasForeignKey("UlkeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yazar", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ulke", "Ulke")
                        .WithMany("Yazarlar")
                        .HasForeignKey("UlkeID")
                        .IsRequired();

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Calisan", b =>
                {
                    b.Navigation("Satıslar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ilce", b =>
                {
                    b.Navigation("Calisanlar");

                    b.Navigation("Musteriler");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Musteri", b =>
                {
                    b.Navigation("Satıslar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Sehir", b =>
                {
                    b.Navigation("Calisanlar");

                    b.Navigation("Ilceler");

                    b.Navigation("Musteriler");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ulke", b =>
                {
                    b.Navigation("Calisanlar");

                    b.Navigation("Musteriler");

                    b.Navigation("Sehirler");

                    b.Navigation("Yazarlar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Unvan", b =>
                {
                    b.Navigation("Calisanlar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yayınevi", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
