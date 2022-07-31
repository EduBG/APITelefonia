﻿// <auto-generated />
using System;
using APITelefonia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APITelefonia.Migrations
{
    [DbContext(typeof(TelefoniaContext))]
    [Migration("20220731160342_MigrationV1")]
    partial class MigrationV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("APITelefonia.Models.Estado", b =>
                {
                    b.Property<int>("Id_estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Estado_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_estado");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("APITelefonia.Models.Fabricante", b =>
                {
                    b.Property<int>("Id_fab")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Fab_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fab_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_fab");

                    b.ToTable("Fabricante");
                });

            modelBuilder.Entity("APITelefonia.Models.Terminal", b =>
                {
                    b.Property<int>("Id_terminal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Fecha_estado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_fabricacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_estado")
                        .HasColumnType("int");

                    b.Property<int>("Id_fab")
                        .HasColumnType("int");

                    b.Property<string>("Terminal_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Terminal_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_terminal");

                    b.ToTable("Terminal");
                });
#pragma warning restore 612, 618
        }
    }
}
