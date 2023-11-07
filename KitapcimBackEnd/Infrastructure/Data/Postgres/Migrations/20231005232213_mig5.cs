using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_User_UserID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_UserID",
                table: "Books");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_User_BookID",
                table: "Books",
                column: "BookID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_User_BookID",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserID",
                table: "Books",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_User_UserID",
                table: "Books",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
