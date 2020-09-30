using Microsoft.EntityFrameworkCore.Migrations;

namespace IndeavorTest.Migrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmploySkillRelation");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Skill",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "EmploySkillRelation",
                columns: table => new
                {
                    SkillID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
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
    }
}
