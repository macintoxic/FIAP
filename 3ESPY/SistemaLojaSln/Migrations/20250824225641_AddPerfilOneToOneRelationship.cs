using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SistemaLoja.Migrations
{
    /// <inheritdoc />
    public partial class AddPerfilOneToOneRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perfis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    DataUltimaVisita = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perfis_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Perfis",
                columns: new[] { "Id", "ClienteId", "DataUltimaVisita", "Email" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "joao.perfil@email.com" },
                    { 2, 2, new DateTime(2025, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "maria.perfil@email.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perfis_ClienteId",
                table: "Perfis",
                column: "ClienteId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perfis");
        }
    }
}
