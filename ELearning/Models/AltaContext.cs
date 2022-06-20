using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Eleaning_Web.Models
{
    public partial class AltaContext : DbContext
    {
        public AltaContext()
        {
        }

        public AltaContext(DbContextOptions<AltaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Exam> Exams { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<TestSchedule> TestSchedules { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\BINH;Database=Alta;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.ClassId).HasMaxLength(250);

                entity.Property(e => e.Link).HasMaxLength(250);

                entity.Property(e => e.NameClass).HasMaxLength(250);

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(250)
                    .HasColumnName("subjectId");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Class_Subject");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.Property(e => e.DocumentId).ValueGeneratedNever();

                entity.Property(e => e.IdSubject)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(250)
                    .HasColumnName("SubjectID");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Document_Subject");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.ToTable("Exam");

                entity.Property(e => e.ExamId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Descri)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ExamCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ExamDate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ExamName)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ExamType)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SubjectId).HasMaxLength(250);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Exam_Subject");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.ToTable("Result");

                entity.Property(e => e.ResultId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ExamDate).HasColumnType("date");

                entity.Property(e => e.ExamId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UserId)
                    .HasMaxLength(18)
                    .HasColumnName("UserID")
                    .IsFixedLength();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Result_User");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Role");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.SubjectId).HasMaxLength(250);

                entity.Property(e => e.EndDay).HasColumnType("datetime");

                entity.Property(e => e.Period)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StartDay).HasColumnType("datetime");

                entity.Property(e => e.SubjectName).HasMaxLength(250);
            });

            modelBuilder.Entity<TestSchedule>(entity =>
            {
                entity.ToTable("TestSchedule");

                entity.Property(e => e.TestScheduleId).ValueGeneratedNever();

                entity.Property(e => e.DayExam).HasColumnType("datetime");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId)
                    .HasMaxLength(18)
                    .HasColumnName("UserID")
                    .IsFixedLength();

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.Images).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
