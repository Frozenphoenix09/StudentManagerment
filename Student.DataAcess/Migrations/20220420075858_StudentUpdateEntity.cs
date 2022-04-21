using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student.DataAcess.Migrations
{
    public partial class StudentUpdateEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DatOfBirth",
                table: "Students",
                newName: "DateOfBirth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Students",
                newName: "DatOfBirth");
        }
    }
}
