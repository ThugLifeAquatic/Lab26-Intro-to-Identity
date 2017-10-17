using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intro2Identity.Models
{
    public class CrewMember : IdentityUser
    {
        public string Rank { get; set; }
        public Channel Department { get; set; }
    }
}
