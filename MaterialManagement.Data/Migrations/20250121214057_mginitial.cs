using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaterialManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class mginitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fiyatlar",
                columns: table => new
                {
                    FiyatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MalzemeFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fiyatlar", x => x.FiyatId);
                });

            migrationBuilder.CreateTable(
                name: "MalzemeGruplari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalzemeGruplari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceteBasliklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceteAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VersiyonNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceteBasliklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrunTipiTablolari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunTipiTablolari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Malzemeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MalzemeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MalzemeGrupId = table.Column<int>(type: "int", nullable: false),
                    StokMiktari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fotograf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FiyatId = table.Column<int>(type: "int", nullable: false),
                    UrunTipiTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Malzemeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Malzemeler_Fiyatlar_FiyatId",
                        column: x => x.FiyatId,
                        principalTable: "Fiyatlar",
                        principalColumn: "FiyatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Malzemeler_MalzemeGruplari_MalzemeGrupId",
                        column: x => x.MalzemeGrupId,
                        principalTable: "MalzemeGruplari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Malzemeler_UrunTipiTablolari_UrunTipiTablosuId",
                        column: x => x.UrunTipiTablosuId,
                        principalTable: "UrunTipiTablolari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceteKalemler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceteBaslikId = table.Column<int>(type: "int", nullable: false),
                    MalzemeId = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceteKalemler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceteKalemler_Malzemeler_MalzemeId",
                        column: x => x.MalzemeId,
                        principalTable: "Malzemeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceteKalemler_ReceteBasliklar_ReceteBaslikId",
                        column: x => x.ReceteBaslikId,
                        principalTable: "ReceteBasliklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stoklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MalzemeId = table.Column<int>(type: "int", nullable: false),
                    IslemTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoklar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stoklar_Malzemeler_MalzemeId",
                        column: x => x.MalzemeId,
                        principalTable: "Malzemeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Malzemeler_FiyatId",
                table: "Malzemeler",
                column: "FiyatId");

            migrationBuilder.CreateIndex(
                name: "IX_Malzemeler_MalzemeGrupId",
                table: "Malzemeler",
                column: "MalzemeGrupId");

            migrationBuilder.CreateIndex(
                name: "IX_Malzemeler_UrunTipiTablosuId",
                table: "Malzemeler",
                column: "UrunTipiTablosuId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceteKalemler_MalzemeId",
                table: "ReceteKalemler",
                column: "MalzemeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceteKalemler_ReceteBaslikId",
                table: "ReceteKalemler",
                column: "ReceteBaslikId");

            migrationBuilder.CreateIndex(
                name: "IX_Stoklar_MalzemeId",
                table: "Stoklar",
                column: "MalzemeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceteKalemler");

            migrationBuilder.DropTable(
                name: "Stoklar");

            migrationBuilder.DropTable(
                name: "ReceteBasliklar");

            migrationBuilder.DropTable(
                name: "Malzemeler");

            migrationBuilder.DropTable(
                name: "Fiyatlar");

            migrationBuilder.DropTable(
                name: "MalzemeGruplari");

            migrationBuilder.DropTable(
                name: "UrunTipiTablolari");
        }
    }
}
