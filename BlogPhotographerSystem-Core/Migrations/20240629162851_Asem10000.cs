using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPhotographerSystem_Core.Migrations
{
    /// <inheritdoc />
    public partial class Asem10000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CH_Gallery_FileName",
                table: "Galleries");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 788, DateTimeKind.Local).AddTicks(3972),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 557, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 788, DateTimeKind.Local).AddTicks(267),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 557, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(3258),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 561, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 787, DateTimeKind.Local).AddTicks(2702),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 556, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 786, DateTimeKind.Local).AddTicks(9195),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 555, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Galleries",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(5173),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 561, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 787, DateTimeKind.Local).AddTicks(1116),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 556, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 786, DateTimeKind.Local).AddTicks(4489),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 555, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 789, DateTimeKind.Local).AddTicks(9373),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(479),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 789, DateTimeKind.Local).AddTicks(7780),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.AddCheckConstraint(
                name: "CH_Gallery_FileName",
                table: "Galleries",
                sql: "LENGTH(FileName) >= 3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CH_Gallery_FileName",
                table: "Galleries");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 557, DateTimeKind.Local).AddTicks(8391),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 788, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 557, DateTimeKind.Local).AddTicks(3272),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 788, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 561, DateTimeKind.Local).AddTicks(22),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 556, DateTimeKind.Local).AddTicks(3360),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 787, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 555, DateTimeKind.Local).AddTicks(8912),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 786, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Galleries",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 561, DateTimeKind.Local).AddTicks(2464),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 556, DateTimeKind.Local).AddTicks(1309),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 787, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 555, DateTimeKind.Local).AddTicks(2658),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 786, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(3163),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 789, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(5284),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(622),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 789, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.AddCheckConstraint(
                name: "CH_Gallery_FileName",
                table: "Galleries",
                sql: "NOT (FileName REGEXP '[~!@#$%^&*()_+=-]')");
        }
    }
}
