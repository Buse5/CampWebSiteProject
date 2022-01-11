using Microsoft.EntityFrameworkCore;
using CampModel.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampData
{
   public class CampDbContext :DbContext
    {
        public CampDbContext()
        {
                
        }

        public CampDbContext(DbContextOptions<CampDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Camp> Camps { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<City> Cities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
             optionsBuilder.UseSqlServer("Server=DESKTOP-MU38GRH\\MSSQLSRV;Database=CampingDB;Trusted_Connection=True;");
            }
        }

        
    }
}
