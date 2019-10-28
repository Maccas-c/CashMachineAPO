﻿// <auto-generated />
using System;
using ATM_Machine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ATM_Machine.Migrations
{
    [DbContext(typeof(ATMDbContext))]
    [Migration("20191027184433_added_seed_data")]
    partial class added_seed_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CashMachine.Models.DataBase.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Money");

                    b.Property<int>("Number");

                    b.Property<Guid>("OwnerId");

                    b.Property<string>("Pin")
                        .IsRequired();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Card");

                    b.HasData(
                        new { Id = new Guid("139f252b-b17b-43e3-af1b-f65a0a76e4db"), Money = 100, Number = 1, OwnerId = new Guid("3686f45d-5e74-4666-ae76-6cf898d36f90"), Pin = "2345", Type = "Credid card" },
                        new { Id = new Guid("73cd64ae-d13c-4be1-b4a0-4f055abd76f0"), Money = 200, Number = 2, OwnerId = new Guid("98d50544-b91e-4491-9bf9-a4d601e5f873"), Pin = "3456", Type = "Debit card" },
                        new { Id = new Guid("b50cbd75-9df7-4c3c-8296-68d12832b65f"), Money = 300, Number = 3, OwnerId = new Guid("9710bb72-956f-4aca-ad4e-9fa133e385d4"), Pin = "4567", Type = "Credid card" },
                        new { Id = new Guid("c66d5c50-1d97-469b-82c8-15e11ee0faf2"), Money = 400, Number = 4, OwnerId = new Guid("8f18e657-4611-4ce1-9854-279fa327144c"), Pin = "5678", Type = "Payment card" }
                    );
                });

            modelBuilder.Entity("CashMachine.Models.DataBase.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAbleToTransfer");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Owner");

                    b.HasData(
                        new { Id = new Guid("3686f45d-5e74-4666-ae76-6cf898d36f90"), IsAbleToTransfer = true, LastName = "Kowalski", Name = "Piotr" },
                        new { Id = new Guid("98d50544-b91e-4491-9bf9-a4d601e5f873"), IsAbleToTransfer = true, LastName = "Nowak", Name = "Maciej" },
                        new { Id = new Guid("9710bb72-956f-4aca-ad4e-9fa133e385d4"), IsAbleToTransfer = true, LastName = "Janicki", Name = "Wojciech" },
                        new { Id = new Guid("8f18e657-4611-4ce1-9854-279fa327144c"), IsAbleToTransfer = true, LastName = "Olejniczak", Name = "Adam" }
                    );
                });

            modelBuilder.Entity("CashMachine.Models.DataBase.Card", b =>
                {
                    b.HasOne("CashMachine.Models.DataBase.Owner", "Owner")
                        .WithMany("Cards")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
