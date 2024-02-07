using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoriaWinForm.Migrations
{
    /// <inheritdoc />
    public partial class AddtblCarImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCarImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Priority = table.Column<short>(type: "smallint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCarImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCarImages_tblCars_CarId",
                        column: x => x.CarId,
                        principalTable: "tblCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCarImages_CarId",
                table: "tblCarImages",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCarImages");
        }
    }
}
