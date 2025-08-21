using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lawyer.api.lawyers.datastore.mssql.Migrations
{
    /// <inheritdoc />
    public partial class AddPracticeAreas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PracticeAreas",
                schema: "lawyer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCountry = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TechnicalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticeAreas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PracticeAreas",
                schema: "lawyer");
        }
    }
}
