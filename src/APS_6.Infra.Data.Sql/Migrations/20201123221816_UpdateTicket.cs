using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APS_6.Infra.Data.Sql.Migrations
{
    public partial class UpdateTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Ticket",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeadlineDate",
                table: "Ticket",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "DeadlineDate",
                table: "Ticket");
        }
    }
}
