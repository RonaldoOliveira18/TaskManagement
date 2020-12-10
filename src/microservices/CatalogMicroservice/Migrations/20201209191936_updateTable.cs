using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TasksMicroservice.Migrations
{
    public partial class updateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdStatus",
                table: "tasks");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dtScheduling",
                table: "tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "tasks");

            migrationBuilder.DropColumn(
                name: "dtScheduling",
                table: "tasks");

            migrationBuilder.AddColumn<int>(
                name: "IdStatus",
                table: "tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
