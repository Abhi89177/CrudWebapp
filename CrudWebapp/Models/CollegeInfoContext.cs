using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CrudWebapp.Models;

public partial class CollegeInfoContext : DbContext
{
    public CollegeInfoContext()
    {
    }

    public CollegeInfoContext(DbContextOptions<CollegeInfoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StudentBranch)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Student_Branch");
            entity.Property(e => e.StudentMobile)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Student_Mobile");
            entity.Property(e => e.StudentName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Student_Name");
            entity.Property(e => e.StudentSection)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Student_Section");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
