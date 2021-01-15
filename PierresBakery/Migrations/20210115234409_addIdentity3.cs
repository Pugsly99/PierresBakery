using Microsoft.EntityFrameworkCore.Migrations;

namespace PierresBakery.Migrations
{
    public partial class addIdentity3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_Treats_UserId",
                table: "Treats");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Treats",
                newName: "User");

            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Treats",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User",
                table: "Treats",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Treats",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treats_UserId",
                table: "Treats",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
