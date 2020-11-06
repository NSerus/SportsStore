using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class SportsStoreDbContext : DbContext
    {
        public SportsStoreDbContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Product> Products { get; set; }
    }
}
