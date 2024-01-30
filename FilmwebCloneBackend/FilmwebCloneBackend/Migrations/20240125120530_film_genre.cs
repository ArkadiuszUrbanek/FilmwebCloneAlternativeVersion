using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmwebCloneBackend.Migrations
{
    /// <inheritdoc />
    public partial class film_genre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 12, 5, 30, 344, DateTimeKind.Utc).AddTicks(1273),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 20, 1, 28, 47, 278, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 12, 5, 30, 343, DateTimeKind.Utc).AddTicks(6665),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 20, 1, 28, 47, 277, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Forums",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 12, 5, 30, 343, DateTimeKind.Utc).AddTicks(9438),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 20, 1, 28, 47, 278, DateTimeKind.Utc).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "PosterPath",
                keyValue: null,
                column: "PosterPath",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PosterPath",
                table: "Films",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Duration",
                table: "Films",
                type: "time(6)",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0),
                oldClrType: typeof(TimeOnly),
                oldType: "time(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Films",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 25, 12, 5, 30, 343, DateTimeKind.Utc).AddTicks(6261),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 20, 1, 28, 47, 277, DateTimeKind.Utc).AddTicks(8831));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Films");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 20, 1, 28, 47, 278, DateTimeKind.Utc).AddTicks(3564),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 25, 12, 5, 30, 344, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 20, 1, 28, 47, 277, DateTimeKind.Utc).AddTicks(9226),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 25, 12, 5, 30, 343, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Forums",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 20, 1, 28, 47, 278, DateTimeKind.Utc).AddTicks(1834),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 25, 12, 5, 30, 343, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.AlterColumn<string>(
                name: "PosterPath",
                table: "Films",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Duration",
                table: "Films",
                type: "time(6)",
                nullable: true,
                oldClrType: typeof(TimeOnly),
                oldType: "time(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 20, 1, 28, 47, 277, DateTimeKind.Utc).AddTicks(8831),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 25, 12, 5, 30, 343, DateTimeKind.Utc).AddTicks(6261));
        }
    }
}
