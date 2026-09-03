using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ProvinciaId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localidades_Provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true, defaultValueSql: "NOW()"),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Dni = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    LocalidadId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Argentina" },
                    { 2, false, "Brasil" },
                    { 3, false, "Chile" }
                });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Buenos Aires" },
                    { 2, false, "Córdoba" },
                    { 3, false, "Chile" }
                });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "IsDeleted", "Name", "ProvinciaId" },
                values: new object[,]
                {
                    { 1, false, "Buenos Aires", 1 },
                    { 2, false, "Córdoba", 2 },
                    { 3, false, "Santa Fe", 3 },
                    { 4, false, "Rosario", 3 },
                    { 5, false, "San Justo", 3 }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Address", "Created_at", "Dni", "Firstname", "IsDeleted", "Lastname", "LocalidadId" },
                values: new object[,]
                {
                    { 1, "Calle Falsa 123", new DateTimeOffset(new DateTime(2026, 9, 3, 16, 42, 52, 303, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, -3, 0, 0, 0)), "12345678", "Juan", false, "Perez", 5 },
                    { 2, "Avenida Siempre Viva 456", new DateTimeOffset(new DateTime(2026, 9, 3, 16, 42, 52, 303, DateTimeKind.Unspecified).AddTicks(3913), new TimeSpan(0, -3, 0, 0, 0)), "87654321", "Maria", false, "Gomez", 5 },
                    { 3, "Calle Real 789", new DateTimeOffset(new DateTime(2026, 9, 3, 16, 42, 52, 303, DateTimeKind.Unspecified).AddTicks(3915), new TimeSpan(0, -3, 0, 0, 0)), "11223344", "Pedro", false, "Lopez", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_LocalidadId",
                table: "Clientes",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_ProvinciaId",
                table: "Localidades",
                column: "ProvinciaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "Provincias");
        }
    }
}
