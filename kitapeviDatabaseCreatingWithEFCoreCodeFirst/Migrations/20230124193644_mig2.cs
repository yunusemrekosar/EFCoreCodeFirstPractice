using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YayıneviAdı",
                table: "Yayınevi");

            migrationBuilder.DropColumn(
                name: "SehirAd",
                table: "Sehirler");

            migrationBuilder.DropColumn(
                name: "MusteriAdıSoyadı",
                table: "Musteri");

            migrationBuilder.RenameColumn(
                name: "YazarAdıSoyadı",
                table: "Yazar",
                newName: "Adı");

            migrationBuilder.RenameColumn(
                name: "UnvanAd",
                table: "Unvanlar",
                newName: "Adı");

            migrationBuilder.RenameColumn(
                name: "UlkeAd",
                table: "Ulkeler",
                newName: "Adı");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Satıs",
                newName: "SatısID");

            migrationBuilder.RenameColumn(
                name: "CalisanAdSoyad",
                table: "Personeller",
                newName: "Adı");

            migrationBuilder.RenameColumn(
                name: "KitapAd",
                table: "Kitap",
                newName: "Adı");

            migrationBuilder.RenameColumn(
                name: "KategoriAdı",
                table: "Kategori",
                newName: "Adı");

            migrationBuilder.RenameColumn(
                name: "IlceAD",
                table: "Ilceler",
                newName: "Adı");

            migrationBuilder.AddColumn<string>(
                name: "Adı",
                table: "Yayınevi",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adı",
                table: "Sehirler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adı",
                table: "Musteri",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adı",
                table: "Yayınevi");

            migrationBuilder.DropColumn(
                name: "Adı",
                table: "Sehirler");

            migrationBuilder.DropColumn(
                name: "Adı",
                table: "Musteri");

            migrationBuilder.RenameColumn(
                name: "Adı",
                table: "Yazar",
                newName: "YazarAdıSoyadı");

            migrationBuilder.RenameColumn(
                name: "Adı",
                table: "Unvanlar",
                newName: "UnvanAd");

            migrationBuilder.RenameColumn(
                name: "Adı",
                table: "Ulkeler",
                newName: "UlkeAd");

            migrationBuilder.RenameColumn(
                name: "SatısID",
                table: "Satıs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Adı",
                table: "Personeller",
                newName: "CalisanAdSoyad");

            migrationBuilder.RenameColumn(
                name: "Adı",
                table: "Kitap",
                newName: "KitapAd");

            migrationBuilder.RenameColumn(
                name: "Adı",
                table: "Kategori",
                newName: "KategoriAdı");

            migrationBuilder.RenameColumn(
                name: "Adı",
                table: "Ilceler",
                newName: "IlceAD");

            migrationBuilder.AddColumn<string>(
                name: "YayıneviAdı",
                table: "Yayınevi",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SehirAd",
                table: "Sehirler",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MusteriAdıSoyadı",
                table: "Musteri",
                type: "nvarchar(90)",
                maxLength: 90,
                nullable: false,
                defaultValue: "");
        }
    }
}
