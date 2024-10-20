using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todo_app.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "timed_todo",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "timed_todo",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "timed_todo",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "timed_todo",
                newName: "is_completed");

            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "timed_todo",
                newName: "due_date");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "simple_todo",
                newName: "priority");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "simple_todo",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "simple_todo",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "simple_todo",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "simple_todo",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "simple_todo",
                newName: "is_completed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "timed_todo",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "timed_todo",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "timed_todo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "is_completed",
                table: "timed_todo",
                newName: "IsCompleted");

            migrationBuilder.RenameColumn(
                name: "due_date",
                table: "timed_todo",
                newName: "DueDate");

            migrationBuilder.RenameColumn(
                name: "priority",
                table: "simple_todo",
                newName: "Priority");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "simple_todo",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "simple_todo",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "simple_todo",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "simple_todo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "is_completed",
                table: "simple_todo",
                newName: "IsCompleted");
        }
    }
}
