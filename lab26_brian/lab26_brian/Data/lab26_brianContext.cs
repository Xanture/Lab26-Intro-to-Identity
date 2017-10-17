using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab26_brian.Models
{
    public class lab26_brianContext : DbContext
    {
        public lab26_brianContext (DbContextOptions<lab26_brianContext> options)
            : base(options)
        {
        }

        public DbSet<lab26_brian.Models.CMS> CMS { get; set; }
    }
}
