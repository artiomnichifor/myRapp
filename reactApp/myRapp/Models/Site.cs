using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myRapp.Models
{
    public class SiteContext : DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options)
            : base(options)
        { }

        public DbSet<Site> Sites { get; set; }
    }

    public class Site
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Interval { get; set; }
    }
}
