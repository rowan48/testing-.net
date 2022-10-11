using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreOne.Entities;

namespace WebCoreOne.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>();

        }
        public DbSet<People> peoples { get; set; }
        public DbSet<PersonAdresss> PeopleAdressss { get; set; }

    }
}
