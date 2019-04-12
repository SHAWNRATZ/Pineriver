using System;
using System.Collections.Generic;
using System.Text;

namespace Services.PostService.DTO
{
    public class PostDTO
    {
        public string User { get; set; }
        public DateTime Added { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int UpVotes { get; set; }
        public int DownVotes { get; set; }
    }
}
