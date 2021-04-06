using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookKeeping.Models
{
    public class BookKeepingContext : DbContext 
    {
        public BookKeepingContext(DbContextOptions<BookKeepingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookKeeper> Bookkeepers { get; set; } 
        public virtual DbSet<ClientModel> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    } 

}
