using Microsoft.EntityFrameworkCore.Migrations;

namespace IndeavorTest.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
