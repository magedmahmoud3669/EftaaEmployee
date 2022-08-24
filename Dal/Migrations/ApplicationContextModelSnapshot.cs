﻿// <auto-generated />
using System;
using Dal.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dal.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Dal.Entity.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressInCairo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressOutCairo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChangingReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CurrentFiqhSchoolId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FiqhInPreparatorySchoolId")
                        .HasColumnType("int")
                        .HasColumnOrder(4);

                    b.Property<int?>("FiqhInSecondarySchoolId")
                        .HasColumnType("int")
                        .HasColumnOrder(5);

                    b.Property<int?>("LastFiqhSchoolId")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ScoialStatusId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.HasIndex("CurrentFiqhSchoolId");

                    b.HasIndex("FiqhInPreparatorySchoolId");

                    b.HasIndex("FiqhInSecondarySchoolId");

                    b.HasIndex("LastFiqhSchoolId");

                    b.HasIndex("ScoialStatusId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Dal.Entity.Lookups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lookups");
                });

            modelBuilder.Entity("Dal.Entity.LookupsValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LookupsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LookupsId");

                    b.ToTable("LookupsValue");
                });

            modelBuilder.Entity("Dal.Entity.Employees", b =>
                {
                    b.HasOne("Dal.Entity.LookupsValue", "CurrentFiqhSchool")
                        .WithMany()
                        .HasForeignKey("CurrentFiqhSchoolId");

                    b.HasOne("Dal.Entity.LookupsValue", "FiqhInPreparatorySchool")
                        .WithMany()
                        .HasForeignKey("FiqhInPreparatorySchoolId");

                    b.HasOne("Dal.Entity.LookupsValue", "FiqhInSecondarySchool")
                        .WithMany()
                        .HasForeignKey("FiqhInSecondarySchoolId");

                    b.HasOne("Dal.Entity.LookupsValue", "LastFiqhSchool")
                        .WithMany()
                        .HasForeignKey("LastFiqhSchoolId");

                    b.HasOne("Dal.Entity.LookupsValue", "ScoialStatus")
                        .WithMany()
                        .HasForeignKey("ScoialStatusId");

                    b.Navigation("CurrentFiqhSchool");

                    b.Navigation("FiqhInPreparatorySchool");

                    b.Navigation("FiqhInSecondarySchool");

                    b.Navigation("LastFiqhSchool");

                    b.Navigation("ScoialStatus");
                });

            modelBuilder.Entity("Dal.Entity.LookupsValue", b =>
                {
                    b.HasOne("Dal.Entity.Lookups", "Lookups")
                        .WithMany()
                        .HasForeignKey("LookupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lookups");
                });
#pragma warning restore 612, 618
        }
    }
}
