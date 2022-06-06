using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Du_An.Models
{
    public partial class ELearningContext : DbContext
    {
        public ELearningContext()
        {
        }

        public ELearningContext(DbContextOptions<ELearningContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bangdiem> Bangdiems { get; set; } = null!;
        public virtual DbSet<GiaoVien> GiaoViens { get; set; } = null!;
        public virtual DbSet<HocSinh> HocSinhs { get; set; } = null!;
        public virtual DbSet<Leadership> Leaderships { get; set; } = null!;
        public virtual DbSet<LoginGv> LoginGvs { get; set; } = null!;
        public virtual DbSet<LoginH> LoginHs { get; set; } = null!;
        public virtual DbSet<LoginL> LoginLs { get; set; } = null!;
        public virtual DbSet<Lop> Lops { get; set; } = null!;
        public virtual DbSet<Monhoc> Monhocs { get; set; } = null!;
        public virtual DbSet<NienKhoa> NienKhoas { get; set; } = null!;
        public virtual DbSet<QuyenHan> QuyenHans { get; set; } = null!;
        public virtual DbSet<VaiTroGiaoVien> VaiTroGiaoViens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.\\BINH;Database=ELearning;Trusted_Connection=True;");
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

                entity.Property(e => e.MaQuyenHan)
                    .HasMaxLength(10)
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

                entity.HasOne(d => d.MaQuyenHanNavigation)
                    .WithMany(p => p.GiaoViens)
                    .HasForeignKey(d => d.MaQuyenHan)
                    .HasConstraintName("FK_GiaoVien_QuyenHan");
            });

            modelBuilder.Entity<HocSinh>(entity =>
            {
                entity.HasKey(e => e.MaHs)
                    .HasName("PK_SV");

                entity.ToTable("HocSinh");

                entity.Property(e => e.MaHs)
                    .HasMaxLength(15)
                    .HasColumnName("MaHS")
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

                entity.Property(e => e.TenHs)
                    .HasMaxLength(250)
                    .HasColumnName("TenHS");

                entity.HasOne(d => d.IdnienKhoaNavigation)
                    .WithMany(p => p.HocSinhs)
                    .HasForeignKey(d => d.IdnienKhoa)
                    .HasConstraintName("FK_Sinhvien_NienKhoa");

                entity.HasOne(d => d.MaLopNavigation)
                    .WithMany(p => p.HocSinhs)
                    .HasForeignKey(d => d.MaLop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sinhvien_Lop");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.HocSinhs)
                    .HasForeignKey(d => d.MaMh)
                    .HasConstraintName("FK_Sinhvien_Monhoc");
            });

            modelBuilder.Entity<Leadership>(entity =>
            {
                entity.HasKey(e => e.MaLs);

                entity.ToTable("Leadership");

                entity.Property(e => e.MaLs).HasColumnName("MaLS");

                entity.Property(e => e.ChucVu).HasMaxLength(250);

                entity.Property(e => e.MaQuyenHan)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.TenLs)
                    .HasMaxLength(250)
                    .HasColumnName("TenLS");

                entity.HasOne(d => d.MaQuyenHanNavigation)
                    .WithMany(p => p.Leaderships)
                    .HasForeignKey(d => d.MaQuyenHan)
                    .HasConstraintName("FK_Leadership_QuyenHan");
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

            modelBuilder.Entity<LoginH>(entity =>
            {
                entity.HasKey(e => e.IdloginHs)
                    .HasName("PK_Account");

                entity.ToTable("LoginHS");

                entity.Property(e => e.IdloginHs)
                    .ValueGeneratedNever()
                    .HasColumnName("IdloginHS");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MaHs)
                    .HasMaxLength(15)
                    .HasColumnName("MaHS")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.MaHsNavigation)
                    .WithMany(p => p.LoginHs)
                    .HasForeignKey(d => d.MaHs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoginHS_HocSinh");
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

                entity.Property(e => e.MaLs)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MaLS");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.MaLsNavigation)
                    .WithMany(p => p.LoginLs)
                    .HasForeignKey(d => d.MaLs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoginLS_Leadership");
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

            modelBuilder.Entity<QuyenHan>(entity =>
            {
                entity.HasKey(e => e.MaQuyenHan);

                entity.ToTable("QuyenHan");

                entity.Property(e => e.MaQuyenHan)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ChiTietQuyenHan).HasMaxLength(250);

                entity.Property(e => e.TenQuyenHan).HasMaxLength(150);
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
