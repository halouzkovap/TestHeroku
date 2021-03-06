﻿// <auto-generated />
using BankOfSimba.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BankOfSimba.Migrations
{
    [DbContext(typeof(BankOfSimbaDbContext))]
    [Migration("20200506105527_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("BankOfSimba.Models.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AnimalType")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("BankAccounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnimalType = "lion",
                            Balance = 2000m,
                            Name = "Simba"
                        },
                        new
                        {
                            Id = 2,
                            AnimalType = "elephant",
                            Balance = 5000m,
                            Name = "Hathi"
                        },
                        new
                        {
                            Id = 3,
                            AnimalType = "wolf",
                            Balance = 6000m,
                            Name = "Akela"
                        },
                        new
                        {
                            Id = 4,
                            AnimalType = "bear",
                            Balance = 1000m,
                            Name = "Balu"
                        },
                        new
                        {
                            Id = 5,
                            AnimalType = "snike",
                            Balance = 500m,
                            Name = "Ka"
                        },
                        new
                        {
                            Id = 6,
                            AnimalType = "person",
                            Balance = 500m,
                            Name = "King"
                        },
                        new
                        {
                            Id = 7,
                            AnimalType = "person",
                            Balance = 500m,
                            Name = "Bad Guy"
                        },
                        new
                        {
                            Id = 8,
                            AnimalType = "person",
                            Balance = 500m,
                            Name = "Good Guy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
