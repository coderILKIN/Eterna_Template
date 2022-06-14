using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna_Template.Migrations
{
    public partial class CreateSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnvelopeIcon = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneIcon = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    TwitterIcon = table.Column<string>(nullable: true),
                    FacebookIcon = table.Column<string>(nullable: true),
                    InstagramIcon = table.Column<string>(nullable: true),
                    LinkedinIcon = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
