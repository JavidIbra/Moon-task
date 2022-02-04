using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreTask2_Moon.Migrations
{
    public partial class color : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TextColor",
                table: "Pricings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TextColor",
                table: "Pricings");
        }
    }
}
