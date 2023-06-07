using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCopmanyToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CopmanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CopmanyId",
                table: "AspNetUsers",
                column: "CopmanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CopmanyId",
                table: "AspNetUsers",
                column: "CopmanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CopmanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CopmanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CopmanyId",
                table: "AspNetUsers");
        }
    }
}
