using Microsoft.EntityFrameworkCore;
using StudentCrud.Model;
using System;

namespace StudentCrud.Data
{  

    public class MainDBContext : DbContext
    {
        public MainDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Students> students { get; set; }
    }
}

