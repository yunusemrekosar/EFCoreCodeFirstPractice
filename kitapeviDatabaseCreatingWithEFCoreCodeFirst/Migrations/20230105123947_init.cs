using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdı = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Ulkeler",
                columns: table => new
                {
                    UlkeID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulkeler", x => x.UlkeID);
                });

            migrationBuilder.CreateTable(
                name: "Unvanlar",
                columns: table => new
                {
                    UnvanID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanAd = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvanlar", x => x.UnvanID);
                });

            migrationBuilder.CreateTable(
                name: "Yayınevi",
                columns: table => new
                {
                    YayıneviID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayıneviAdı = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    YayıneviAdres = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    YayıneviTelefon = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayınevi", x => x.YayıneviID);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    SehirID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAd = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    UlkeID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.SehirID);
                    table.ForeignKey(
                        name: "FK_Sehirler_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulkeler",
                        principalColumn: "UlkeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yazar",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdıSoyadı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarKadınMi = table.Column<bool>(type: "bit", nullable: true),
                    YazarAcıklama = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UlkeID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazar", x => x.YazarID);
                    table.ForeignKey(
                        name: "FK_Yazar_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulkeler",
                        principalColumn: "UlkeID");
                });

            migrationBuilder.CreateTable(
                name: "Kitap",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAd = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    KitapBasimTarihi = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    KitapFiyatı = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KitapSayfaSayısı = table.Column<short>(type: "smallint", nullable: false),
                    KitapStok = table.Column<short>(type: "smallint", nullable: false),
                    KitapISBN = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    YazarID = table.Column<int>(type: "int", nullable: false),
                    YayineviID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap", x => x.KitapID);
                    table.ForeignKey(
                        name: "FK_Kitap_Yayınevi_YayineviID",
                        column: x => x.YayineviID,
                        principalTable: "Yayınevi",
                        principalColumn: "YayıneviID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ilceler",
                columns: table => new
                {
                    IlceID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceAD = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    SehirID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilceler", x => x.IlceID);
                    table.ForeignKey(
                        name: "FK_Ilceler_Sehirler_SehirID",
                        column: x => x.SehirID,
                        principalTable: "Sehirler",
                        principalColumn: "SehirID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KategoriKitap",
                columns: table => new
                {
                    KategorilerKategoriID = table.Column<short>(type: "smallint", nullable: false),
                    KitaplarKitapID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriKitap", x => new { x.KategorilerKategoriID, x.KitaplarKitapID });
                    table.ForeignKey(
                        name: "FK_KategoriKitap_Kategori_KategorilerKategoriID",
                        column: x => x.KategorilerKategoriID,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriKitap_Kitap_KitaplarKitapID",
                        column: x => x.KitaplarKitapID,
                        principalTable: "Kitap",
                        principalColumn: "KitapID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYazar",
                columns: table => new
                {
                    KitaplarKitapID = table.Column<int>(type: "int", nullable: false),
                    YazarlarYazarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazar", x => new { x.KitaplarKitapID, x.YazarlarYazarID });
                    table.ForeignKey(
                        name: "FK_KitapYazar_Kitap_KitaplarKitapID",
                        column: x => x.KitaplarKitapID,
                        principalTable: "Kitap",
                        principalColumn: "KitapID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazar_Yazar_YazarlarYazarID",
                        column: x => x.YazarlarYazarID,
                        principalTable: "Yazar",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calisanlar",
                columns: table => new
                {
                    CalisanID = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalisanAdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalisanTelNu = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CalisanTC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    CalisanSgkNu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CalisanGirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CalisanCıkısTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CalisanMaas = table.Column<int>(type: "int", nullable: false),
                    CalisanAdres = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    CalısanAktifMi = table.Column<bool>(type: "bit", nullable: false),
                    CalısanDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalısanKadınMı = table.Column<bool>(type: "bit", nullable: true),
                    CalısanAcıklama = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    CalısanMail = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    ReportsTo = table.Column<short>(type: "smallint", nullable: true),
                    UnvanID = table.Column<short>(type: "smallint", nullable: false),
                    UlkeID = table.Column<short>(type: "smallint", nullable: true),
                    SehirID = table.Column<short>(type: "smallint", nullable: true),
                    IlceID = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlar", x => x.CalisanID);
                    table.ForeignKey(
                        name: "FK_Calisanlar_Ilceler_IlceID",
                        column: x => x.IlceID,
                        principalTable: "Ilceler",
                        principalColumn: "IlceID");
                    table.ForeignKey(
                        name: "FK_Calisanlar_Sehirler_SehirID",
                        column: x => x.SehirID,
                        principalTable: "Sehirler",
                        principalColumn: "SehirID");
                    table.ForeignKey(
                        name: "FK_Calisanlar_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulkeler",
                        principalColumn: "UlkeID");
                    table.ForeignKey(
                        name: "FK_Calisanlar_Unvanlar_UnvanID",
                        column: x => x.UnvanID,
                        principalTable: "Unvanlar",
                        principalColumn: "UnvanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAdıSoyadı = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    MusteriTelNu = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    MusteriTC = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    MusteriMail = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    MusteriParola = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    MusteriAdres = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    MusteriDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MusteriKadinMi = table.Column<bool>(type: "bit", nullable: true),
                    MusteriKurumsalMi = table.Column<bool>(type: "bit", nullable: false),
                    UlkeID = table.Column<short>(type: "smallint", nullable: false),
                    SehirID = table.Column<short>(type: "smallint", nullable: false),
                    IlceID = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.MusteriID);
                    table.ForeignKey(
                        name: "FK_Musteri_Ilceler_IlceID",
                        column: x => x.IlceID,
                        principalTable: "Ilceler",
                        principalColumn: "IlceID");
                    table.ForeignKey(
                        name: "FK_Musteri_Sehirler_SehirID",
                        column: x => x.SehirID,
                        principalTable: "Sehirler",
                        principalColumn: "SehirID");
                    table.ForeignKey(
                        name: "FK_Musteri_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulkeler",
                        principalColumn: "UlkeID");
                });

            migrationBuilder.CreateTable(
                name: "KitapMusteri",
                columns: table => new
                {
                    KitaplarKitapID = table.Column<int>(type: "int", nullable: false),
                    MusterilerMusteriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapMusteri", x => new { x.KitaplarKitapID, x.MusterilerMusteriID });
                    table.ForeignKey(
                        name: "FK_KitapMusteri_Kitap_KitaplarKitapID",
                        column: x => x.KitaplarKitapID,
                        principalTable: "Kitap",
                        principalColumn: "KitapID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapMusteri_Musteri_MusterilerMusteriID",
                        column: x => x.MusterilerMusteriID,
                        principalTable: "Musteri",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Satıs",
                columns: table => new
                {
                    SatısID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SatısFaturaNu = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    SatısFiyat = table.Column<int>(type: "int", nullable: false),
                    SatısKdvOrani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatısTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalisanID = table.Column<short>(type: "smallint", nullable: false),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    Indirim = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satıs", x => x.SatısID);
                    table.ForeignKey(
                        name: "FK_Satıs_Calisanlar_CalisanID",
                        column: x => x.CalisanID,
                        principalTable: "Calisanlar",
                        principalColumn: "CalisanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Satıs_Musteri_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteri",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calisanlar_IlceID",
                table: "Calisanlar",
                column: "IlceID");

            migrationBuilder.CreateIndex(
                name: "IX_Calisanlar_SehirID",
                table: "Calisanlar",
                column: "SehirID");

            migrationBuilder.CreateIndex(
                name: "IX_Calisanlar_UlkeID",
                table: "Calisanlar",
                column: "UlkeID");

            migrationBuilder.CreateIndex(
                name: "IX_Calisanlar_UnvanID",
                table: "Calisanlar",
                column: "UnvanID");

            migrationBuilder.CreateIndex(
                name: "IX_Ilceler_SehirID",
                table: "Ilceler",
                column: "SehirID");

            migrationBuilder.CreateIndex(
                name: "IX_KategoriKitap_KitaplarKitapID",
                table: "KategoriKitap",
                column: "KitaplarKitapID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_YayineviID",
                table: "Kitap",
                column: "YayineviID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapMusteri_MusterilerMusteriID",
                table: "KitapMusteri",
                column: "MusterilerMusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazar_YazarlarYazarID",
                table: "KitapYazar",
                column: "YazarlarYazarID");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_IlceID",
                table: "Musteri",
                column: "IlceID");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_SehirID",
                table: "Musteri",
                column: "SehirID");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_UlkeID",
                table: "Musteri",
                column: "UlkeID");

            migrationBuilder.CreateIndex(
                name: "IX_Satıs_CalisanID",
                table: "Satıs",
                column: "CalisanID");

            migrationBuilder.CreateIndex(
                name: "IX_Satıs_MusteriID",
                table: "Satıs",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Sehirler_UlkeID",
                table: "Sehirler",
                column: "UlkeID");

            migrationBuilder.CreateIndex(
                name: "IX_Yazar_UlkeID",
                table: "Yazar",
                column: "UlkeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KategoriKitap");

            migrationBuilder.DropTable(
                name: "KitapMusteri");

            migrationBuilder.DropTable(
                name: "KitapYazar");

            migrationBuilder.DropTable(
                name: "Satıs");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Kitap");

            migrationBuilder.DropTable(
                name: "Yazar");

            migrationBuilder.DropTable(
                name: "Calisanlar");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "Yayınevi");

            migrationBuilder.DropTable(
                name: "Unvanlar");

            migrationBuilder.DropTable(
                name: "Ilceler");

            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "Ulkeler");
        }
    }
}
