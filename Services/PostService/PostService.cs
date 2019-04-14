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
                _context.Posts.Add(post);
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
            return (from t in _context.Posts select new PostDTO {
                ID = t.Post_ID,
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
            OperationStatus status = new OperationStatus
            {
                Operation = Operation.Update
            };

            try
            {
                foreach (var item in _context.Posts)
                {
                    if (item.Post_ID == post.Post_ID)
                    {
                        item.Post_Message = post.Post_Message;
                        item.Post_Subject = post.Post_Subject;
                        item.Post_Upvotes = post.Post_Upvotes;
                        item.Post_Downvotes = post.Post_Downvotes;
                    }
                }
                _context.SaveChanges();
                status.Status = Status.Success;
            }
            catch (Exception ex)
            {
                status.Status = Status.Failed;
                status.ErrorMessage = "Could not update the selected item";
            }

            return status;
        }

        public Post Get(int id)
        {
            return _context.Posts.Where(p => p.Post_ID == id).FirstOrDefault();
        }
    }
}
