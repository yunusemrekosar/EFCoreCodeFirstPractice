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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdı = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ulkeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlkeAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulkeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unvanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnvanAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unvanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yayınevi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayıneviAdı = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    YayıneviAdres = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    YayıneviTelefon = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayınevi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirAd = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    UlkeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sehirler_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulkeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yazar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdıSoyadı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarKadınMi = table.Column<bool>(type: "bit", nullable: true),
                    YazarAcıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlkeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yazar_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulkeler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kitap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KitapBasimTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapFiyatı = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KitapSayfaSayısı = table.Column<int>(type: "int", nullable: false),
                    KitapStok = table.Column<int>(type: "int", nullable: false),
                    KitapISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YazarID = table.Column<int>(type: "int", nullable: false),
                    YayineviID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kitap_Yayınevi_YayineviID",
                        column: x => x.YayineviID,
                        principalTable: "Yayınevi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ilceler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlceAD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilceler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilceler_Sehirler_SehirID",
                        column: x => x.SehirID,
                        principalTable: "Sehirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KategoriKitap",
                columns: table => new
                {
                    KategorilerId = table.Column<int>(type: "int", nullable: false),
                    KitaplarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriKitap", x => new { x.KategorilerId, x.KitaplarId });
                    table.ForeignKey(
                        name: "FK_KategoriKitap_Kategori_KategorilerId",
                        column: x => x.KategorilerId,
                        principalTable: "Kategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriKitap_Kitap_KitaplarId",
                        column: x => x.KitaplarId,
                        principalTable: "Kitap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYazar",
                columns: table => new
                {
                    KitaplarId = table.Column<int>(type: "int", nullable: false),
                    YazarlarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazar", x => new { x.KitaplarId, x.YazarlarId });
                    table.ForeignKey(
                        name: "FK_KitapYazar_Kitap_KitaplarId",
                        column: x => x.KitaplarId,
                        principalTable: "Kitap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazar_Yazar_YazarlarId",
                        column: x => x.YazarlarId,
                        principalTable: "Yazar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    UlkeID = table.Column<int>(type: "int", nullable: false),
                    SehirID = table.Column<int>(type: "int", nullable: false),
                    IlceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteri_Ilceler_IlceID",
                        column: x => x.IlceID,
                        principalTable: "Ilceler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Musteri_Sehirler_SehirID",
                        column: x => x.SehirID,
                        principalTable: "Sehirler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Musteri_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulkeler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    ReportsTo = table.Column<int>(type: "int", nullable: true),
                    UnvanID = table.Column<int>(type: "int", nullable: false),
                    UlkeID = table.Column<int>(type: "int", nullable: true),
                    SehirID = table.Column<int>(type: "int", nullable: true),
                    IlceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personeller_Ilceler_IlceID",
                        column: x => x.IlceID,
                        principalTable: "Ilceler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personeller_Sehirler_SehirID",
                        column: x => x.SehirID,
                        principalTable: "Sehirler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personeller_Ulkeler_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulkeler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personeller_Unvanlar_UnvanID",
                        column: x => x.UnvanID,
                        principalTable: "Unvanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapMusteri",
                columns: table => new
                {
                    KitaplarId = table.Column<int>(type: "int", nullable: false),
                    MusterilerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapMusteri", x => new { x.KitaplarId, x.MusterilerId });
                    table.ForeignKey(
                        name: "FK_KitapMusteri_Kitap_KitaplarId",
                        column: x => x.KitaplarId,
                        principalTable: "Kitap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapMusteri_Musteri_MusterilerId",
                        column: x => x.MusterilerId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Satıs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SatısFaturaNu = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    SatısFiyat = table.Column<int>(type: "int", nullable: false),
                    SatısKdvOrani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SatısTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalisanID = table.Column<int>(type: "int", nullable: false),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    Indirim = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satıs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Satıs_Musteri_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Satıs_Personeller_CalisanID",
                        column: x => x.CalisanID,
                        principalTable: "Personeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ilceler_SehirID",
                table: "Ilceler",
                column: "SehirID");

            migrationBuilder.CreateIndex(
                name: "IX_KategoriKitap_KitaplarId",
                table: "KategoriKitap",
                column: "KitaplarId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitap_YayineviID",
                table: "Kitap",
                column: "YayineviID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapMusteri_MusterilerId",
                table: "KitapMusteri",
                column: "MusterilerId");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazar_YazarlarId",
                table: "KitapYazar",
                column: "YazarlarId");

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
                name: "IX_Personeller_IlceID",
                table: "Personeller",
                column: "IlceID");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_SehirID",
                table: "Personeller",
                column: "SehirID");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_UlkeID",
                table: "Personeller",
                column: "UlkeID");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_UnvanID",
                table: "Personeller",
                column: "UnvanID");

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
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Yayınevi");

            migrationBuilder.DropTable(
                name: "Ilceler");

            migrationBuilder.DropTable(
                name: "Unvanlar");

            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "Ulkeler");
        }
    }
}
