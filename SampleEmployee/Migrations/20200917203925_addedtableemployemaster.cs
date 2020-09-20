using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleEmployee.Migrations
{
    public partial class addedtableemployemaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Createdby = table.Column<int>(nullable: false),
                    Modifiedby = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Isdeleted = table.Column<bool>(nullable: false),
                    Isasctive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<int>(nullable: false),
                    Region = table.Column<string>(nullable: true),
                    EmployeeMasterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpMaster", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpMaster");
        }
    }
}
