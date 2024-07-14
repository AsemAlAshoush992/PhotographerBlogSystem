using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPhotographerSystem_Core.Migrations
{
    /// <inheritdoc />
    public partial class AsemFinal2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CH_Login_Password",
                table: "Logins");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 556, DateTimeKind.Local).AddTicks(6398),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 66, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 556, DateTimeKind.Local).AddTicks(536),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 66, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 559, DateTimeKind.Local).AddTicks(1093),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 69, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 554, DateTimeKind.Local).AddTicks(7872),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 65, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 554, DateTimeKind.Local).AddTicks(2919),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 65, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Galleries",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 559, DateTimeKind.Local).AddTicks(3335),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 69, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 554, DateTimeKind.Local).AddTicks(5233),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 65, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 553, DateTimeKind.Local).AddTicks(6944),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 64, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 558, DateTimeKind.Local).AddTicks(6342),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 68, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 558, DateTimeKind.Local).AddTicks(7740),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 68, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 558, DateTimeKind.Local).AddTicks(4365),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 68, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.AddCheckConstraint(
                name: "CH_Login_Password",
                table: "Logins",
                sql: "Password REGEXP '^(?=.*[A-Z])(?=(?:.*[a-z]){6,})(?=.*[0-9])(?=.*[+=)(*&^%$#@!~]).*$'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CH_Login_Password",
                table: "Logins");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 66, DateTimeKind.Local).AddTicks(8608),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 556, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 66, DateTimeKind.Local).AddTicks(4481),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 556, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Problems",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 69, DateTimeKind.Local).AddTicks(790),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 559, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 65, DateTimeKind.Local).AddTicks(6587),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 554, DateTimeKind.Local).AddTicks(7872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 65, DateTimeKind.Local).AddTicks(2738),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 554, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Galleries",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 69, DateTimeKind.Local).AddTicks(3156),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 559, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 65, DateTimeKind.Local).AddTicks(4866),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 554, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 64, DateTimeKind.Local).AddTicks(7485),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 553, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 68, DateTimeKind.Local).AddTicks(6014),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 558, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 68, DateTimeKind.Local).AddTicks(7214),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 558, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "BlogAttachements",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 1, 4, 38, 68, DateTimeKind.Local).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 7, 6, 21, 41, 8, 558, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.AddCheckConstraint(
                name: "CH_Login_Password",
                table: "Logins",
                sql: "Password REGEXP '[A-Z]{1,}[a-z]{5,}[0-9]+[+=)(*&^%$#@!~]+'");
        }
    }
}
