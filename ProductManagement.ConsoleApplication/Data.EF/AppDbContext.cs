using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProductManagement.ConsoleApplication.Data.Entities;
using ProductManagement.ConsoleApplication.Data.Interfaces;

namespace ProductManagement.ConsoleApplication.Data.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Chapter> Chapters { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<SubjectChapterDetail> SubjectChapterDetails { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
            foreach (var item in modified)
            {
                var changedOrAddedItem = item.Entity as IDateTracking;
                if (changedOrAddedItem == null) continue;
                if (item.State == EntityState.Added)
                {
                    changedOrAddedItem.DateCreated = DateTime.Now;
                }

                changedOrAddedItem.DateModified = DateTime.Now;
            }

            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-KNS39N1\SQLEXPRESS;Database=QuizzConsoleManagement;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}