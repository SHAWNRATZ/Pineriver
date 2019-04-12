using PineriverData.Entities;
using Services.PostService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PostService
{
    public interface IPostService
    {
        OperationStatus AddNew(Post post);
        OperationStatus Remove(int id);
        OperationStatus Update(Post post);
        IQueryable<PostDTO> GetAll();
    }
}
