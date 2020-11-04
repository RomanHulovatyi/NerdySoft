using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NerdySoftTest.Models
{
    public class AnnouncementContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }
        public AnnouncementContext(DbContextOptions<AnnouncementContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Announcement>()
                .ToTable("Announcement").HasKey(p => p.Id);
        }
    }
}
