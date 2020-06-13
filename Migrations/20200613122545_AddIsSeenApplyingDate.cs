using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApplying.Migrations
{
    public partial class AddIsSeenApplyingDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ApplyingDateTime",
                table: "Appliers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsSeen",
                table: "Appliers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Appliers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplyingDateTime",
                table: "Appliers");

            migrationBuilder.DropColumn(
                name: "IsSeen",
                table: "Appliers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Appliers");
        }
    }
}
