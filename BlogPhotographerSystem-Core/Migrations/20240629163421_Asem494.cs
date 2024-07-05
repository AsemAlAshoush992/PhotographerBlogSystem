using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPhotographerSystem_Core.Migrations
{
    /// <inheritdoc />
    public partial class Asem494 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 989, DateTimeKind.Local).AddTicks(9260),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 788, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 989, DateTimeKind.Local).AddTicks(2082),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 788, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 992, DateTimeKind.Local).AddTicks(694),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 987, DateTimeKind.Local).AddTicks(7695),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 787, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 987, DateTimeKind.Local).AddTicks(4225),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 786, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Galleries",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Galleries",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 992, DateTimeKind.Local).AddTicks(2781),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 987, DateTimeKind.Local).AddTicks(6117),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 787, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 986, DateTimeKind.Local).AddTicks(9393),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 786, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 991, DateTimeKind.Local).AddTicks(6470),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 789, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 991, DateTimeKind.Local).AddTicks(7699),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "BlogAttachements",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 991, DateTimeKind.Local).AddTicks(4709),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 789, DateTimeKind.Local).AddTicks(7780));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 788, DateTimeKind.Local).AddTicks(3972),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 989, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 788, DateTimeKind.Local).AddTicks(267),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 989, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(3258),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 992, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 787, DateTimeKind.Local).AddTicks(2702),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 987, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 786, DateTimeKind.Local).AddTicks(9195),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 987, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Galleries",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Galleries",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(5173),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 992, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 787, DateTimeKind.Local).AddTicks(1116),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 987, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 786, DateTimeKind.Local).AddTicks(4489),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 986, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 789, DateTimeKind.Local).AddTicks(9373),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 991, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 790, DateTimeKind.Local).AddTicks(479),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 991, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "BlogAttachements",
                type: "varchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 29, 19, 28, 51, 789, DateTimeKind.Local).AddTicks(7780),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 6, 29, 19, 34, 20, 991, DateTimeKind.Local).AddTicks(4709));
        }
    }
}
