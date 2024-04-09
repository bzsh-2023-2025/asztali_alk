﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using haziallatok.Data;

#nullable disable

namespace haziallatok.Migrations
{
    [DbContext(typeof(PetContext))]
    partial class PetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("haziallatok.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("haziallatok.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Faj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GazdId")
                        .HasColumnType("int");

                    b.Property<int>("Kor")
                        .HasColumnType("int");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("haziallatok.Models.Pet", b =>
                {
                    b.HasOne("haziallatok.Models.Owner", null)
                        .WithMany("Pet")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("haziallatok.Models.Owner", b =>
                {
                    b.Navigation("Pet");
                });
#pragma warning restore 612, 618
        }
    }
}