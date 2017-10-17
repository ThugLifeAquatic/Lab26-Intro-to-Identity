using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Intro2Identity.Models
{
    public class Intro2IdentityContext : DbContext
    {
        public Intro2IdentityContext (DbContextOptions<Intro2IdentityContext> options)
            : base(options)
        {
        }

        public DbSet<Intro2Identity.Models.CMS> CMS { get; set; }
    }
}
