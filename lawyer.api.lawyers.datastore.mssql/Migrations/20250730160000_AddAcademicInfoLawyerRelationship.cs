using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lawyer.api.lawyers.datastore.mssql.Migrations
{
    /// <inheritdoc />
    public partial class AddAcademicInfoLawyerRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AcademicInfo_LawyerId",
                schema: "lawyer",
                table: "AcademicInfo",
                column: "LawyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicInfo_Lawyers_LawyerId",
                schema: "lawyer",
                table: "AcademicInfo",
                column: "LawyerId",
                principalSchema: "lawyer",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicInfo_Lawyers_LawyerId",
                schema: "lawyer",
                table: "AcademicInfo");

            migrationBuilder.DropIndex(
                name: "IX_AcademicInfo_LawyerId",
                schema: "lawyer",
                table: "AcademicInfo");
        }
    }
}
