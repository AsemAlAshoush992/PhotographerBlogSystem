﻿// <auto-generated />
using System;
using BlogPhotographerSystem_Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogPhotographerSystem_Core.Migrations
{
    [DbContext(typeof(BlogPhotographerSystemDBContext))]
    partial class BlogPhotographerSystemDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Article")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("longtext");

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BlogDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 421, DateTimeKind.Local).AddTicks(8621));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 421, DateTimeKind.Local).AddTicks(7570));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorID");

                    b.ToTable("Blogs", t =>
                        {
                            t.HasCheckConstraint("CH_Blog_Title", "LENGTH(Title) >= 5");
                        });
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.BlogAttachement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BlogID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 421, DateTimeKind.Local).AddTicks(5782));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(true)
                        .HasColumnType("varchar(25)");

                    b.Property<int>("FileType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("BlogID");

                    b.ToTable("BlogAttachements", t =>
                        {
                            t.HasCheckConstraint("CH_BlogAttachement_FileName", "NOT (FileName REGEXP '[~!@#$%^&*()_+=-]')");
                        });
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 418, DateTimeKind.Local).AddTicks(1746));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(true)
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Categories", t =>
                        {
                            t.HasCheckConstraint("CH_Category_Title", "LENGTH(Title) >= 5");
                        });
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.ContactRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Budget")
                        .HasColumnType("float");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 418, DateTimeKind.Local).AddTicks(8574));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("ContactRequests", t =>
                        {
                            t.HasCheckConstraint("CH_ContactRequest_ClientName", "LENGTH(ClientName) >= 5");

                            t.HasCheckConstraint("CH_ContactRequest_Email", "Email LIKE '%@%.com'");

                            t.HasCheckConstraint("CH_ContactRequest_Phone", "Phone LIKE '009627________'");
                        });
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 418, DateTimeKind.Local).AddTicks(6878));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsLoggedIn")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastLoginTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Password")
                        .IsUnique();

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Logins", t =>
                        {
                            t.HasCheckConstraint("CH_Login_Password", "Password REGEXP '[A-Z]{1,}[a-z]{5,}[0-9]+[+=)(*&^%$#@!~]+'");
                        });
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 419, DateTimeKind.Local).AddTicks(206));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders", t =>
                        {
                            t.HasCheckConstraint("CH_Order_Title", "LENGTH(Title) >= 5");
                        });
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Problem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 422, DateTimeKind.Local).AddTicks(1729));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("longtext");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderID")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.ToTable("Problems", t =>
                        {
                            t.HasCheckConstraint("CH_Problem_Purpose", "NOT (Purpose REGEXP '[0-9~!@#$%^&*()_+=-]')");

                            t.HasCheckConstraint("CH_Problem_Title", "NOT (Title REGEXP '[0-9~!@#$%^&*()_+=-]')");
                        });
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 419, DateTimeKind.Local).AddTicks(5933));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("varchar(150)");

                    b.Property<float?>("DisacountAmount")
                        .HasColumnType("float");

                    b.Property<int?>("DiscountType")
                        .IsUnicode(true)
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsHaveDiscount")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Services", t =>
                        {
                            t.HasCheckConstraint("CH_Service_Name", "LENGTH(Name) >= 4");
                        });
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 5, 24, 18, 52, 30, 419, DateTimeKind.Local).AddTicks(9951));

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<int>("UserType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Phone")
                        .IsUnique();

                    b.ToTable("Users", t =>
                        {
                            t.HasCheckConstraint("CH_User_Email", "Email REGEXP '^[A-Za-z0-9._-]+@[A-Za-z0-9]+[.][A-Za-z]+$'");

                            t.HasCheckConstraint("CH_User_FirstName", "NOT (FirstName REGEXP '[0-9~!@#$%^&*()_+=-]')");

                            t.HasCheckConstraint("CH_User_LastName", "NOT (LastName REGEXP '[0-9~!@#$%^&*()_+=-]')");

                            t.HasCheckConstraint("CH_User_Phone", "Phone LIKE '009627________'");
                        });
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Blog", b =>
                {
                    b.HasOne("BlogPhotographerSystem_Core.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.BlogAttachement", b =>
                {
                    b.HasOne("BlogPhotographerSystem_Core.Models.Entity.Blog", null)
                        .WithMany()
                        .HasForeignKey("BlogID");
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.ContactRequest", b =>
                {
                    b.HasOne("BlogPhotographerSystem_Core.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Login", b =>
                {
                    b.HasOne("BlogPhotographerSystem_Core.Models.Entity.User", null)
                        .WithOne()
                        .HasForeignKey("BlogPhotographerSystem_Core.Models.Entity.Login", "UserID");
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Order", b =>
                {
                    b.HasOne("BlogPhotographerSystem_Core.Models.Entity.Service", null)
                        .WithMany()
                        .HasForeignKey("ServiceID");

                    b.HasOne("BlogPhotographerSystem_Core.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Problem", b =>
                {
                    b.HasOne("BlogPhotographerSystem_Core.Models.Entity.Order", null)
                        .WithOne()
                        .HasForeignKey("BlogPhotographerSystem_Core.Models.Entity.Problem", "OrderID");

                    b.HasOne("BlogPhotographerSystem_Core.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("BlogPhotographerSystem_Core.Models.Entity.Service", b =>
                {
                    b.HasOne("BlogPhotographerSystem_Core.Models.Entity.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
