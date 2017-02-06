using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BusinessCardWebsite.Models
{
    public class SiteContext : DbContext
    {
        public SiteContext() : base("SiteConnection")
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}