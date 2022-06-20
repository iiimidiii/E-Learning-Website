﻿// <auto-generated />
using System;
using Eleaning_Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eleaning_Web.Migrations
{
    [DbContext(typeof(AltaContext))]
    partial class AltaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Eleaning_Web.Document", b =>
                {
                    b.Property<int?>("DocumentId")
                        .HasColumnType("int");

                    b.Property<string>("IdSubject")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameDocument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("SubjectID");

                    b.ToTable("Document", (string)null);
                });

            modelBuilder.Entity("Eleaning_Web.Models.Class", b =>
                {
                    b.Property<string>("ClassId")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("NameClass")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("subjectId");

                    b.HasKey("ClassId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Class", (string)null);
                });

            modelBuilder.Entity("Eleaning_Web.Models.Subject", b =>
                {
                    b.Property<string>("SubjectId")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("EndDay")
                        .HasColumnType("datetime");

                    b.Property<string>("Period")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<DateTime?>("StartDay")
                        .HasColumnType("datetime");

                    b.Property<string>("SubjectName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subject", (string)null);
                });

            modelBuilder.Entity("Eleaning_Web.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(18)
                        .HasColumnType("nchar(18)")
                        .HasColumnName("UserID")
                        .IsFixedLength();

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Images")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Eleaning_Web.Role", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Eleaning_Web.TestSchedule", b =>
                {
                    b.Property<int>("TestScheduleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DayExam")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Time")
                        .HasColumnType("datetime");

                    b.HasKey("TestScheduleId");

                    b.ToTable("TestSchedule", (string)null);
                });

            modelBuilder.Entity("Eleaning_Web.Models.Class", b =>
                {
                    b.HasOne("Eleaning_Web.Models.Subject", "Subject")
                        .WithMany("Classes")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("FK_Class_Subject");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Eleaning_Web.Models.Subject", b =>
                {
                    b.Navigation("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}