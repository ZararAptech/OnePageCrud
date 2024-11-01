using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crudapplication.Migrations
{
    /// <inheritdoc />
    public partial class _1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "studentId",
                table: "Assignments");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Assignments",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "duedate",
                table: "Assignments",
                newName: "Duedate");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Assignments",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Assignments",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Duedate",
                table: "Assignments",
                newName: "duedate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Assignments",
                newName: "description");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Assignments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "studentId",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
