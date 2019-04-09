using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PineriverASPNETPage.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AccountUser class
    public class AccountUser : IdentityUser
    {
        public int Steam_ID { get; set; }
        public string Steam_Name { get; set; }
    }
}
