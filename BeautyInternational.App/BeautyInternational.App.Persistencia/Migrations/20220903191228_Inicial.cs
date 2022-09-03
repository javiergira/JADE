using Microsoft.EntityFrameworkCore.Migrations;

namespace BeautyInternational.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "citasid",
                table: "Historias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Historias_citasid",
                table: "Historias",
                column: "citasid");

            migrationBuilder.AddForeignKey(
                name: "FK_Historias_Citas_citasid",
                table: "Historias",
                column: "citasid",
                principalTable: "Citas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historias_Citas_citasid",
                table: "Historias");

            migrationBuilder.DropIndex(
                name: "IX_Historias_citasid",
                table: "Historias");

            migrationBuilder.DropColumn(
                name: "citasid",
                table: "Historias");
        }
    }
}
