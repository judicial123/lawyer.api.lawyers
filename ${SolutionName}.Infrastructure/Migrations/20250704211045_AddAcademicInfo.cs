using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ${SolutionName}.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAcademicInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LawyerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademicInfo_Lawyers_LawyerId",
                        column: x => x.LawyerId,
                        principalTable: "Lawyers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicInfo_LawyerId",
                table: "AcademicInfo",
                column: "LawyerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicInfo");
        }
    }
}

