﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Context;

#nullable disable

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Migrations
{
    [DbContext(typeof(kitapEviDbContext))]
    [Migration("20230124193644_mig2")]
    partial class mig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KategoriKitap", b =>
                {
                    b.Property<int>("KategorilerId")
                        .HasColumnType("int");

                    b.Property<int>("KitaplarId")
                        .HasColumnType("int");

                    b.HasKey("KategorilerId", "KitaplarId");

                    b.HasIndex("KitaplarId");

                    b.ToTable("KategoriKitap");
                });

            modelBuilder.Entity("KitapMusteri", b =>
                {
                    b.Property<int>("KitaplarId")
                        .HasColumnType("int");

                    b.Property<int>("MusterilerId")
                        .HasColumnType("int");

                    b.HasKey("KitaplarId", "MusterilerId");

                    b.HasIndex("MusterilerId");

                    b.ToTable("KitapMusteri");
                });

            modelBuilder.Entity("KitapYazar", b =>
                {
                    b.Property<int>("KitaplarId")
                        .HasColumnType("int");

                    b.Property<int>("YazarlarId")
                        .HasColumnType("int");

                    b.HasKey("KitaplarId", "YazarlarId");

                    b.HasIndex("YazarlarId");

                    b.ToTable("KitapYazar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SehirID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SehirID");

                    b.ToTable("Ilceler");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapBasimTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("KitapFiyatı")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("KitapISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapSayfaSayısı")
                        .HasColumnType("int");

                    b.Property<int>("KitapStok")
                        .HasColumnType("int");

                    b.Property<int>("YayineviID")
                        .HasColumnType("int");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YayineviID");

                    b.ToTable("Kitap");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlceID")
                        .HasColumnType("int");

                    b.Property<string>("MusteriAdres")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

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

                    b.Property<int>("SehirID")
                        .HasColumnType("int");

                    b.Property<int>("UlkeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IlceID");

                    b.HasIndex("SehirID");

                    b.HasIndex("UlkeID");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
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

                    b.Property<int?>("IlceID")
                        .HasColumnType("int");

                    b.Property<int?>("ReportsTo")
                        .HasColumnType("int");

                    b.Property<int?>("SehirID")
                        .HasColumnType("int");

                    b.Property<int?>("UlkeID")
                        .HasColumnType("int");

                    b.Property<int>("UnvanID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IlceID");

                    b.HasIndex("SehirID");

                    b.HasIndex("UlkeID");

                    b.HasIndex("UnvanID");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Satıs", b =>
                {
                    b.Property<int>("SatısID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SatısID"));

                    b.Property<int>("CalisanID")
                        .HasColumnType("int");

                    b.Property<int>("Indirim")
                        .HasColumnType("int");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlkeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UlkeID");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ulke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ulkeler");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Unvan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unvanlar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yayınevi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YayıneviAdres")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("YayıneviTelefon")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Yayınevi");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yazar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlkeID")
                        .HasColumnType("int");

                    b.Property<string>("YazarAcıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("YazarKadınMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UlkeID");

                    b.ToTable("Yazar");
                });

            modelBuilder.Entity("KategoriKitap", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KitapMusteri", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Musteri", null)
                        .WithMany()
                        .HasForeignKey("MusterilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KitapYazar", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Kitap", null)
                        .WithMany()
                        .HasForeignKey("KitaplarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yazar", null)
                        .WithMany()
                        .HasForeignKey("YazarlarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Personel", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ilce", "Ilce")
                        .WithMany("Personeller")
                        .HasForeignKey("IlceID");

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Sehir", "Sehir")
                        .WithMany("Personeller")
                        .HasForeignKey("SehirID");

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ulke", "Ulke")
                        .WithMany("Personeller")
                        .HasForeignKey("UlkeID");

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Unvan", "Unvan")
                        .WithMany("Personeller")
                        .HasForeignKey("UnvanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilce");

                    b.Navigation("Sehir");

                    b.Navigation("Ulke");

                    b.Navigation("Unvan");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Satıs", b =>
                {
                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Personel", "Personel")
                        .WithMany("Satıslar")
                        .HasForeignKey("CalisanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Musteri", "Musteri")
                        .WithMany("Satıslar")
                        .HasForeignKey("MusteriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");

                    b.Navigation("Personel");
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

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ilce", b =>
                {
                    b.Navigation("Musteriler");

                    b.Navigation("Personeller");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Musteri", b =>
                {
                    b.Navigation("Satıslar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Personel", b =>
                {
                    b.Navigation("Satıslar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Sehir", b =>
                {
                    b.Navigation("Ilceler");

                    b.Navigation("Musteriler");

                    b.Navigation("Personeller");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Ulke", b =>
                {
                    b.Navigation("Musteriler");

                    b.Navigation("Personeller");

                    b.Navigation("Sehirler");

                    b.Navigation("Yazarlar");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Unvan", b =>
                {
                    b.Navigation("Personeller");
                });

            modelBuilder.Entity("kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Yayınevi", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
