using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPhotographerSystem_Core.MySQLMigrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 856, DateTimeKind.Local).AddTicks(782)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.CheckConstraint("CH_Category_Title", "LEN(Title) >= 5");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 858, DateTimeKind.Local).AddTicks(2828)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.CheckConstraint("CH_User_Email", "Email LIKE '%_@__%.__%' AND Email NOT LIKE '%[^A-Za-z0-9._-]%'");
                    table.CheckConstraint("CH_User_FirstName", "FirstName NOT LIKE '%[0-9]%' AND FirstName NOT LIKE '%[~!@#$%^&*()_+=-]%'");
                    table.CheckConstraint("CH_User_LastName", "LastName NOT LIKE '%[0-9]%' AND LastName NOT LIKE '%[~!@#$%^&*()_+=-]%'");
                    table.CheckConstraint("CH_User_Phone", "Phone LIKE '009627________'");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsHaveDiscount = table.Column<bool>(type: "bit", nullable: false),
                    DisacountAmount = table.Column<float>(type: "real", nullable: true),
                    DiscountType = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 857, DateTimeKind.Local).AddTicks(8414)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.CheckConstraint("CH_Service_Name", "LEN(Name) >= 4");
                    table.ForeignKey(
                        name: "FK_Services_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Article = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 860, DateTimeKind.Local).AddTicks(3815)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.CheckConstraint("CH_Blog_Title", "LEN(Title) >= 5");
                    table.ForeignKey(
                        name: "FK_Blogs_Users_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<float>(type: "real", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 856, DateTimeKind.Local).AddTicks(8152)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactRequests", x => x.Id);
                    table.CheckConstraint("CH_ContactRequest_ClientName", "LEN(ClientName) >= 5");
                    table.CheckConstraint("CH_ContactRequest_Email", "Email LIKE '%@%.com'");
                    table.CheckConstraint("CH_ContactRequest_Phone", "Phone LIKE '009627________'");
                    table.ForeignKey(
                        name: "FK_ContactRequests_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastLoginTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsLoggedIn = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 856, DateTimeKind.Local).AddTicks(5790)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.CheckConstraint("CH_Login_Password", "LEN(Password) >= 6 AND Password LIKE '%[A-Z]%' AND Password LIKE '%[a-z]%' AND Password LIKE '%[0-9]%' AND Password LIKE '%[+=)(*&^%$#@!~]%'");
                    table.ForeignKey(
                        name: "FK_Logins_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    ServiceID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 856, DateTimeKind.Local).AddTicks(9963)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.CheckConstraint("CH_Order_Title", "LEN(Title) >= 5");
                    table.ForeignKey(
                        name: "FK_Orders_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BlogAttachements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FileType = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    BlogID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 860, DateTimeKind.Local).AddTicks(1922)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogAttachements", x => x.Id);
                    table.CheckConstraint("CH_BlogAttachement_FileName", "LEN(FileName) >= 3");
                    table.ForeignKey(
                        name: "FK_BlogAttachements_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 861, DateTimeKind.Local).AddTicks(5278)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.CheckConstraint("CH_Comment_AuthorName", "LEN(AuthorName) >= 3");
                    table.CheckConstraint("CH_Comment_Content", "LEN(Content) >= 3");
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FileType = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 861, DateTimeKind.Local).AddTicks(3087)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                    table.CheckConstraint("CH_Gallery_FileName", "LEN(FileName) >= 3");
                    table.ForeignKey(
                        name: "FK_Galleries_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Galleries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Problems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 10, 10, 22, 59, 40, 861, DateTimeKind.Local).AddTicks(968)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    ModifiedUserId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problems", x => x.Id);
                    table.CheckConstraint("CH_Problem_Purpose", "Purpose NOT LIKE '%[0-9]%' AND Purpose NOT LIKE '%[~!@#$%^&*()_+=-]%'");
                    table.CheckConstraint("CH_Problem_Title", "Title NOT LIKE '%[0-9]%' AND Title NOT LIKE '%[~!@#$%^&*()_+=-]%'");
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogAttachements_BlogID",
                table: "BlogAttachements",
                column: "BlogID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorID",
                table: "Blogs",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactRequests_UserID",
                table: "ContactRequests",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_OrderID",
                table: "Galleries",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_UserId",
                table: "Galleries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_Password",
                table: "Logins",
                column: "Password",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UserID",
                table: "Logins",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_UserName",
                table: "Logins",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ServiceID",
                table: "Orders",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Problems_OrderID",
                table: "Problems",
                column: "OrderID",
                unique: true,
                filter: "[OrderID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Problems_UserID",
                table: "Problems",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryID",
                table: "Services",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone",
                table: "Users",
                column: "Phone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogAttachements");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ContactRequests");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Problems");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
