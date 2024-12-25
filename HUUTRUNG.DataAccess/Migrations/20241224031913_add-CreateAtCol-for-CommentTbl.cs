using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HUUTRUNG.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCreateAtColforCommentTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateAt",
                table: "Comments",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateAt",
                table: "Comments");
        }
    }
}
