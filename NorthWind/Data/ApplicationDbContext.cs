using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthWind.Models;
using Microsoft.EntityFrameworkCore;

namespace NorthWind.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Accountability> Accountabilites { get; set; }
        //public DbSet<AccountabilityType> AccountabilityTypes { get; set; }
        //public DbSet<Person> Persons { get; set; }
        //public DbSet<TimePeriod> TimePeriods { get; set; }
       // public DbSet<Organization> Organizations { get; set; }
        public DbSet<Party> Parties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Accountability>().HasOne(z => z.Responsible).WithOne(x => x.Accountability).HasForeignKey(k=>k.);



        }

    }
}
