﻿// <auto-generated />
using System;
using Bulky.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231106220504_catName")]
    partial class catName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d17d7d98-583c-4f9a-ad26-2a8534e0e77e"),
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("cd9e0baa-aa05-4edc-ba65-1d771ffffe35"),
                            DisplayOrder = 2,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = new Guid("243cc7fd-f859-44b3-9b8b-bb3f10a094e9"),
                            DisplayOrder = 3,
                            Name = "Thriller"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
