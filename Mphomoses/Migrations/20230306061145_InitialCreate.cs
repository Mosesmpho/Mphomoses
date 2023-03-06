using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mphomoses.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Learners",
                columns: table => new
                {
                    LearnersId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LearnersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LearnersSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LearnersIdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Learners", x => x.LearnersId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Learners");
        }
    }
}
