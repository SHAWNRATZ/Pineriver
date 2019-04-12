using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PineriverASPNETPage.Models;

namespace PineriverASPNETPage.Pages.Identity
{
    public class LoginModel : PageModel
    {
        #region DI
        private readonly UserManager<PineriverUser> userManager;
        private readonly SignInManager<PineriverUser> signInManager;

        public LoginModel(UserManager<PineriverUser> userMgr, SignInManager<PineriverUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }
        #endregion

        [BindProperty]
        public InputModel Input { get; set; }

        #region INPUT MODEL
        public class InputModel
        {
            [Required]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
        #endregion

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                PineriverUser appUser = await userManager.FindByEmailAsync(Input.Email);
                if (appUser != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, Input.Password, false, false);
                    if (result.Succeeded)
                        return Redirect(ReturnUrl ?? "/");
                }
                ModelState.AddModelError(nameof(Input.Email), "Login Failed: Invalid Email or password");
            }
            return Page();
        }
    }
}