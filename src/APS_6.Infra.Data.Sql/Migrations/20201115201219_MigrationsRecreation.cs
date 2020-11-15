using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APS_6.Infra.Data.Sql.Migrations
{
    public partial class MigrationsRecreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pesticide",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Legal = table.Column<bool>(nullable: false),
                    ToxicLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RuralProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BuildingNumber = table.Column<int>(nullable: false),
                    District = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false),
                    City = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    State = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuralProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Permission = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PesticideRuralProperties",
                columns: table => new
                {
                    RuralPropertyId = table.Column<Guid>(nullable: false),
                    PesticideId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PesticideRuralProperties", x => new { x.PesticideId, x.RuralPropertyId });
                    table.ForeignKey(
                        name: "FK_PesticideRuralProperties_Pesticide_PesticideId",
                        column: x => x.PesticideId,
                        principalTable: "Pesticide",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PesticideRuralProperties_RuralProperty_RuralPropertyId",
                        column: x => x.RuralPropertyId,
                        principalTable: "RuralProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<decimal>(type: "money", nullable: false),
                    Description = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    RuralPropertyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_RuralProperty_RuralPropertyId",
                        column: x => x.RuralPropertyId,
                        principalTable: "RuralProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PesticideRuralProperties_RuralPropertyId",
                table: "PesticideRuralProperties",
                column: "RuralPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_RuralPropertyId",
                table: "Ticket",
                column: "RuralPropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PesticideRuralProperties");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Pesticide");

            migrationBuilder.DropTable(
                name: "RuralProperty");
        }
    }
}
