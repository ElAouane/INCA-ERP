using Microsoft.EntityFrameworkCore.Migrations;

namespace Appuntamenti.Data.Migrations
{
    public partial class AddAminTasksToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminTask",
                table: "AdminTask");

            migrationBuilder.RenameTable(
                name: "AdminTask",
                newName: "AdminTasks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminTasks",
                table: "AdminTasks",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminTasks",
                table: "AdminTasks");

            migrationBuilder.RenameTable(
                name: "AdminTasks",
                newName: "AdminTask");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminTask",
                table: "AdminTask",
                column: "Id");
        }
    }
}
