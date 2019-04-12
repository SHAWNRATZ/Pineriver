using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PineriverASPNETPage.Models;

namespace PineriverASPNETPage.Pages.Identity.Roles
{
    public class UpdateModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<PineriverUser> _userManager;

        public UpdateModel(RoleManager<IdentityRole> roleManager, UserManager<PineriverUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [BindProperty]
        public RoleEdit RoleEdit { get; set; }

        [BindProperty]
        public RoleModification RoleModification { get; set; }

        public async Task OnGet(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            List<PineriverUser> members = new List<PineriverUser>();
            List<PineriverUser> nonMembers = new List<PineriverUser>();
            foreach (PineriverUser user in _userManager.Users)
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            RoleEdit = new RoleEdit
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
        }

        public async Task<IActionResult> OnPost()
        {
            IdentityResult result;
            if (ModelState.IsValid)
            {
                foreach (string userId in RoleModification.AddIds ?? new string[] { })
                {
                    PineriverUser user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await _userManager.AddToRoleAsync(user, RoleModification.RoleName);
                        if (!result.Succeeded)
                            Errors(result);
                    }
                }
                foreach (string userId in RoleModification.DeleteIds ?? new string[] { })
                {
                    PineriverUser user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await _userManager.RemoveFromRoleAsync(user, RoleModification.RoleName);
                        if (!result.Succeeded)
                            Errors(result);
                    }
                }
            }

            if (ModelState.IsValid)
                return RedirectToPage(nameof(PineriverUser));
            else
                return Page();
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}