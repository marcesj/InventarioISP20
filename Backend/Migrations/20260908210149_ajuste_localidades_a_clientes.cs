using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ajuste_localidades_a_clientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Firstname", "Lastname" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 8, 18, 1, 48, 686, DateTimeKind.Unspecified).AddTicks(1140), new TimeSpan(0, -3, 0, 0, 0)), "Marcelo", "Albertissi" });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 8, 18, 1, 48, 686, DateTimeKind.Unspecified).AddTicks(1191), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 8, 18, 1, 48, 686, DateTimeKind.Unspecified).AddTicks(1193), new TimeSpan(0, -3, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "Firstname", "Lastname" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 5, 19, 31, 40, 37, DateTimeKind.Unspecified).AddTicks(5370), new TimeSpan(0, -3, 0, 0, 0)), "Juan", "Perez" });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 5, 19, 31, 40, 37, DateTimeKind.Unspecified).AddTicks(5411), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_at",
                value: new DateTimeOffset(new DateTime(2026, 9, 5, 19, 31, 40, 37, DateTimeKind.Unspecified).AddTicks(5413), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
