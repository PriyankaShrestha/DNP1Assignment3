﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.DataContext;

namespace Server.Migrations
{
    [DbContext(typeof(DataAccess))]
    [Migration("20210507111650_DeleteAdultAndChild")]
    partial class DeleteAdultAndChild
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Models.Adult", b =>
                {
                    b.Property<int>("CPRNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("FamilyCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("FamilyFloor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("CPRNumber");

                    b.HasIndex("JobTitle");

                    b.HasIndex("FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor");

                    b.ToTable("Adult");
                });

            modelBuilder.Entity("Models.Child", b =>
                {
                    b.Property<int>("CPRNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("FamilyCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("FamilyFloor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("CPRNumber");

                    b.HasIndex("FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("Models.Family", b =>
                {
                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Floor")
                        .HasColumnType("TEXT");

                    b.HasKey("City", "StreetName", "HouseNumber", "Floor");

                    b.ToTable("FamiliesDB");
                });

            modelBuilder.Entity("Models.Job", b =>
                {
                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("Salary")
                        .HasColumnType("INTEGER");

                    b.HasKey("JobTitle");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("UsersDB");
                });

            modelBuilder.Entity("Models.Adult", b =>
                {
                    b.HasOne("Models.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobTitle");

                    b.HasOne("Models.Family", null)
                        .WithMany("Adults")
                        .HasForeignKey("FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Models.Child", b =>
                {
                    b.HasOne("Models.Family", null)
                        .WithMany("Children")
                        .HasForeignKey("FamilyCity", "FamilyStreetName", "FamilyHouseNumber", "FamilyFloor");
                });

            modelBuilder.Entity("Models.Family", b =>
                {
                    b.Navigation("Adults");

                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
