﻿// <auto-generated />
using M01_DAL_Municipalite_MySQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace M01_DAL_Municipalite_MySQL.Migrations
{
    [DbContext(typeof(MunicipaliteContextMySQL))]
    partial class MunicipaliteContextMySQLModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("M01_DAL_Municipalite_MySQL.Municipalite", b =>
                {
                    b.Property<int>("MunicipaliteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("MunicipaliteId");

                    b.ToTable("Municipalites");
                });
#pragma warning restore 612, 618
        }
    }
}