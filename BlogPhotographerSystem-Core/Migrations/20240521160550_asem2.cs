using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace BlogPhotographerSystem_Core.Migrations
{
    /// <inheritdoc />
    public partial class asem2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserType",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 606, DateTimeKind.Local).AddTicks(8791),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 544, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 606, DateTimeKind.Local).AddTicks(4759),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 544, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(9065),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 544, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(5717),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 543, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 543, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(594),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 543, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Article = table.Column<string>(type: "longtext", nullable: false),
                    BlogDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(5628)),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(4680)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.CheckConstraint("CH_Blog_Title", "LENGTH(Title) >= 5");
                    table.ForeignKey(
                        name: "FK_Blogs_Users_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Problems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Purpose = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(8778)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problems", x => x.Id);
                    table.CheckConstraint("CH_Problem_Purpose", "NOT (Purpose REGEXP '[0-9~!@#$%^&*()_+=-]')");
                    table.CheckConstraint("CH_Problem_Title", "NOT (Title REGEXP '[0-9~!@#$%^&*()_+=-]')");
                    table.ForeignKey(
                        name: "FK_Problems_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Problems_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BlogAttachements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(type: "longtext", nullable: false),
                    FileName = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    FileType = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BlogID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 608, DateTimeKind.Local).AddTicks(3144)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogAttachements", x => x.Id);
                    table.CheckConstraint("CH_BlogAttachement_FileName", "NOT (FileName REGEXP '[0-9~!@#$%^&*()_+=-]')");
                    table.ForeignKey(
                        name: "FK_BlogAttachements_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BlogAttachements_BlogID",
                table: "BlogAttachements",
                column: "BlogID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorID",
                table: "Blogs",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Problems_OrderID",
                table: "Problems",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Problems_UserID",
                table: "Problems",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogAttachements");

            migrationBuilder.DropTable(
                name: "Problems");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "UserType",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 544, DateTimeKind.Local).AddTicks(6702),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 606, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Services",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 544, DateTimeKind.Local).AddTicks(2703),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 606, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 544, DateTimeKind.Local).AddTicks(1135),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Logins",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 543, DateTimeKind.Local).AddTicks(7810),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "ContactRequests",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 543, DateTimeKind.Local).AddTicks(9376),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 5, 19, 19, 14, 43, 543, DateTimeKind.Local).AddTicks(3101),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 5, 21, 19, 5, 50, 605, DateTimeKind.Local).AddTicks(594));
        }
    }
}
