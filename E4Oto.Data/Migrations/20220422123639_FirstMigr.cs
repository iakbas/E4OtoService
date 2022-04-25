using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E4Oto.Data.Migrations
{
    public partial class FirstMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Danismanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Unvani = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Danismanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DosyaDurumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tanimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aktif = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosyaDurumlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Unvani = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Telefon1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Adres1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Adres2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Adres3 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Il = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operatorler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Unvani = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    IseGirisTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operatorler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RandevuSebepleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tanimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aktif = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RandevuSebepleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sonuclar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tanimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aktif = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sonuclar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriAraclari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SasiNo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Plaka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MotorNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AracTanimi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Renk = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SonServisTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Seri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Km = table.Column<decimal>(type: "decimal(5,1)", nullable: true),
                    TrafigeCikis = table.Column<int>(type: "int", nullable: true),
                    MusteriId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriAraclari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriAraclari_Musteriler",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aramalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Saat = table.Column<int>(type: "int", nullable: true),
                    MusteriId = table.Column<int>(type: "int", nullable: true),
                    AracId = table.Column<int>(type: "int", nullable: true),
                    OperatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aramalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aramalar_MusteriAraclari",
                        column: x => x.AracId,
                        principalTable: "MusteriAraclari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aramalar_Musteriler",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aramalar_Operatorler",
                        column: x => x.OperatorId,
                        principalTable: "Operatorler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AramaDetaylari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeklifiVerildi = table.Column<bool>(type: "bit", nullable: true),
                    TeklifHatirlatmaTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: true),
                    RandevuAlindi = table.Column<bool>(type: "bit", nullable: true),
                    RandevuTarihi = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    RandevuDanismani = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    RandevuNedeni = table.Column<string>(type: "text", nullable: true),
                    BaskaServis = table.Column<bool>(type: "bit", nullable: true),
                    BaskaServisYetkiliMi = table.Column<bool>(type: "bit", nullable: true),
                    AramaId = table.Column<int>(type: "int", nullable: true),
                    Sonuc = table.Column<int>(type: "int", nullable: true),
                    DosyaDurumu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AramaDetaylari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AramaDetaylari_Aramalar",
                        column: x => x.AramaId,
                        principalTable: "Aramalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AramaDetaylari_DosyaDurumlari",
                        column: x => x.DosyaDurumu,
                        principalTable: "DosyaDurumlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AramaDetaylari_Sonuclar",
                        column: x => x.Sonuc,
                        principalTable: "Sonuclar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Randevular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaslangicTarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    BaslangicSaat = table.Column<int>(type: "int", nullable: true),
                    BitisTarih = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    BitisSaat = table.Column<int>(type: "int", nullable: true),
                    MusteriId = table.Column<int>(type: "int", nullable: true),
                    AracId = table.Column<int>(type: "int", nullable: true),
                    AramaId = table.Column<int>(type: "int", nullable: true),
                    CarsaIslendiMi = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SmsAldiMi = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DanismanId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randevular_Aramalar",
                        column: x => x.AramaId,
                        principalTable: "Aramalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Randevular_Danismanlar",
                        column: x => x.DanismanId,
                        principalTable: "Danismanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Randevular_MusteriAraclari",
                        column: x => x.AracId,
                        principalTable: "MusteriAraclari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Randevular_Musteriler",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AramaDetaylari_AramaId",
                table: "AramaDetaylari",
                column: "AramaId");

            migrationBuilder.CreateIndex(
                name: "IX_AramaDetaylari_DosyaDurumu",
                table: "AramaDetaylari",
                column: "DosyaDurumu");

            migrationBuilder.CreateIndex(
                name: "IX_AramaDetaylari_Sonuc",
                table: "AramaDetaylari",
                column: "Sonuc");

            migrationBuilder.CreateIndex(
                name: "IX_Aramalar_AracId",
                table: "Aramalar",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_Aramalar_MusteriId",
                table: "Aramalar",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Aramalar_OperatorId",
                table: "Aramalar",
                column: "OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriAraclari_MusteriId",
                table: "MusteriAraclari",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_AracId",
                table: "Randevular",
                column: "AracId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_AramaId",
                table: "Randevular",
                column: "AramaId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_DanismanId",
                table: "Randevular",
                column: "DanismanId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_MusteriId",
                table: "Randevular",
                column: "MusteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AramaDetaylari");

            migrationBuilder.DropTable(
                name: "Randevular");

            migrationBuilder.DropTable(
                name: "RandevuSebepleri");

            migrationBuilder.DropTable(
                name: "DosyaDurumlari");

            migrationBuilder.DropTable(
                name: "Sonuclar");

            migrationBuilder.DropTable(
                name: "Aramalar");

            migrationBuilder.DropTable(
                name: "Danismanlar");

            migrationBuilder.DropTable(
                name: "MusteriAraclari");

            migrationBuilder.DropTable(
                name: "Operatorler");

            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
