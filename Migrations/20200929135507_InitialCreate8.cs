using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndeavorTest.Migrations
{
    public partial class InitialCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Skill");

            migrationBuilder.CreateTable(
                name: "EmploySkillRelation",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    SkillID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploySkillRelation", x => new { x.SkillID, x.EmployeeID });
                    table.ForeignKey(
                        name: "FK_EmploySkillRelation_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmploySkillRelation_Skill_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmploySkillRelation_EmployeeID",
                table: "EmploySkillRelation",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmploySkillRelation");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Skill",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
