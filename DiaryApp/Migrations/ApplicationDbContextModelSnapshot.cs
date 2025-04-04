﻿// <auto-generated />
using System;
using DairyApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DairyApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DairyApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Went hiking with Joe!",
                            Created = new DateTime(2025, 3, 25, 18, 11, 40, 353, DateTimeKind.Local).AddTicks(9200),
                            Title = "Went Hiking"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Went shopping with Mike!",
                            Created = new DateTime(2025, 3, 25, 18, 11, 40, 353, DateTimeKind.Local).AddTicks(9480),
                            Title = "Went Shopping"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Went diving with Kevin",
                            Created = new DateTime(2025, 3, 25, 18, 11, 40, 353, DateTimeKind.Local).AddTicks(9483),
                            Title = "Went Diving"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
