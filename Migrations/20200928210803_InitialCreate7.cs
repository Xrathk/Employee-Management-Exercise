using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndeavorTest.Migrations
{
    public partial class InitialCreate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skill_Employee_EmployeeId",
                table: "Skill");

            migrationBuilder.DropIndex(
                name: "IX_Skill_EmployeeId",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Skill");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Skill",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Skill");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Skill",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skill_EmployeeId",
                table: "Skill",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_Employee_EmployeeId",
                table: "Skill",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
