using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPhotographerSystem_Core.Migrations
{
    /// <inheritdoc />
    public partial class Asem2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 405, DateTimeKind.Local).AddTicks(753),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 93, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 404, DateTimeKind.Local).AddTicks(979),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 92, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 403, DateTimeKind.Local).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 92, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 402, DateTimeKind.Local).AddTicks(9735),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 92, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 403, DateTimeKind.Local).AddTicks(2686),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 92, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 401, DateTimeKind.Local).AddTicks(7842),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 91, DateTimeKind.Local).AddTicks(8001));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 93, DateTimeKind.Local).AddTicks(645),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 405, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 92, DateTimeKind.Local).AddTicks(6897),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 404, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 92, DateTimeKind.Local).AddTicks(5426),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 403, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 92, DateTimeKind.Local).AddTicks(2348),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 402, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 92, DateTimeKind.Local).AddTicks(3791),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 403, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 25, 46, 91, DateTimeKind.Local).AddTicks(8001),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 401, DateTimeKind.Local).AddTicks(7842));
        }
    }
}
