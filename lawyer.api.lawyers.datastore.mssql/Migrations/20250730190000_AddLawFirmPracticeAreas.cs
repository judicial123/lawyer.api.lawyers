using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lawyer.api.lawyers.datastore.mssql.Migrations
{
    /// <inheritdoc />
    public partial class AddLawFirmPracticeAreas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LawFirmPracticeAreas",
                schema: "lawyer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLawFirm = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPracticeArea = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawFirmPracticeAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LawFirmPracticeAreas_LawFirms_IdLawFirm",
                        column: x => x.IdLawFirm,
                        principalSchema: "lawyer",
                        principalTable: "LawFirms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LawFirmPracticeAreas_PracticeAreas_IdPracticeArea",
                        column: x => x.IdPracticeArea,
                        principalSchema: "lawyer",
                        principalTable: "PracticeAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LawFirmPracticeAreas_IdLawFirm",
                schema: "lawyer",
                table: "LawFirmPracticeAreas",
                column: "IdLawFirm");

            migrationBuilder.CreateIndex(
                name: "IX_LawFirmPracticeAreas_IdPracticeArea",
                schema: "lawyer",
                table: "LawFirmPracticeAreas",
                column: "IdPracticeArea");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LawFirmPracticeAreas",
                schema: "lawyer");
        }
    }
}

