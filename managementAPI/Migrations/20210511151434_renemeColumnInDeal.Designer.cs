// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace managementAPI.Migrations
{
    [DbContext(typeof(ManagementContex))]
    [Migration("20210511151434_renemeColumnInDeal")]
    partial class renemeColumnInDeal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("Dealid")
                        .HasColumnType("integer")
                        .HasColumnName("dealid");

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

                    b.HasIndex("Dealid")
                        .HasDatabaseName("ix_cars_dealid");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("Deal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("name")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("name");

                    b.HasKey("id")
                        .HasName("pk_deal");

                    b.ToTable("deal");
                });

            modelBuilder.Entity("Manager", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("Dealid")
                        .HasColumnType("integer")
                        .HasColumnName("dealid");

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

                    b.HasIndex("Dealid")
                        .HasDatabaseName("ix_managers_dealid");

                    b.ToTable("managers");
                });

            modelBuilder.Entity("Car", b =>
                {
                    b.HasOne("Deal", null)
                        .WithMany("car_")
                        .HasForeignKey("Dealid")
                        .HasConstraintName("fk_cars_deal_dealid");
                });

            modelBuilder.Entity("Manager", b =>
                {
                    b.HasOne("Deal", null)
                        .WithMany("manager_")
                        .HasForeignKey("Dealid")
                        .HasConstraintName("fk_managers_deal_dealid");
                });

            modelBuilder.Entity("Deal", b =>
                {
                    b.Navigation("car_");

                    b.Navigation("manager_");
                });
#pragma warning restore 612, 618
        }
    }
}
