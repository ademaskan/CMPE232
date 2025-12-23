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
        }

        public DbSet<DataAccess.COURSE_ENROLLMENT> COURSE_ENROLLMENT { get; set; } = default!;
        public DbSet<DataAccess.BRANCH> BRANCH { get; set; } = default!;
        public DbSet<DataAccess.BRANCH_PERFORMANCE> BRANCH_PERFORMANCE { get; set; } = default!;
        public DbSet<DataAccess.COURSE_CATEGORY> COURSE_CATEGORY { get; set; } = default!;
        public DbSet<DataAccess.EMPLOYEE> EMPLOYEE { get; set; } = default!;
        public DbSet<DataAccess.FINANCIAL_RECORD> FINANCIAL_RECORD { get; set; } = default!;
        public DbSet<DataAccess.MEMBER> MEMBER { get; set; } = default!;
        public DbSet<DataAccess.MEMBERSHIP> MEMBERSHIP { get; set; } = default!;
    }
}
