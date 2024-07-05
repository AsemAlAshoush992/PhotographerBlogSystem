using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPhotographerSystem_Core.Migrations
{
    /// <inheritdoc />
    public partial class Asem555 : Migration
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
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 557, DateTimeKind.Local).AddTicks(8391),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 3, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 557, DateTimeKind.Local).AddTicks(3272),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 3, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 561, DateTimeKind.Local).AddTicks(22),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 5, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 556, DateTimeKind.Local).AddTicks(3360),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 2, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 555, DateTimeKind.Local).AddTicks(8912),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 2, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Galleries",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 561, DateTimeKind.Local).AddTicks(2464),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 5, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 556, DateTimeKind.Local).AddTicks(1309),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 2, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 555, DateTimeKind.Local).AddTicks(2658),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 1, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(3163),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 4, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(5284),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 5, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(622),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 4, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.AddCheckConstraint(
                name: "CH_BlogAttachement_FileName",
                table: "BlogAttachements",
                sql: "LENGTH(FileName) >= 3");
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
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 3, DateTimeKind.Local).AddTicks(4535),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 557, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 3, DateTimeKind.Local).AddTicks(916),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 557, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 5, DateTimeKind.Local).AddTicks(3492),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 561, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 2, DateTimeKind.Local).AddTicks(4072),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 556, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 2, DateTimeKind.Local).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 555, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Galleries",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 5, DateTimeKind.Local).AddTicks(5101),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 561, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 2, DateTimeKind.Local).AddTicks(2561),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 556, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 1, DateTimeKind.Local).AddTicks(6292),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 555, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 4, DateTimeKind.Local).AddTicks(9777),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 5, DateTimeKind.Local).AddTicks(833),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 29, 0, 5, 56, 4, DateTimeKind.Local).AddTicks(8188),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 17, 14, 26, 560, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.AddCheckConstraint(
                name: "CH_BlogAttachement_FileName",
                table: "BlogAttachements",
                sql: "NOT (FileName REGEXP '[~!@#$%^&*()_+=-]')");
        }
    }
}
