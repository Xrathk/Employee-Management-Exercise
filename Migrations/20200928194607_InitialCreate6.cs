using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndeavorTest.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creation Date",
                table: "Skill");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Skill",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Skill");

            migrationBuilder.AddColumn<DateTime>(
                name: "Creation Date",
                table: "Skill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
