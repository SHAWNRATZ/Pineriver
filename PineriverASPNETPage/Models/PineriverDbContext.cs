using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PineriverASPNETPage.Models
{
    public class PineriverDbContext : IdentityDbContext<PineriverUser>
    {
        public PineriverDbContext(DbContextOptions<PineriverDbContext> options)
            : base(options) { }
    }
}
