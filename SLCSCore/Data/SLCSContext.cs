using System;
using Microsoft.EntityFrameworkCore;
using SLCSCore.Models;

namespace SLCSCore.Data
{
    public class SLCSContext : DbContext
    {
        public SLCSContext(DbContextOptions<SLCSContext> options) : base(options)
        {
        }

        public DbSet<Book> Book{get;set;}
        public DbSet<BrorrowLog> BrorrowLog { get; set; }
        public DbSet<Reserve> Reserve { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<ParameterSet> ParameterSet { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasKey(b => b.B_Id);
            modelBuilder.Entity<BrorrowLog>()
               .HasKey(b => b.BL_Id);
            modelBuilder.Entity<Reserve>()
               .HasKey(b => b.R_Id);
            modelBuilder.Entity<User>()
               .HasKey(b => b.U_Id);
            modelBuilder.Entity<Location>()
               .HasKey(b => b.L_Id);
            modelBuilder.Entity<ParameterSet>()
               .HasKey(b => b.PS_Id);
        }
    }
}
