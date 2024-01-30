using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmwebCloneBackend.Migrations
{
    /// <inheritdoc />
    public partial class cascadedeletionofmessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 28, 1, 20, 50, 30, DateTimeKind.Utc).AddTicks(404),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 28, 1, 10, 6, 605, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 28, 1, 20, 50, 29, DateTimeKind.Utc).AddTicks(7096),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 28, 1, 10, 6, 605, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Forums",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 28, 1, 20, 50, 29, DateTimeKind.Utc).AddTicks(9112),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 28, 1, 10, 6, 605, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 28, 1, 20, 50, 29, DateTimeKind.Utc).AddTicks(6647),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 28, 1, 10, 6, 605, DateTimeKind.Utc).AddTicks(4840));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 28, 1, 10, 6, 605, DateTimeKind.Utc).AddTicks(8473),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 28, 1, 20, 50, 30, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 28, 1, 10, 6, 605, DateTimeKind.Utc).AddTicks(5259),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 28, 1, 20, 50, 29, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Forums",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 28, 1, 10, 6, 605, DateTimeKind.Utc).AddTicks(7197),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 28, 1, 20, 50, 29, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 28, 1, 10, 6, 605, DateTimeKind.Utc).AddTicks(4840),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 1, 28, 1, 20, 50, 29, DateTimeKind.Utc).AddTicks(6647));
        }
    }
}
