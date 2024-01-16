using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _01DiyetProjesi.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Yiyecekler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DataStatus",
                table: "Yiyecekler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "Yiyecekler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modifided",
                table: "Yiyecekler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Porsiyonlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DataStatus",
                table: "Porsiyonlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "Porsiyonlar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modifided",
                table: "Porsiyonlar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Ogunler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DataStatus",
                table: "Ogunler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "Ogunler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modifided",
                table: "Ogunler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Kullanicilar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DataStatus",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "Kullanicilar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Modifided",
                table: "Kullanicilar",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DiyetTablolari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    YiyecekId = table.Column<int>(type: "int", nullable: false),
                    OgunId = table.Column<int>(type: "int", nullable: false),
                    PorsiyonId = table.Column<int>(type: "int", nullable: false),
                    Birim = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modifided = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiyetTablolari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiyetTablolari_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiyetTablolari_Ogunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiyetTablolari_Porsiyonlar_PorsiyonId",
                        column: x => x.PorsiyonId,
                        principalTable: "Porsiyonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiyetTablolari_Yiyecekler_YiyecekId",
                        column: x => x.YiyecekId,
                        principalTable: "Yiyecekler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiyetTablolari_KullaniciId",
                table: "DiyetTablolari",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_DiyetTablolari_OgunId",
                table: "DiyetTablolari",
                column: "OgunId");

            migrationBuilder.CreateIndex(
                name: "IX_DiyetTablolari_PorsiyonId",
                table: "DiyetTablolari",
                column: "PorsiyonId");

            migrationBuilder.CreateIndex(
                name: "IX_DiyetTablolari_YiyecekId",
                table: "DiyetTablolari",
                column: "YiyecekId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiyetTablolari");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Yiyecekler");

            migrationBuilder.DropColumn(
                name: "DataStatus",
                table: "Yiyecekler");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Yiyecekler");

            migrationBuilder.DropColumn(
                name: "Modifided",
                table: "Yiyecekler");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Porsiyonlar");

            migrationBuilder.DropColumn(
                name: "DataStatus",
                table: "Porsiyonlar");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Porsiyonlar");

            migrationBuilder.DropColumn(
                name: "Modifided",
                table: "Porsiyonlar");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Ogunler");

            migrationBuilder.DropColumn(
                name: "DataStatus",
                table: "Ogunler");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Ogunler");

            migrationBuilder.DropColumn(
                name: "Modifided",
                table: "Ogunler");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "DataStatus",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Modifided",
                table: "Kullanicilar");
        }
    }
}
