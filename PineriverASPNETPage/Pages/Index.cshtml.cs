using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PineriverData.Entities;

namespace PineriverASPNETPage.Pages
{
    public class IndexModel : PageModel
    {
        public List<Post> Posts { get; set; } = new List<Post>();

        public void OnGet()
        {
            Posts.Add(new Post {
                Post_Created = DateTime.Now,
                Post_Downvotes = 0,
                Post_ID = 1,
                Post_Message = "Tran er en lækker asiat",
                Post_Subject = "BREAKING NEWS",
                Post_Upvotes = 10000,
                User_ID = "asd"
            });

            Posts.Add(new Post
            {
                Post_Created = DateTime.Now,
                Post_Downvotes = 0,
                Post_ID = 1,
                Post_Message = "Tran er en lækker asiat",
                Post_Subject = "BREAKING NEWS",
                Post_Upvotes = 10000,
                User_ID = "asd"
            });

            Posts.Add(new Post
            {
                Post_Created = DateTime.Now,
                Post_Downvotes = 0,
                Post_ID = 1,
                Post_Message = "Tran er en lækker asiat",
                Post_Subject = "BREAKING NEWS",
                Post_Upvotes = 10000,
                User_ID = "asd"
            });

            Posts.Add(new Post
            {
                Post_Created = DateTime.Now,
                Post_Downvotes = 0,
                Post_ID = 1,
                Post_Message = "Tran er en lækker asiat",
                Post_Subject = "BREAKING NEWS",
                Post_Upvotes = 10000,
                User_ID = "asd"
            });

            Posts.Add(new Post
            {
                Post_Created = DateTime.Now,
                Post_Downvotes = 0,
                Post_ID = 1,
                Post_Message = "Tran er en lækker asiat",
                Post_Subject = "BREAKING NEWS",
                Post_Upvotes = 10000,
                User_ID = "asd"
            });

            Posts.Add(new Post
            {
                Post_Created = DateTime.Now,
                Post_Downvotes = 0,
                Post_ID = 1,
                Post_Message = "Tran er en lækker asiat",
                Post_Subject = "BREAKING NEWS",
                Post_Upvotes = 10000,
                User_ID = "asd"
            });

            Posts.Add(new Post
            {
                Post_Created = DateTime.Now,
                Post_Downvotes = 0,
                Post_ID = 1,
                Post_Message = "Tran er en lækker asiat",
                Post_Subject = "BREAKING NEWS",
                Post_Upvotes = 10000,
                User_ID = "asd"
            });

            Posts.Add(new Post
            {
                Post_Created = DateTime.Now,
                Post_Downvotes = 0,
                Post_ID = 1,
                Post_Message = "Tran er en lækker asiat",
                Post_Subject = "BREAKING NEWS",
                Post_Upvotes = 10000,
                User_ID = "asd"
            });
        }
    }
}