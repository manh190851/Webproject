using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Application.Module.Dtos;
using Webproject.Application.Module.Post.PostModel;

namespace Webproject.Application.Module.Post
{
    public interface IPublicPost
    {
        Task<int> Create(PostCreateRequest request);

        Task<int> Update(PostEditRequest request);

        Task<int> Delete(int AccId);

        Task<PageViewModel<PostViewModel>> GetAllPage(Guid userid);
    }
}
