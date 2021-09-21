using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BillEntites.Migrations
{
    public partial class FirstDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Itmdtls",
                columns: table => new
                {
                    ITMCOD = table.Column<Guid>(nullable: false),
                    ITMNAM = table.Column<string>(maxLength: 100, nullable: false),
                    ITMPRC = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itmdtls", x => x.ITMCOD);
                });

            migrationBuilder.CreateTable(
                name: "Vnddtls",
                columns: table => new
                {
                    VNDCOD = table.Column<Guid>(nullable: false),
                    VNDNAM = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vnddtls", x => x.VNDCOD);
                });

            migrationBuilder.CreateTable(
                name: "Bilhdrs",
                columns: table => new
                {
                    BILCOD = table.Column<Guid>(nullable: false),
                    BILDAT = table.Column<DateTime>(nullable: false),
                    BILPRC = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    BILIMG = table.Column<string>(maxLength: 250, nullable: true),
                    VNDCOD = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilhdrs", x => x.BILCOD);
                    table.ForeignKey(
                        name: "FK_Bilhdrs_Vnddtls_VNDCOD",
                        column: x => x.VNDCOD,
                        principalTable: "Vnddtls",
                        principalColumn: "VNDCOD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bildtls",
                columns: table => new
                {
                    DTLCOD = table.Column<Guid>(nullable: false),
                    BILPRC = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ITMQTY = table.Column<int>(nullable: false),
                    BILCOD = table.Column<Guid>(nullable: false),
                    ITMCOD = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bildtls", x => x.DTLCOD);
                    table.ForeignKey(
                        name: "FK_Bildtls_Bilhdrs_BILCOD",
                        column: x => x.BILCOD,
                        principalTable: "Bilhdrs",
                        principalColumn: "BILCOD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bildtls_Itmdtls_ITMCOD",
                        column: x => x.ITMCOD,
                        principalTable: "Itmdtls",
                        principalColumn: "ITMCOD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bildtls_BILCOD",
                table: "Bildtls",
                column: "BILCOD");

            migrationBuilder.CreateIndex(
                name: "IX_Bildtls_ITMCOD",
                table: "Bildtls",
                column: "ITMCOD");

            migrationBuilder.CreateIndex(
                name: "IX_Bilhdrs_VNDCOD",
                table: "Bilhdrs",
                column: "VNDCOD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bildtls");

            migrationBuilder.DropTable(
                name: "Bilhdrs");

            migrationBuilder.DropTable(
                name: "Itmdtls");

            migrationBuilder.DropTable(
                name: "Vnddtls");
        }
    }
}
