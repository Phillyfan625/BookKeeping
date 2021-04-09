using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Models
{
    public class BookKeepingContext : DbContext 
    {
        public BookKeepingContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<BookKeeper> BookKeeper { get; set; } 
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet <Reviews> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //}
            base.OnConfiguring(optionsBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    } 

}
