using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TopLib.Models
{
    public partial class TopicsContext : DbContext
    {
        public TopicsContext()
        {
        }

        public TopicsContext(DbContextOptions<TopicsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Topic> Topic { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;database=Topics;trusted_connection=true;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.InProgress).HasMaxLength(1);

                entity.Property(e => e.SourceOf).HasMaxLength(500);

                entity.Property(e => e.StartLearningDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
