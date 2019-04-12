using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PineriverASPNETPage.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<PineriverUser> Members { get; set; }
        public IEnumerable<PineriverUser> NonMembers { get; set; }
    }
}
