using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleEmployee.Migrations
{
    public partial class addedtableemployemasterdetils : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeMasterId",
                table: "EmpMaster");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeMasterId",
                table: "EmpMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
