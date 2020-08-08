using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace assignment03.Models
{
    public partial class H19DBContext : DbContext
    {
        public virtual DbSet<Population> Population { get; set; }
        /*
       public virtual DbSet<Standard> Standard { get; set; }
       public virtual DbSet<Student> Student { get; set; }
       public virtual DbSet<StudentAddress> StudentAddress { get; set; }
       public virtual DbSet<StudentCourse> StudentCourse { get; set; }
       public virtual DbSet<Teacher> Teacher { get; set; }
       */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                */
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-K6BNAG4\SQLEXPRESS;Database=H19;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Population>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.County)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPopulation).HasColumnName("Population")
                    .IsUnicode(false);
            });
        }
    }
}