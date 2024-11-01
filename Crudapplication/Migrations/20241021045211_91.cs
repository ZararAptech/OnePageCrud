using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crudapplication.Migrations
{
    /// <inheritdoc />
    public partial class _91 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    tId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Teachername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teacheremail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teacherpassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Teachersubject = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.tId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
