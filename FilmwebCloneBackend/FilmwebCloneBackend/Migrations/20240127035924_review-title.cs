using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmwebCloneBackend.Migrations
{
    /// <inheritdoc />
    public partial class reviewtitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 27, 3, 59, 23, 931, DateTimeKind.Utc).AddTicks(9869),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Reviews",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 27, 3, 59, 23, 931, DateTimeKind.Utc).AddTicks(5074),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Forums",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 27, 3, 59, 23, 931, DateTimeKind.Utc).AddTicks(7909),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 27, 3, 59, 23, 931, DateTimeKind.Utc).AddTicks(4644),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(2208));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Reviews");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(7382),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 27, 3, 59, 23, 931, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(2672),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 27, 3, 59, 23, 931, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Forums",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(5491),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 27, 3, 59, 23, 931, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 26, 12, 53, 29, 428, DateTimeKind.Utc).AddTicks(2208),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 27, 3, 59, 23, 931, DateTimeKind.Utc).AddTicks(4644));
        }
    }
}
