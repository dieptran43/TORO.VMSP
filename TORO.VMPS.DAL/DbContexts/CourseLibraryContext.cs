using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TORO.VMPS.DAL.Entities;

namespace TORO.VMPS.DAL.DbContexts
{
    public class CourseLibraryContext : DbContext
    {
        public CourseLibraryContext(DbContextOptions<CourseLibraryContext> options)
           : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
