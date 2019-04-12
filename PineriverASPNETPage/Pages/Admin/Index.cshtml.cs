using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PineriverASPNETPage.Models;
using PineriverData.Entities;
using Services;
using Services.PostService;
using Services.PostService.DTO;

namespace PineriverASPNETPage.Pages.Admin
{
    //[Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
     
        private IPostService _postServ { get; set; }
        public IndexModel(IPostService postServ)
        {
            _postServ = postServ;
        }


        #region Properties
        [BindProperty]
        public Post PostData { get; set; }
        #endregion

        public void OnGet()
        {
            
        }

        public void OnPostNewPost()
        {
            OperationStatus stat = _postServ.AddNew(PostData);
        }
    }
}