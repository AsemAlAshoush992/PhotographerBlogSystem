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
            migrationBuilder.DropCheckConstraint(
                name: "CH_BlogAttachement_FileName",
                table: "BlogAttachements");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 516, DateTimeKind.Local).AddTicks(1047),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 606, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 515, DateTimeKind.Local).AddTicks(7132),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 606, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 518, DateTimeKind.Local).AddTicks(2119),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 515, DateTimeKind.Local).AddTicks(1018),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 514, DateTimeKind.Local).AddTicks(7561),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 514, DateTimeKind.Local).AddTicks(9152),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 514, DateTimeKind.Local).AddTicks(2759),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 517, DateTimeKind.Local).AddTicks(8064),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 517, DateTimeKind.Local).AddTicks(9112),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 517, DateTimeKind.Local).AddTicks(6263),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.AddCheckConstraint(
                name: "CH_BlogAttachement_FileName",
                table: "BlogAttachements",
                sql: "NOT (FileName REGEXP '[~!@#$%^&*()_+=-]')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CH_BlogAttachement_FileName",
                table: "BlogAttachements");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 606, DateTimeKind.Local).AddTicks(8791),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 516, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 606, DateTimeKind.Local).AddTicks(4759),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 515, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(8778),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 518, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(9065),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 515, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(5717),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 514, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 514, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(594),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 514, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(4680),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 517, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(5628),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 517, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(3144),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 22, 21, 48, 24, 517, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.AddCheckConstraint(
                name: "CH_BlogAttachement_FileName",
                table: "BlogAttachements",
                sql: "NOT (FileName REGEXP '[0-9~!@#$%^&*()_+=-]')");
        }
    }
}
