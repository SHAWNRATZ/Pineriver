using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PineriverASPNETPage.Pages.Identity.Roles
{
    public class IndexModel : PageModel
    {

        private readonly RoleManager<IdentityRole> _roleManager;

        public IndexModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        #region Properties
        public IEnumerable<IdentityRole> Roles { get; set; }
        #endregion

        public void OnGet() => Roles = _roleManager.Roles;
    }
}