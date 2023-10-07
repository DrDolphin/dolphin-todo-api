using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinTodoWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class UserTableUsernameFixUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usesname",
                table: "User",
                newName: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "Usesname");
        }
    }
}
