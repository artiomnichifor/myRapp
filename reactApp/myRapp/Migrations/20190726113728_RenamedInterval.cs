using Microsoft.EntityFrameworkCore.Migrations;

namespace myRapp.Migrations
{
    public partial class RenamedInterval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Sites",
                newName: "Interval");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Interval",
                table: "Sites",
                newName: "MyProperty");
        }
    }
}
