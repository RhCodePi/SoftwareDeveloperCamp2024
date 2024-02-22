using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities.Concrete.Models.Db;

public partial class CoursedbContext : DbContext
{
    public CoursedbContext()
    {
    }

    public CoursedbContext(DbContextOptions<CoursedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=localhost;database=coursedb;user=root;password=05291453@AvMy.");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategory).HasName("PRIMARY");

            entity.ToTable("category");

            entity.Property(e => e.IdCategory).HasColumnName("idCategory");
            entity.Property(e => e.Categories)
                .HasColumnType("enum('CyberSecurity','Programming')")
                .HasColumnName("categories");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Idcourse).HasName("PRIMARY");

            entity.ToTable("course");

            entity.HasIndex(e => e.CategoryId, "categoryId");

            entity.HasIndex(e => e.InstructorId, "instructorId");

            entity.Property(e => e.Idcourse).HasColumnName("idcourse");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.InstructorId).HasColumnName("instructorId");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");

            entity.HasOne(d => d.Category).WithMany(p => p.Courses)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("categoryId");

            entity.HasOne(d => d.Instructor).WithMany(p => p.Courses)
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("instructorId");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.IdInstructor).HasName("PRIMARY");

            entity.ToTable("instructor");

            entity.Property(e => e.IdInstructor).HasColumnName("idInstructor");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
