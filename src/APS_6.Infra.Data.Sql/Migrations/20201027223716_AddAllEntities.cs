using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APS_6.Infra.Data.Sql.Migrations
{
    public partial class AddAllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RuralProperties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuralProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(nullable: true),
                    BuildingNumber = table.Column<int>(nullable: false),
                    District = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    RuralPropertyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_RuralProperties_RuralPropertyId",
                        column: x => x.RuralPropertyId,
                        principalTable: "RuralProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pesticides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Legal = table.Column<bool>(nullable: false),
                    ToxicLevel = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    RuralPropertyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pesticides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pesticides_RuralProperties_RuralPropertyId",
                        column: x => x.RuralPropertyId,
                        principalTable: "RuralProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DeadlineDate = table.Column<DateTime>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    RuralPropertyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_RuralProperties_RuralPropertyId",
                        column: x => x.RuralPropertyId,
                        principalTable: "RuralProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_RuralPropertyId",
                table: "Addresses",
                column: "RuralPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Pesticides_RuralPropertyId",
                table: "Pesticides",
                column: "RuralPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_RuralPropertyId",
                table: "Tickets",
                column: "RuralPropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Pesticides");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "RuralProperties");
        }
    }
}
