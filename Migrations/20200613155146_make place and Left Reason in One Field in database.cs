using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApplying.Migrations
{
    public partial class makeplaceandLeftReasoninOneFieldindatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeftReason",
                table: "PreviousWorks");

            migrationBuilder.DropColumn(
                name: "PlaceName",
                table: "PreviousWorks");

            migrationBuilder.AddColumn<string>(
                name: "PlaceAndLefReason",
                table: "PreviousWorks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceAndLefReason",
                table: "PreviousWorks");

            migrationBuilder.AddColumn<string>(
                name: "LeftReason",
                table: "PreviousWorks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceName",
                table: "PreviousWorks",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
