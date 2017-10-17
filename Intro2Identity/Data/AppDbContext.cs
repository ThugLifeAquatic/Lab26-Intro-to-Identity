using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Intro2Identity.Models;
using Microsoft.EntityFrameworkCore;

namespace Intro2Identity.Data
{
    public class AppDbContext : IdentityDbContext<CrewMember>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Intro2Identity.Models.CrewMember> CrewMember { get; set; }
    }
}
