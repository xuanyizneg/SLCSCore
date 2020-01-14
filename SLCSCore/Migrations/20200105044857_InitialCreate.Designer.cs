﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SLCSCore.Data;

namespace SLCSCore.Migrations
{
    [DbContext(typeof(SLCSContext))]
    [Migration("20200105044857_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SLCSCore.Models.Book", b =>
                {
                    b.Property<int>("B_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("B_Author")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("B_BookName")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("B_BookStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_Isbn")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("B_PublishPlace")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("B_PublishYear")
                        .HasColumnType("varchar(4)");

                    b.Property<string>("B_Publisher")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("B_TopicCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("L_Id")
                        .HasColumnType("int");

                    b.Property<int?>("LocationL_Id")
                        .HasColumnType("int");

                    b.HasKey("B_Id");

                    b.HasIndex("LocationL_Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("SLCSCore.Models.BrorrowLog", b =>
                {
                    b.Property<int>("BL_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BL_BorrowTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BL_ReturnTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("B_Id")
                        .HasColumnType("int");

                    b.Property<int?>("BookB_Id")
                        .HasColumnType("int");

                    b.Property<int>("U_Id")
                        .HasColumnType("int");

                    b.Property<int?>("UserU_Id")
                        .HasColumnType("int");

                    b.HasKey("BL_Id");

                    b.HasIndex("BookB_Id");

                    b.HasIndex("UserU_Id");

                    b.ToTable("BrorrowLog");
                });

            modelBuilder.Entity("SLCSCore.Models.Location", b =>
                {
                    b.Property<int>("L_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("L_Address")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("L_Location")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("L_Phone")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("L_Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("SLCSCore.Models.ParameterSet", b =>
                {
                    b.Property<int>("PS_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PS_Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PS_Remark")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PS_Type")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PS_Value")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PS_Id");

                    b.ToTable("ParameterSet");
                });

            modelBuilder.Entity("SLCSCore.Models.Reserve", b =>
                {
                    b.Property<int>("R_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("B_Id")
                        .HasColumnType("int");

                    b.Property<int?>("BookB_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("R_ReverseTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("U_Id")
                        .HasColumnType("int");

                    b.Property<int?>("UserU_Id")
                        .HasColumnType("int");

                    b.HasKey("R_Id");

                    b.HasIndex("BookB_Id");

                    b.HasIndex("UserU_Id");

                    b.ToTable("Reserve");
                });

            modelBuilder.Entity("SLCSCore.Models.User", b =>
                {
                    b.Property<int>("U_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("U_Account")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("U_Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("U_IdNumber")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("U_Password")
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("U_Phone")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("U_Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SLCSCore.Models.Book", b =>
                {
                    b.HasOne("SLCSCore.Models.Location", "Location")
                        .WithMany("Books")
                        .HasForeignKey("LocationL_Id");
                });

            modelBuilder.Entity("SLCSCore.Models.BrorrowLog", b =>
                {
                    b.HasOne("SLCSCore.Models.Book", "Book")
                        .WithMany("BrorrowLogs")
                        .HasForeignKey("BookB_Id");

                    b.HasOne("SLCSCore.Models.User", "User")
                        .WithMany("BrorrowLogs")
                        .HasForeignKey("UserU_Id");
                });

            modelBuilder.Entity("SLCSCore.Models.Reserve", b =>
                {
                    b.HasOne("SLCSCore.Models.Book", "Book")
                        .WithMany("Reserves")
                        .HasForeignKey("BookB_Id");

                    b.HasOne("SLCSCore.Models.User", "User")
                        .WithMany("Reserves")
                        .HasForeignKey("UserU_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
