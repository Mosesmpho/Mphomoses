using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mphomoses.Migrations
{
    /// <inheritdoc />
    public partial class SecondCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facilitators",
                columns: table => new
                {
                    FacilitatorsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilitatorsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilitatorsSurname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilitators", x => x.FacilitatorsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facilitators");
        }
    }
}
