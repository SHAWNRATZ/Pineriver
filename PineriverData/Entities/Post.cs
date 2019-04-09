using System;
using System.Collections.Generic;
using System.Text;

namespace PineriverData.Entities
{
    public class Post
    {
        public int Post_ID { get; set; }
        public DateTime Post_Created { get; set; }
        public int Post_Upvotes { get; set; }
        public int Post_Downvotes { get; set; }
        public string User_ID { get; set; }
        public string Post_Subject { get; set; }
        public string Post_Message { get; set; }


    }
}
