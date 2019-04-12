using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PineriverData.Entities;
using Services.PostService;
using Services.PostService.DTO;

namespace PineriverASPNETPage.Pages
{
    public class IndexModel : PageModel
    {

        private IPostService _postServ { get; set; }

        public IndexModel(IPostService postServ)
        {
            _postServ = postServ;
        }

        public IQueryable<PostDTO> Posts { get; set; }

        public void OnGet()
        {
            Posts = _postServ.GetAll();
        }
    }
}