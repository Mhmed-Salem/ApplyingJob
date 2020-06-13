using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApplying.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Government = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    ExpectedSalary = table.Column<double>(nullable: false),
                    MicrosoftOfficeGrade = table.Column<double>(nullable: false),
                    EnglishGrade = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    GraduatingFaculty = table.Column<string>(nullable: true),
                    GraduatingYear = table.Column<int>(nullable: false),
                    GraduatingGrade = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appliers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperienceItem = table.Column<string>(nullable: true),
                    ApplierId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Appliers_ApplierId",
                        column: x => x.ApplierId,
                        principalTable: "Appliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreviousWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(nullable: true),
                    LeftReason = table.Column<string>(nullable: true),
                    ApplierId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreviousWorks_Appliers_ApplierId",
                        column: x => x.ApplierId,
                        principalTable: "Appliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appliers_PositionId",
                table: "Appliers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_ApplierId",
                table: "Experiences",
                column: "ApplierId");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousWorks_ApplierId",
                table: "PreviousWorks",
                column: "ApplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "PreviousWorks");

            migrationBuilder.DropTable(
                name: "Appliers");

            migrationBuilder.DropTable(
                name: "Positions");
        }
    }
}
