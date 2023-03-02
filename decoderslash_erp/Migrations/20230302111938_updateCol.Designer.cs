﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using decoderslash_erp.Data;

#nullable disable

namespace decoderslasherp.Migrations
{
    [DbContext(typeof(decoderslash_erpContext))]
    [Migration("20230302111938_updateCol")]
    partial class updateCol
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("decoderslash_erp.Models.Credentials", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserAdd")
                        .HasColumnType("int");

                    b.Property<int?>("UserDel")
                        .HasColumnType("int");

                    b.Property<int?>("UserMod")
                        .HasColumnType("int");

                    b.Property<bool?>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AvatarPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BasicSalary")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CredentialsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FuelAllowence")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<decimal>("Housing")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OverTimeHourlyRate")
                        .HasColumnType("decimal(18, 4)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<int?>("UserAdd")
                        .HasColumnType("int");

                    b.Property<int?>("UserDel")
                        .HasColumnType("int");

                    b.Property<int?>("UserMod")
                        .HasColumnType("int");

                    b.Property<bool?>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("CredentialsID");

                    b.HasIndex("TeamID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectManagerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserAdd")
                        .HasColumnType("int");

                    b.Property<int?>("UserDel")
                        .HasColumnType("int");

                    b.Property<int?>("UserMod")
                        .HasColumnType("int");

                    b.Property<bool?>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ProjectManagerID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Tasks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int?>("UserAdd")
                        .HasColumnType("int");

                    b.Property<int?>("UserDel")
                        .HasColumnType("int");

                    b.Property<int?>("UserMod")
                        .HasColumnType("int");

                    b.Property<bool?>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isAssigned")
                        .HasColumnType("bit");

                    b.Property<bool>("isCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("isIssue")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProjectID")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserAdd")
                        .HasColumnType("int");

                    b.Property<int?>("UserDel")
                        .HasColumnType("int");

                    b.Property<int?>("UserMod")
                        .HasColumnType("int");

                    b.Property<bool?>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Employee", b =>
                {
                    b.HasOne("decoderslash_erp.Models.Credentials", "Credential")
                        .WithMany()
                        .HasForeignKey("CredentialsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("decoderslash_erp.Models.Team", "team")
                        .WithMany()
                        .HasForeignKey("TeamID");

                    b.Navigation("Credential");

                    b.Navigation("team");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Project", b =>
                {
                    b.HasOne("decoderslash_erp.Models.Employee", "ProjectManager")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectManagerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectManager");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Tasks", b =>
                {
                    b.HasOne("decoderslash_erp.Models.Employee", "employee")
                        .WithMany("Tasks")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("decoderslash_erp.Models.Project", "project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("project");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Team", b =>
                {
                    b.HasOne("decoderslash_erp.Models.Project", "project")
                        .WithMany("teams")
                        .HasForeignKey("ProjectID");

                    b.Navigation("project");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Employee", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("decoderslash_erp.Models.Project", b =>
                {
                    b.Navigation("teams");
                });
#pragma warning restore 612, 618
        }
    }
}
