using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApplying.Migrations
{
    public partial class AddIsAvailabeToForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Positions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Positions");
        }
    }
}
