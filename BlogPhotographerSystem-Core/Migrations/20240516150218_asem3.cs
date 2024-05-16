using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPhotographerSystem_Core.Migrations
{
    /// <inheritdoc />
    public partial class asem3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 939, DateTimeKind.Local).AddTicks(8468),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 405, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 939, DateTimeKind.Local).AddTicks(2499),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 404, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 939, DateTimeKind.Local).AddTicks(46),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 403, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginTime",
                table: "Logins",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 938, DateTimeKind.Local).AddTicks(4812),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 402, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 938, DateTimeKind.Local).AddTicks(7234),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 403, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 937, DateTimeKind.Local).AddTicks(8749),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 401, DateTimeKind.Local).AddTicks(7842));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 405, DateTimeKind.Local).AddTicks(753),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 939, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 404, DateTimeKind.Local).AddTicks(979),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 939, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 403, DateTimeKind.Local).AddTicks(7190),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 939, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginTime",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 402, DateTimeKind.Local).AddTicks(9735),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 938, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 403, DateTimeKind.Local).AddTicks(2686),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 938, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 15, 18, 44, 55, 401, DateTimeKind.Local).AddTicks(7842),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 16, 18, 2, 17, 937, DateTimeKind.Local).AddTicks(8749));
        }
    }
}
