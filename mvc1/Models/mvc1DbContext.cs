using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvc1.Models
{
    public class mvc1DbContext : DbContext
    {
        public mvc1DbContext
        (DbContextOptions<mvc1DbContext> options) : 
            base(options) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Customers> Customers { get; set; }

       
    }
}
