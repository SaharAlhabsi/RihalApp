﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RihalDev.Data;

namespace RihalDev.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("RihalDev.Models.Classes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            name = "93751-8039"
                        },
                        new
                        {
                            Id = 2,
                            name = "92946-9740"
                        },
                        new
                        {
                            Id = 3,
                            name = "14087-5715"
                        },
                        new
                        {
                            Id = 4,
                            name = "02105"
                        },
                        new
                        {
                            Id = 5,
                            name = "18890-2730"
                        },
                        new
                        {
                            Id = 6,
                            name = "52795"
                        },
                        new
                        {
                            Id = 7,
                            name = "89904"
                        },
                        new
                        {
                            Id = 8,
                            name = "94731-5056"
                        },
                        new
                        {
                            Id = 9,
                            name = "10741-3032"
                        },
                        new
                        {
                            Id = 10,
                            name = "93792"
                        });
                });

            modelBuilder.Entity("RihalDev.Models.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            count = 0,
                            name = "Bradleyhaven"
                        },
                        new
                        {
                            Id = 2,
                            count = 0,
                            name = "Port Georgechester"
                        },
                        new
                        {
                            Id = 3,
                            count = 0,
                            name = "Clevelandstad"
                        },
                        new
                        {
                            Id = 4,
                            count = 0,
                            name = "North Sister"
                        },
                        new
                        {
                            Id = 5,
                            count = 0,
                            name = "Dorrishaven"
                        },
                        new
                        {
                            Id = 6,
                            count = 0,
                            name = "Colleenburgh"
                        },
                        new
                        {
                            Id = 7,
                            count = 0,
                            name = "Destinfurt"
                        },
                        new
                        {
                            Id = 8,
                            count = 0,
                            name = "South Clarabellechester"
                        },
                        new
                        {
                            Id = 9,
                            count = 0,
                            name = "West Gene"
                        },
                        new
                        {
                            Id = 10,
                            count = 0,
                            name = "North Nickside"
                        });
                });

            modelBuilder.Entity("RihalDev.Models.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("class_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("country_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("class_id");

                    b.HasIndex("country_id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            birthDate = new DateTime(1985, 4, 29, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 2,
                            country_id = 6,
                            name = "Kay McGlynn DVM"
                        },
                        new
                        {
                            Id = 2,
                            birthDate = new DateTime(1917, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 5,
                            country_id = 2,
                            name = "Reggie Kovacek IV"
                        },
                        new
                        {
                            Id = 3,
                            birthDate = new DateTime(1984, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 7,
                            country_id = 3,
                            name = "Sarai Ondricka"
                        },
                        new
                        {
                            Id = 4,
                            birthDate = new DateTime(1905, 10, 21, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 10,
                            country_id = 7,
                            name = "Lawrence Crona"
                        },
                        new
                        {
                            Id = 5,
                            birthDate = new DateTime(1956, 8, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 2,
                            country_id = 5,
                            name = "Carlos Pagac V"
                        },
                        new
                        {
                            Id = 6,
                            birthDate = new DateTime(1961, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 1,
                            country_id = 4,
                            name = "Prof. Etha Gutkowski III"
                        },
                        new
                        {
                            Id = 7,
                            birthDate = new DateTime(1951, 10, 18, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 8,
                            country_id = 3,
                            name = "Dejah Hilll"
                        },
                        new
                        {
                            Id = 8,
                            birthDate = new DateTime(1936, 7, 9, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 4,
                            country_id = 7,
                            name = "Marguerite Kshlerin"
                        },
                        new
                        {
                            Id = 9,
                            birthDate = new DateTime(2007, 6, 23, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 6,
                            country_id = 6,
                            name = "Prof. Devonte Koch PhD"
                        },
                        new
                        {
                            Id = 10,
                            birthDate = new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 5,
                            country_id = 10,
                            name = "Freddy O'Kon"
                        },
                        new
                        {
                            Id = 11,
                            birthDate = new DateTime(1973, 10, 26, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 8,
                            country_id = 7,
                            name = "Mrs. Bret Jacky Nitzsche"
                        },
                        new
                        {
                            Id = 12,
                            birthDate = new DateTime(1994, 11, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 4,
                            country_id = 3,
                            name = "Dr. Duane Hoppe"
                        },
                        new
                        {
                            Id = 13,
                            birthDate = new DateTime(1938, 9, 24, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 4,
                            country_id = 3,
                            name = "Miss Lowell O'Keefe V"
                        },
                        new
                        {
                            Id = 14,
                            birthDate = new DateTime(2013, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 4,
                            country_id = 5,
                            name = "Kaelyn Raynor"
                        },
                        new
                        {
                            Id = 15,
                            birthDate = new DateTime(1900, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 9,
                            country_id = 2,
                            name = "Raquel Von"
                        },
                        new
                        {
                            Id = 16,
                            birthDate = new DateTime(1988, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 1,
                            country_id = 4,
                            name = "Mrs. Bethel Lilly Douglas"
                        },
                        new
                        {
                            Id = 17,
                            birthDate = new DateTime(1959, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 4,
                            country_id = 4,
                            name = "Mrs. Eulah Donnelly DVM"
                        },
                        new
                        {
                            Id = 18,
                            birthDate = new DateTime(1906, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 3,
                            country_id = 5,
                            name = "Ms. Sienna Jude Haag MD"
                        },
                        new
                        {
                            Id = 19,
                            birthDate = new DateTime(1954, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 7,
                            country_id = 10,
                            name = "Janie Auer"
                        },
                        new
                        {
                            Id = 20,
                            birthDate = new DateTime(2013, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            class_id = 6,
                            country_id = 9,
                            name = "Conor Bernier"
                        });
                });

            modelBuilder.Entity("RihalDev.Models.Students", b =>
                {
                    b.HasOne("RihalDev.Models.Classes", "Classes")
                        .WithMany("Students")
                        .HasForeignKey("class_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RihalDev.Models.Countries", "Countries")
                        .WithMany("Students")
                        .HasForeignKey("country_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classes");

                    b.Navigation("Countries");
                });

            modelBuilder.Entity("RihalDev.Models.Classes", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("RihalDev.Models.Countries", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}