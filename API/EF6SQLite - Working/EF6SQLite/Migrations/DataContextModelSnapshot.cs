﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF6SQLite.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("OrganizationId");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("OrganizationName");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("PatientDetails", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("PatientID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("City");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("FirstName");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("LastName");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("OrganizationId");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("State");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("PatientID");

                    b.HasIndex("OrganizationId");

                    b.ToTable("PatientDetails");
                });

            modelBuilder.Entity("VisitDetails", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("VisitId");

                    b.Property<decimal>("Height")
                        .HasColumnType("TEXT")
                        .HasColumnName("Height");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("PatientId");

                    b.Property<string>("ProgressNotes")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("ProgressNotes");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("SectionName");

                    b.Property<decimal>("Temperature")
                        .HasColumnType("TEXT")
                        .HasColumnName("Temperature");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("VisitDate");

                    b.Property<decimal>("Weight")
                        .HasColumnType("TEXT")
                        .HasColumnName("Weight");

                    b.HasKey("VisitId");

                    b.HasIndex("PatientId");

                    b.ToTable("VisitDetails");
                });

            modelBuilder.Entity("PatientDetails", b =>
                {
                    b.HasOne("Organization", "Organization")
                        .WithMany("PatientDetails")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("VisitDetails", b =>
                {
                    b.HasOne("PatientDetails", "PatientDetails")
                        .WithMany("VisitDetails")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PatientDetails");
                });

            modelBuilder.Entity("Organization", b =>
                {
                    b.Navigation("PatientDetails");
                });

            modelBuilder.Entity("PatientDetails", b =>
                {
                    b.Navigation("VisitDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
