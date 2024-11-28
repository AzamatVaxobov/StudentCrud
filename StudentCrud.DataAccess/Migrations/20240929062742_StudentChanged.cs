using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentCrud.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class StudentChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailPassword",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailPassword",
                table: "Students");
        }
    }
}
