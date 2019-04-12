using PineriverData;
using PineriverData.Entities;
using Services.PostService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PostService
{
    public class PostService : IPostService
    {

        private PineriverContext _context { get; set; }

        public PostService(PineriverContext context)
        {
            _context = context;
        }

        public OperationStatus AddNew(Post post)
        {
            OperationStatus status = new OperationStatus
            {
                Operation = Operation.Create
            };

            try
            {
                post.User_ID = "asdasd";
                post.Post_Created = DateTime.Now;
                post.Post_Downvotes = 0;
                post.Post_Upvotes = 0;
                _context.posts.Add(post);
                _context.SaveChanges();
                status.Status = Status.Success;
            }
            catch (Exception ex)
            {
                status.Status = Status.Error;
                status.ErrorMessage = "Something went wrong when trying to add new post";
            }

            return status;
        }

        public IQueryable<PostDTO> GetAll()
        {
            return (from t in _context.posts select new PostDTO {
                User = t.User_ID,
                Added = t.Post_Created,
                DownVotes = t.Post_Downvotes,
                UpVotes = t.Post_Upvotes,
                Message = t.Post_Message,
                Subject = t.Post_Subject
            });
        }

        public OperationStatus Remove(int id)
        {
            throw new NotImplementedException();
        }

        public OperationStatus Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
