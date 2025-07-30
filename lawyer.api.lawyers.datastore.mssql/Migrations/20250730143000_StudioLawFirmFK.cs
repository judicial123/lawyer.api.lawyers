using Microsoft.EntityFrameworkCore.Migrations;

namespace lawyer.api.lawyers.datastore.mssql.Migrations
{
    /// <inheritdoc />
    public partial class LawFirmFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Lawyers_LawFirmId",
                table: "Lawyers",
                column: "LawFirmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lawyers_LawFirms_LawFirmId",
                table: "Lawyers",
                column: "LawFirmId",
                principalTable: "LawFirms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lawyers_LawFirms_LawFirmId",
                table: "Lawyers");

            migrationBuilder.DropIndex(
                name: "IX_Lawyers_LawFirmId",
                table: "Lawyers");
        }
    }
}
