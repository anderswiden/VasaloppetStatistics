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

        }
        //... other code removed for clarity
    }
}
