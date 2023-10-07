using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinTodoWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class TodoItemAddUserIdUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "TodoItem",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TodoItem");
        }
    }
}
