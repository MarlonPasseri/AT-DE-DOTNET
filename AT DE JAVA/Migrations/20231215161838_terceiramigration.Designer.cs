﻿// <auto-generated />
using AT_DE_JAVA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AT_DE_JAVA.Migrations
{
    [DbContext(typeof(AT_DE_JAVAContext))]
    [Migration("20231215161838_terceiramigration")]
    partial class terceiramigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AT_DE_JAVA.Models.Restaurante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Garçon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingrediente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurante");
                });
#pragma warning restore 612, 618
        }
    }
}
