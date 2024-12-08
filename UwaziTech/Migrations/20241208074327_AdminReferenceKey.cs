using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UwaziTech.Migrations
{
    /// <inheritdoc />
    public partial class AdminReferenceKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Reference",
                table: "AdminDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminDetail",
                table: "AdminDetail",
                column: "Reference");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminDetail",
                table: "AdminDetail");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "AdminDetail");
        }
    }
}
