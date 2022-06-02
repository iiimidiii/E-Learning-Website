﻿// <auto-generated />
using System;
using Du_An.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Du_An.Migrations
{
    [DbContext(typeof(ElearnningContext))]
    [Migration("20220602035803_Elearning")]
    partial class Elearning
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Du_An.Models.Bangdiem", b =>
                {
                    b.Property<string>("MaSv")
                        .HasMaxLength(15)
                        .HasColumnType("nchar(15)")
                        .HasColumnName("MaSV")
                        .IsFixedLength();

                    b.Property<int?>("Diem15p")
                        .HasColumnType("int");

                    b.Property<int?>("DiemChuyenCan")
                        .HasColumnType("int");

                    b.Property<int?>("DiemHs1")
                        .HasColumnType("int")
                        .HasColumnName("DiemHS1");

                    b.Property<int?>("DiemHs2")
                        .HasColumnType("int")
                        .HasColumnName("DiemHS2");

                    b.Property<int?>("DiemHs3")
                        .HasColumnType("int")
                        .HasColumnName("DiemHS3");

                    b.Property<int?>("DiemMieng")
                        .HasColumnType("int");

                    b.Property<int?>("DiemTb")
                        .HasColumnType("int")
                        .HasColumnName("DiemTB");

                    b.Property<string>("MaGv")
                        .HasMaxLength(15)
                        .HasColumnType("nchar(15)")
                        .HasColumnName("MaGV")
                        .IsFixedLength();

                    b.Property<string>("MaMh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("MaMH")
                        .IsFixedLength();

                    b.HasKey("MaSv");

                    b.HasIndex("MaGv");

                    b.ToTable("Bangdiem", (string)null);
                });

            modelBuilder.Entity("Du_An.Models.GiaoVien", b =>
                {
                    b.Property<string>("MaGv")
                        .HasMaxLength(15)
                        .HasColumnType("nchar(15)")
                        .HasColumnName("MaGV")
                        .IsFixedLength();

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .IsFixedLength();

                    b.Property<int?>("IdnienKhoa")
                        .HasColumnType("int")
                        .HasColumnName("IDNienKhoa");

                    b.Property<string>("IdvaiTro")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("IDVaiTro")
                        .IsFixedLength();

                    b.Property<string>("MaLop")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("MaMh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("MaMH")
                        .IsFixedLength();

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("TenGv")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TenGV");

                    b.HasKey("MaGv");

                    b.HasIndex("IdnienKhoa");

                    b.HasIndex("IdvaiTro");

                    b.HasIndex("MaLop");

                    b.ToTable("GiaoVien", (string)null);
                });

            modelBuilder.Entity("Du_An.Models.LoginGv", b =>
                {
                    b.Property<int>("IdLoginGv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdLoginGV");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLoginGv"), 1L, 1);

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.Property<string>("MaGv")
                        .HasMaxLength(15)
                        .HasColumnType("nchar(15)")
                        .HasColumnName("MaGV")
                        .IsFixedLength();

                    b.Property<string>("Password")
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .IsFixedLength();

                    b.Property<string>("Username")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.HasKey("IdLoginGv");

                    b.HasIndex("MaGv");

                    b.ToTable("LoginGV", (string)null);
                });

            modelBuilder.Entity("Du_An.Models.LoginSv", b =>
                {
                    b.Property<int>("IdloginSv")
                        .HasColumnType("int")
                        .HasColumnName("IdloginSV");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.Property<string>("MaSv")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nchar(15)")
                        .HasColumnName("MaSV")
                        .IsFixedLength();

                    b.Property<string>("Password")
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)")
                        .IsFixedLength();

                    b.Property<string>("Username")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.HasKey("IdloginSv")
                        .HasName("PK_Account");

                    b.HasIndex("MaSv");

                    b.ToTable("LoginSV", (string)null);
                });

            modelBuilder.Entity("Du_An.Models.Lop", b =>
                {
                    b.Property<string>("MaLop")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("PhongHoc")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.Property<string>("TenLop")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.HasKey("MaLop");

                    b.ToTable("Lop", (string)null);
                });

            modelBuilder.Entity("Du_An.Models.Monhoc", b =>
                {
                    b.Property<string>("MaMh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("MaMH")
                        .IsFixedLength();

                    b.Property<string>("TenMh")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("TenMH");

                    b.HasKey("MaMh");

                    b.ToTable("Monhoc", (string)null);
                });

            modelBuilder.Entity("Du_An.Models.NienKhoa", b =>
                {
                    b.Property<int>("IdnienKhoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDNienKhoa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdnienKhoa"), 1L, 1);

                    b.Property<string>("NienKhoa1")
                        .HasMaxLength(15)
                        .HasColumnType("nchar(15)")
                        .HasColumnName("NienKhoa")
                        .IsFixedLength();

                    b.HasKey("IdnienKhoa");

                    b.ToTable("NienKhoa", (string)null);
                });

            modelBuilder.Entity("Du_An.Models.Sinhvien", b =>
                {
                    b.Property<string>("MaSv")
                        .HasMaxLength(15)
                        .HasColumnType("nchar(15)")
                        .HasColumnName("MaSV")
                        .IsFixedLength();

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .IsFixedLength();

                    b.Property<string>("Gvcn")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("GVCN");

                    b.Property<int?>("IdnienKhoa")
                        .HasColumnType("int")
                        .HasColumnName("IDNienKhoa");

                    b.Property<string>("MaLop")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("MaMh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("MaMH")
                        .IsFixedLength();

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("TenSv")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("TenSV");

                    b.HasKey("MaSv")
                        .HasName("PK_SV");

                    b.HasIndex("IdnienKhoa");

                    b.HasIndex("MaLop");

                    b.HasIndex("MaMh");

                    b.ToTable("Sinhvien", (string)null);
                });

            modelBuilder.Entity("Du_An.Models.VaiTroGiaoVien", b =>
                {
                    b.Property<string>("IdvaiTro")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("IDVaiTro")
                        .IsFixedLength();

                    b.Property<string>("TenVaiTro")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdvaiTro");

                    b.ToTable("VaiTroGiaoVien", (string)null);
                });

            modelBuilder.Entity("Du_An.Models.Bangdiem", b =>
                {
                    b.HasOne("Du_An.Models.GiaoVien", "MaGvNavigation")
                        .WithMany("Bangdiems")
                        .HasForeignKey("MaGv")
                        .HasConstraintName("FK_Bangdiem_GiaoVien");

                    b.HasOne("Du_An.Models.Sinhvien", "MaSvNavigation")
                        .WithOne("Bangdiem")
                        .HasForeignKey("Du_An.Models.Bangdiem", "MaSv")
                        .IsRequired()
                        .HasConstraintName("FK_Bangdiem_Sinhvien");

                    b.Navigation("MaGvNavigation");

                    b.Navigation("MaSvNavigation");
                });

            modelBuilder.Entity("Du_An.Models.GiaoVien", b =>
                {
                    b.HasOne("Du_An.Models.NienKhoa", "IdnienKhoaNavigation")
                        .WithMany("GiaoViens")
                        .HasForeignKey("IdnienKhoa")
                        .HasConstraintName("FK_GiaoVien_NienKhoa");

                    b.HasOne("Du_An.Models.VaiTroGiaoVien", "IdvaiTroNavigation")
                        .WithMany("GiaoViens")
                        .HasForeignKey("IdvaiTro")
                        .HasConstraintName("FK_GiaoVien_VaiTroGiaoVien");

                    b.HasOne("Du_An.Models.Lop", "MaLopNavigation")
                        .WithMany("GiaoViens")
                        .HasForeignKey("MaLop")
                        .HasConstraintName("FK_GiaoVien_Lop");

                    b.Navigation("IdnienKhoaNavigation");

                    b.Navigation("IdvaiTroNavigation");

                    b.Navigation("MaLopNavigation");
                });

            modelBuilder.Entity("Du_An.Models.LoginGv", b =>
                {
                    b.HasOne("Du_An.Models.GiaoVien", "MaGvNavigation")
                        .WithMany("LoginGvs")
                        .HasForeignKey("MaGv")
                        .HasConstraintName("FK_LoginGV_GiaoVien");

                    b.Navigation("MaGvNavigation");
                });

            modelBuilder.Entity("Du_An.Models.LoginSv", b =>
                {
                    b.HasOne("Du_An.Models.Sinhvien", "MaSvNavigation")
                        .WithMany("LoginSvs")
                        .HasForeignKey("MaSv")
                        .IsRequired()
                        .HasConstraintName("FK_LoginSV_Sinhvien");

                    b.Navigation("MaSvNavigation");
                });

            modelBuilder.Entity("Du_An.Models.Sinhvien", b =>
                {
                    b.HasOne("Du_An.Models.NienKhoa", "IdnienKhoaNavigation")
                        .WithMany("Sinhviens")
                        .HasForeignKey("IdnienKhoa")
                        .HasConstraintName("FK_Sinhvien_NienKhoa");

                    b.HasOne("Du_An.Models.Lop", "MaLopNavigation")
                        .WithMany("Sinhviens")
                        .HasForeignKey("MaLop")
                        .IsRequired()
                        .HasConstraintName("FK_Sinhvien_Lop");

                    b.HasOne("Du_An.Models.Monhoc", "MaMhNavigation")
                        .WithMany("Sinhviens")
                        .HasForeignKey("MaMh")
                        .HasConstraintName("FK_Sinhvien_Monhoc");

                    b.Navigation("IdnienKhoaNavigation");

                    b.Navigation("MaLopNavigation");

                    b.Navigation("MaMhNavigation");
                });

            modelBuilder.Entity("Du_An.Models.GiaoVien", b =>
                {
                    b.Navigation("Bangdiems");

                    b.Navigation("LoginGvs");
                });

            modelBuilder.Entity("Du_An.Models.Lop", b =>
                {
                    b.Navigation("GiaoViens");

                    b.Navigation("Sinhviens");
                });

            modelBuilder.Entity("Du_An.Models.Monhoc", b =>
                {
                    b.Navigation("Sinhviens");
                });

            modelBuilder.Entity("Du_An.Models.NienKhoa", b =>
                {
                    b.Navigation("GiaoViens");

                    b.Navigation("Sinhviens");
                });

            modelBuilder.Entity("Du_An.Models.Sinhvien", b =>
                {
                    b.Navigation("Bangdiem")
                        .IsRequired();

                    b.Navigation("LoginSvs");
                });

            modelBuilder.Entity("Du_An.Models.VaiTroGiaoVien", b =>
                {
                    b.Navigation("GiaoViens");
                });
#pragma warning restore 612, 618
        }
    }
}
