using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPhotographerSystem_Core.Migrations
{
    /// <inheritdoc />
    public partial class asem5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogAttachements_Blogs_BlogID",
                table: "BlogAttachements");

            migrationBuilder.DropIndex(
                name: "IX_ContactRequests_Email",
                table: "ContactRequests");

            migrationBuilder.DropIndex(
                name: "IX_ContactRequests_Phone",
                table: "ContactRequests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 419, DateTimeKind.Local).AddTicks(9951),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 835, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 419, DateTimeKind.Local).AddTicks(5933),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 835, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 422, DateTimeKind.Local).AddTicks(1729),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 837, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 419, DateTimeKind.Local).AddTicks(206),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 835, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 418, DateTimeKind.Local).AddTicks(6878),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 834, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactRequests",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 418, DateTimeKind.Local).AddTicks(8574),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 834, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 418, DateTimeKind.Local).AddTicks(1746),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 834, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 421, DateTimeKind.Local).AddTicks(7570),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 837, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 421, DateTimeKind.Local).AddTicks(8621),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 837, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 421, DateTimeKind.Local).AddTicks(5782),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 837, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.AlterColumn<int>(
                name: "BlogID",
                table: "BlogAttachements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogAttachements_Blogs_BlogID",
                table: "BlogAttachements",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogAttachements_Blogs_BlogID",
                table: "BlogAttachements");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 835, DateTimeKind.Local).AddTicks(8741),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 419, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 835, DateTimeKind.Local).AddTicks(5196),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 419, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 837, DateTimeKind.Local).AddTicks(7307),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 422, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 835, DateTimeKind.Local).AddTicks(379),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 419, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 834, DateTimeKind.Local).AddTicks(7261),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 418, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactRequests",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 834, DateTimeKind.Local).AddTicks(8695),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 418, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 834, DateTimeKind.Local).AddTicks(2937),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 418, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 837, DateTimeKind.Local).AddTicks(3747),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 421, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 837, DateTimeKind.Local).AddTicks(4648),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 421, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 24, 16, 59, 28, 837, DateTimeKind.Local).AddTicks(2281),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 24, 18, 52, 30, 421, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.AlterColumn<int>(
                name: "BlogID",
                table: "BlogAttachements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactRequests_Email",
                table: "ContactRequests",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactRequests_Phone",
                table: "ContactRequests",
                column: "Phone",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogAttachements_Blogs_BlogID",
                table: "BlogAttachements",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
