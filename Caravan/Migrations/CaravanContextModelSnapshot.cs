﻿// <auto-generated />
using Caravan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Caravan.Migrations
{
    [DbContext(typeof(CaravanContext))]
    partial class CaravanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Caravan.Models.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("destination");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("WagonId")
                        .HasColumnType("integer")
                        .HasColumnName("wagon_id");

                    b.HasKey("Id")
                        .HasName("pk_passengers");

                    b.HasIndex("WagonId")
                        .HasDatabaseName("ix_passengers_wagon_id");

                    b.ToTable("passengers", (string)null);
                });

            modelBuilder.Entity("Caravan.Models.Wagon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCovered")
                        .HasColumnType("boolean")
                        .HasColumnName("is_covered");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("NumWheels")
                        .HasColumnType("integer")
                        .HasColumnName("num_wheels");

                    b.HasKey("Id")
                        .HasName("pk_wagons");

                    b.ToTable("wagons", (string)null);
                });

            modelBuilder.Entity("Caravan.Models.Passenger", b =>
                {
                    b.HasOne("Caravan.Models.Wagon", "Wagon")
                        .WithMany("Passengers")
                        .HasForeignKey("WagonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_passengers_wagons_wagon_id");

                    b.Navigation("Wagon");
                });

            modelBuilder.Entity("Caravan.Models.Wagon", b =>
                {
                    b.Navigation("Passengers");
                });
#pragma warning restore 612, 618
        }
    }
}