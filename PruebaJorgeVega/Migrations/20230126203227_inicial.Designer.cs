﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaJorgeVega.Data;

#nullable disable

namespace PruebaJorgeVega.Migrations
{
    [DbContext(typeof(PruebaJorgeVegaContext))]
    [Migration("20230126203227_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("PruebaJorgeVega.Models.Tarea", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("area")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("dependence")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("time")
                        .HasColumnType("TEXT");

                    b.Property<string>("user")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Tarea");
                });
#pragma warning restore 612, 618
        }
    }
}