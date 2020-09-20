using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleEmployee.Migrations
{
    public partial class addedtableemployemasterdetilsgh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpMasterDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailId = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    EmployeeMasterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpMasterDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpMasterDetails");
        }
    }
}
