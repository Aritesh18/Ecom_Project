using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecom_Project_1030.DataAccess.Migrations
{
    public partial class AddTotalInWordsInOrderHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TotalInWords",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalInWords",
                table: "OrderHeaders");
        }
    }
}
