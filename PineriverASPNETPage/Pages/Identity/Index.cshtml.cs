using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PineriverASPNETPage.Models;

namespace PineriverASPNETPage.Pages.Identity
{
    public class IndexModel : PageModel
    {
        private UserManager<PineriverUser> _userManager { get; set; }

        public IndexModel(UserManager<PineriverUser> userManager)
        {
            _userManager = userManager;
        }


        #region Properties
        public IEnumerable<PineriverUser> Users { get; set; }
        #endregion

        public void OnGet()
        {
            Users = _userManager.Users;
        }
    }
}