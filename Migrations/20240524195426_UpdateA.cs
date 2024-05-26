using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoItemApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "usuario",
                table: "Users",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "usuario",
                table: "ToDoItems",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "usuario",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "usuario",
                table: "ToDoItems");
        }
    }
}
