using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmwebCloneBackend.Migrations
{
    /// <inheritdoc />
    public partial class detailedfilminfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(7382),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 25, 12, 19, 23, 854, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(2672),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 25, 12, 19, 23, 854, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Forums",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(5491),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 25, 12, 19, 23, 854, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.AddColumn<string>(
                name: "BannerPath",
                table: "Films",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Films",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(2208),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 25, 12, 19, 23, 854, DateTimeKind.Utc).AddTicks(1133));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerPath",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Films");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 12, 19, 23, 854, DateTimeKind.Utc).AddTicks(5861),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 12, 19, 23, 854, DateTimeKind.Utc).AddTicks(1609),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Forums",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 12, 19, 23, 854, DateTimeKind.Utc).AddTicks(4118),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 12, 19, 23, 854, DateTimeKind.Utc).AddTicks(1133),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(2208));
        }
    }
}
