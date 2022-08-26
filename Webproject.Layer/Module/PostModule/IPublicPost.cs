using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.EntityModel;

namespace Webproject.Layer.Module.PostModule
{
    public interface IPublicPost
    {
        Task<int> Create(PostCreateModel model);

        Task<int> Update(int postid, PostUpdateModel model);

        Task<int> Delete(int postId);

        Task<List<PostViewModel>> ViewPost();
    }
}
