﻿// <auto-generated />
using System;
using CodeFirst_WebAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirst_WebAPI.Migrations
{
    [DbContext(typeof(CodeFirstDemoContext))]
    [Migration("20240507074101_DbVersion3")]
    partial class DbVersion3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeFirst_WebAPI.Models.InstrumentType", b =>
                {
                    b.Property<int>("InstrumentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstrumentTypeId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstrumentTypeId");

                    b.ToTable("InstrumentTypes");

                    b.HasData(
                        new
                        {
                            InstrumentTypeId = 1,
                            Name = "Acoustic Guitar"
                        },
                        new
                        {
                            InstrumentTypeId = 2,
                            Name = "Electric Guitar"
                        },
                        new
                        {
                            InstrumentTypeId = 3,
                            Name = "Drums"
                        },
                        new
                        {
                            InstrumentTypeId = 4,
                            Name = "Bass"
                        },
                        new
                        {
                            InstrumentTypeId = 5,
                            Name = "Keyboard"
                        });
                });

            modelBuilder.Entity("CodeFirst_WebAPI.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"), 1L, 1);

                    b.Property<DateTime>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            JoinedDate = new DateTime(2024, 5, 7, 14, 41, 1, 491, DateTimeKind.Local).AddTicks(1962),
                            NickName = "Khang"
                        },
                        new
                        {
                            PlayerId = 2,
                            JoinedDate = new DateTime(2024, 5, 7, 14, 41, 1, 491, DateTimeKind.Local).AddTicks(1971),
                            NickName = "Hoang"
                        });
                });

            modelBuilder.Entity("CodeFirst_WebAPI.Models.PlayerInstrument", b =>
                {
                    b.Property<int>("PlayerInstrumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerInstrumentId"), 1L, 1);

                    b.Property<int>("InstrumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("PlayerInstrumentId");

                    b.HasIndex("InstrumentTypeId");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerInstruments");

                    b.HasData(
                        new
                        {
                            PlayerInstrumentId = 1,
                            InstrumentTypeId = 1,
                            Level = "Good",
                            ModelName = "Gui",
                            PlayerId = 1
                        },
                        new
                        {
                            PlayerInstrumentId = 2,
                            InstrumentTypeId = 1,
                            Level = "Good",
                            ModelName = "Gui",
                            PlayerId = 2
                        },
                        new
                        {
                            PlayerInstrumentId = 3,
                            InstrumentTypeId = 2,
                            Level = "Good",
                            ModelName = "Gui",
                            PlayerId = 2
                        });
                });

            modelBuilder.Entity("CodeFirst_WebAPI.Models.PlayerInstrument", b =>
                {
                    b.HasOne("CodeFirst_WebAPI.Models.InstrumentType", null)
                        .WithMany("Players")
                        .HasForeignKey("InstrumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_WebAPI.Models.Player", null)
                        .WithMany("Instruments")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeFirst_WebAPI.Models.InstrumentType", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("CodeFirst_WebAPI.Models.Player", b =>
                {
                    b.Navigation("Instruments");
                });
#pragma warning restore 612, 618
        }
    }
}
