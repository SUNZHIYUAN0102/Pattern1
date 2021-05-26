using Microsoft.EntityFrameworkCore.Migrations;

namespace Pattern1.Migrations.ApplicationDbContext3Migrations
{
    public partial class AddLookUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LookUps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    min = table.Column<int>(type: "int", nullable: false),
                    max = table.Column<int>(type: "int", nullable: false),
                    shard = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LookUps");
        }
    }
}
