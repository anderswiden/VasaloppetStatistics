using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VLStatDataLayer
{
    public class AppDbContext : DbContext
    {
        DbSet<RaceResult> Race;

        //... properties removed for clarity
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data used during development
            modelBuilder.Entity<RaceType>().HasData(new RaceType { RaceTypeId = 1, Name = "ÖS S", Description = "Öppet spår söndag"});
            modelBuilder.Entity<Race>().HasData(new Race { RaceId = 1, Racetime = new DateTime(2019,2, 24), RaceTypeId = 1 });

            modelBuilder.Entity<RaceResult>().HasData(new RaceResult { RaceResultId = 1, StartNumber = 495, FirstName = "Anders", LastName = "Widén", RaceId = 1});
            modelBuilder.Entity<Split>().HasData(new Split { SplitId = 1, CheckPointIndex = 0, SplitTime = new DateTime(2019, 2, 24, 7, 20, 5), RaceResultId = 1 });
            modelBuilder.Entity<Split>().HasData(new Split { SplitId = 2, CheckPointIndex = 1, SplitTime = new DateTime(2019, 2, 24, 8, 5, 23), RaceResultId = 1 });
            modelBuilder.Entity<Split>().HasData(new Split { SplitId = 3, CheckPointIndex = 2, SplitTime = new DateTime(2019, 2, 24, 9, 10, 18), RaceResultId = 1 });
            modelBuilder.Entity<Split>().HasData(new Split { SplitId = 4, CheckPointIndex = 3, SplitTime = new DateTime(2019, 2, 24, 10, 11, 43), RaceResultId = 1 });
            modelBuilder.Entity<Split>().HasData(new Split { SplitId = 5, CheckPointIndex = 4, SplitTime = new DateTime(2019, 2, 24, 11, 1, 56), RaceResultId = 1 });
            modelBuilder.Entity<Split>().HasData(new Split { SplitId = 6, CheckPointIndex = 5, SplitTime = new DateTime(2019, 2, 24, 12, 10, 6), RaceResultId = 1 });
            modelBuilder.Entity<Split>().HasData(new Split { SplitId = 7, CheckPointIndex = 6, SplitTime = new DateTime(2019, 2, 24, 13, 37, 8), RaceResultId = 1 });
            modelBuilder.Entity<Split>().HasData(new Split { SplitId = 8, CheckPointIndex = 7, SplitTime = new DateTime(2019, 2, 24, 14, 30, 3), RaceResultId = 1 });
            modelBuilder.Entity<Split>().HasData(new Split { SplitId = 9, CheckPointIndex = 8, SplitTime = new DateTime(2019, 2, 24, 15, 12, 55), RaceResultId = 1 });
        }
        //... other code removed for clarity
    }
}
