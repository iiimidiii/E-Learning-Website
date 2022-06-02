using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Du_An.Models
{
    public partial class ElearnningContext : DbContext
    {
        public ElearnningContext()
        {
        }

        public ElearnningContext(DbContextOptions<ElearnningContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bangdiem> Bangdiems { get; set; } = null!;
        public virtual DbSet<GiaoVien> GiaoViens { get; set; } = null!;
        public virtual DbSet<LoginGv> LoginGvs { get; set; } = null!;
        public virtual DbSet<LoginL> LoginLs { get; set; } = null!;
        public virtual DbSet<LoginSv> LoginSvs { get; set; } = null!;
        public virtual DbSet<Lop> Lops { get; set; } = null!;
        public virtual DbSet<Monhoc> Monhocs { get; set; } = null!;
        public virtual DbSet<NienKhoa> NienKhoas { get; set; } = null!;
        public virtual DbSet<Sinhvien> Sinhviens { get; set; } = null!;
        public virtual DbSet<VaiTroGiaoVien> VaiTroGiaoViens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=BINH\\BINH;Database=Elearnning;Trusted_connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bangdiem>(entity =>
            {
                entity.HasKey(e => e.MaSv);

                entity.ToTable("Bangdiem");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(15)
                    .HasColumnName("MaSV")
                    .IsFixedLength();

                entity.Property(e => e.DiemHs1).HasColumnName("DiemHS1");

                entity.Property(e => e.DiemHs2).HasColumnName("DiemHS2");

                entity.Property(e => e.DiemHs3).HasColumnName("DiemHS3");

                entity.Property(e => e.DiemTb).HasColumnName("DiemTB");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(15)
                    .HasColumnName("MaGV")
                    .IsFixedLength();

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .HasColumnName("MaMH")
                    .IsFixedLength();

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.Bangdiems)
                    .HasForeignKey(d => d.MaGv)
                    .HasConstraintName("FK_Bangdiem_GiaoVien");

                entity.HasOne(d => d.MaSvNavigation)
                    .WithOne(p => p.Bangdiem)
                    .HasForeignKey<Bangdiem>(d => d.MaSv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bangdiem_Sinhvien");
            });

            modelBuilder.Entity<GiaoVien>(entity =>
            {
                entity.HasKey(e => e.MaGv);

                entity.ToTable("GiaoVien");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(15)
                    .HasColumnName("MaGV")
                    .IsFixedLength();

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.IdnienKhoa).HasColumnName("IDNienKhoa");

                entity.Property(e => e.IdvaiTro)
                    .HasMaxLength(10)
                    .HasColumnName("IDVaiTro")
                    .IsFixedLength();

                entity.Property(e => e.MaLop)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .HasColumnName("MaMH")
                    .IsFixedLength();

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.TenGv)
                    .HasMaxLength(250)
                    .HasColumnName("TenGV");

                entity.HasOne(d => d.IdnienKhoaNavigation)
                    .WithMany(p => p.GiaoViens)
                    .HasForeignKey(d => d.IdnienKhoa)
                    .HasConstraintName("FK_GiaoVien_NienKhoa");

                entity.HasOne(d => d.IdvaiTroNavigation)
                    .WithMany(p => p.GiaoViens)
                    .HasForeignKey(d => d.IdvaiTro)
                    .HasConstraintName("FK_GiaoVien_VaiTroGiaoVien");

                entity.HasOne(d => d.MaLopNavigation)
                    .WithMany(p => p.GiaoViens)
                    .HasForeignKey(d => d.MaLop)
                    .HasConstraintName("FK_GiaoVien_Lop");
            });

            modelBuilder.Entity<LoginGv>(entity =>
            {
                entity.HasKey(e => e.IdLoginGv);

                entity.ToTable("LoginGV");

                entity.Property(e => e.IdLoginGv).HasColumnName("IdLoginGV");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MaGv)
                    .HasMaxLength(15)
                    .HasColumnName("MaGV")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.MaGvNavigation)
                    .WithMany(p => p.LoginGvs)
                    .HasForeignKey(d => d.MaGv)
                    .HasConstraintName("FK_LoginGV_GiaoVien");
            });

            modelBuilder.Entity<LoginL>(entity =>
            {
                entity.HasKey(e => e.IdLoginLs);

                entity.ToTable("LoginLS");

                entity.Property(e => e.IdLoginLs)
                    .HasMaxLength(10)
                    .HasColumnName("IdLoginLS")
                    .IsFixedLength();

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LoginSv>(entity =>
            {
                entity.HasKey(e => e.IdloginSv)
                    .HasName("PK_Account");

                entity.ToTable("LoginSV");

                entity.Property(e => e.IdloginSv)
                    .ValueGeneratedNever()
                    .HasColumnName("IdloginSV");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MaSv)
                    .HasMaxLength(15)
                    .HasColumnName("MaSV")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.MaSvNavigation)
                    .WithMany(p => p.LoginSvs)
                    .HasForeignKey(d => d.MaSv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoginSV_Sinhvien");
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.HasKey(e => e.MaLop);

                entity.ToTable("Lop");

                entity.Property(e => e.MaLop)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ChiTiet).HasMaxLength(250);

                entity.Property(e => e.PhongHoc)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.TenLop)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Monhoc>(entity =>
            {
                entity.HasKey(e => e.MaMh);

                entity.ToTable("Monhoc");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .HasColumnName("MaMH")
                    .IsFixedLength();

                entity.Property(e => e.TenMh)
                    .HasMaxLength(150)
                    .HasColumnName("TenMH");
            });

            modelBuilder.Entity<NienKhoa>(entity =>
            {
                entity.HasKey(e => e.IdnienKhoa);

                entity.ToTable("NienKhoa");

                entity.Property(e => e.IdnienKhoa).HasColumnName("IDNienKhoa");

                entity.Property(e => e.NienKhoa1)
                    .HasMaxLength(15)
                    .HasColumnName("NienKhoa")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sinhvien>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK_SV");

                entity.ToTable("Sinhvien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(15)
                    .HasColumnName("MaSV")
                    .IsFixedLength();

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Gvcn)
                    .HasMaxLength(250)
                    .HasColumnName("GVCN");

                entity.Property(e => e.IdnienKhoa).HasColumnName("IDNienKhoa");

                entity.Property(e => e.MaLop)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .HasColumnName("MaMH")
                    .IsFixedLength();

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.TenSv)
                    .HasMaxLength(250)
                    .HasColumnName("TenSV");

                entity.HasOne(d => d.IdnienKhoaNavigation)
                    .WithMany(p => p.Sinhviens)
                    .HasForeignKey(d => d.IdnienKhoa)
                    .HasConstraintName("FK_Sinhvien_NienKhoa");

                entity.HasOne(d => d.MaLopNavigation)
                    .WithMany(p => p.Sinhviens)
                    .HasForeignKey(d => d.MaLop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sinhvien_Lop");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.Sinhviens)
                    .HasForeignKey(d => d.MaMh)
                    .HasConstraintName("FK_Sinhvien_Monhoc");
            });

            modelBuilder.Entity<VaiTroGiaoVien>(entity =>
            {
                entity.HasKey(e => e.IdvaiTro);

                entity.ToTable("VaiTroGiaoVien");

                entity.Property(e => e.IdvaiTro)
                    .HasMaxLength(10)
                    .HasColumnName("IDVaiTro")
                    .IsFixedLength();

                entity.Property(e => e.TenVaiTro).HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
