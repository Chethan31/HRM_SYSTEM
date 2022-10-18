using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResourceManagementSystem.Migrations
{
    public partial class newupdat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "street2",
                table: "addressInfo",
                newName: "Street2");

            migrationBuilder.RenameColumn(
                name: "street1",
                table: "addressInfo",
                newName: "Street1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street2",
                table: "addressInfo",
                newName: "street2");

            migrationBuilder.RenameColumn(
                name: "Street1",
                table: "addressInfo",
                newName: "street1");
        }
    }
}
