﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace managementAPI.Migrations
{
    [DbContext(typeof(ManagementContex))]
    partial class CarManagementContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("brand")
                        .HasColumnType("text")
                        .HasColumnName("brand");

                    b.Property<string>("color")
                        .HasColumnType("text")
                        .HasColumnName("color");

                    b.Property<string>("model")
                        .HasColumnType("text")
                        .HasColumnName("model");

                    b.Property<decimal>("price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.HasKey("id")
                        .HasName("pk_cars");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("Deal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("car_id")
                        .HasColumnType("integer")
                        .HasColumnName("car_id");

                    b.Property<DateTime?>("date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date");

                    b.Property<int?>("manager_id")
                        .HasColumnType("integer")
                        .HasColumnName("manager_id");

                    b.HasKey("id")
                        .HasName("pk_deals");

                    b.HasIndex("car_id")
                        .HasDatabaseName("ix_deals_car_id");

                    b.HasIndex("manager_id")
                        .HasDatabaseName("ix_deals_manager_id");

                    b.ToTable("deals");
                });

            modelBuilder.Entity("Manager", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("date_recruitment")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_recruitment");

                    b.Property<string>("first_name")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("last_name")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<decimal>("salary")
                        .HasColumnType("numeric")
                        .HasColumnName("salary");

                    b.Property<int>("sales")
                        .HasColumnType("integer")
                        .HasColumnName("sales");

                    b.Property<string>("surname")
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.HasKey("id")
                        .HasName("pk_managers");

                    b.ToTable("managers");
                });

            modelBuilder.Entity("Deal", b =>
                {
                    b.HasOne("Car", "car_")
                        .WithMany("deal")
                        .HasForeignKey("car_id")
                        .HasConstraintName("fk_deals_cars_car_id");

                    b.HasOne("Manager", "manager_")
                        .WithMany("deals")
                        .HasForeignKey("manager_id")
                        .HasConstraintName("fk_deals_managers_manager_id");

                    b.Navigation("car_");

                    b.Navigation("manager_");
                });

            modelBuilder.Entity("Car", b =>
                {
                    b.Navigation("deal");
                });

            modelBuilder.Entity("Manager", b =>
                {
                    b.Navigation("deals");
                });
#pragma warning restore 612, 618
        }
    }
}
