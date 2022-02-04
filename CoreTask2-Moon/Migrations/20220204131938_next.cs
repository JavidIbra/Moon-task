using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreTask2_Moon.Migrations
{
    public partial class next : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    For = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pricings");
        }
    }
}
