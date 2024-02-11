using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoriaWinForm.Migrations
{
    /// <inheritdoc />
    public partial class AddtblCarsaddcolumnAddedByUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddedByUserId",
                table: "tblCars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblCars_AddedByUserId",
                table: "tblCars",
                column: "AddedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCars_tblUsers_AddedByUserId",
                table: "tblCars",
                column: "AddedByUserId",
                principalTable: "tblUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCars_tblUsers_AddedByUserId",
                table: "tblCars");

            migrationBuilder.DropIndex(
                name: "IX_tblCars_AddedByUserId",
                table: "tblCars");

            migrationBuilder.DropColumn(
                name: "AddedByUserId",
                table: "tblCars");
        }
    }
}
