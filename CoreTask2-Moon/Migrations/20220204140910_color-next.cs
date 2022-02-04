using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreTask2_Moon.Migrations
{
    public partial class colornext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ButtonColor",
                table: "Pricings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButtonColor",
                table: "Pricings");
        }
    }
}
