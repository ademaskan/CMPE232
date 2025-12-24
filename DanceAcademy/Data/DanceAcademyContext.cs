using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess;

namespace DanceAcademy.Data
{
    public class DanceAcademyContext : DbContext
    {
        public DanceAcademyContext (DbContextOptions<DanceAcademyContext> options)
            : base(options)
        {
            // Disable lazy loading to prevent circular reference issues
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<DataAccess.COURSE_ENROLLMENT> COURSE_ENROLLMENT { get; set; } = default!;
        public DbSet<DataAccess.BRANCH> BRANCH { get; set; } = default!;
        public DbSet<DataAccess.BRANCH_PERFORMANCE> BRANCH_PERFORMANCE { get; set; } = default!;
        public DbSet<DataAccess.COURSE_CATEGORY> COURSE_CATEGORY { get; set; } = default!;
        public DbSet<DataAccess.EMPLOYEE> EMPLOYEE { get; set; } = default!;
        public DbSet<DataAccess.FINANCIAL_RECORD> FINANCIAL_RECORD { get; set; } = default!;
        public DbSet<DataAccess.MEMBER> MEMBER { get; set; } = default!;
        public DbSet<DataAccess.MEMBERSHIP> MEMBERSHIP { get; set; } = default!;
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships to prevent circular references
            modelBuilder.Entity<COURSE_ENROLLMENT>()
                .HasOne(e => e.MEMBER)
                .WithMany(m => m.COURSE_ENROLLMENT)
                .HasForeignKey(e => e.MEMBERID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<COURSE_ENROLLMENT>()
                .HasOne(e => e.COURSE_CATEGORY)
                .WithMany(c => c.COURSE_ENROLLMENT)
                .HasForeignKey(e => e.COURSE_CATEGORYID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MEMBERSHIP>()
                .HasOne(m => m.MEMBER)
                .WithMany(mem => mem.MEMBERSHIPs)
                .HasForeignKey(m => m.MEMBERID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MEMBERSHIP>()
                .HasOne(m => m.BRANCH)
                .WithMany(b => b.MEMBERSHIPs)
                .HasForeignKey(m => m.BRANCHID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FINANCIAL_RECORD>()
                .HasOne(f => f.BRANCH)
                .WithMany(b => b.FINANCIAL_RECORD)
                .HasForeignKey(f => f.BRANCHID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FINANCIAL_RECORD>()
                .HasOne(f => f.MEMBER)
                .WithMany(m => m.FINANCIAL_RECORD)
                .HasForeignKey(f => f.MEMBERID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EMPLOYEE>()
                .HasOne(e => e.BRANCH)
                .WithMany(b => b.EMPLOYEEs)
                .HasForeignKey(e => e.BRANCHID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BRANCH_PERFORMANCE>()
                .HasOne(bp => bp.BRANCH)
                .WithMany(b => b.BRANCH_PERFORMANCE)
                .HasForeignKey(bp => bp.BRANCHID)
                .OnDelete(DeleteBehavior.Restrict);
        }*/
    }
}
