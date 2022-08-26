using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Application.Module.Dtos;
using Webproject.Application.Module.Post;
using Webproject.Application.Module.Post.PostModel;
using Webproject.Data.EF;

namespace Webproject.Application.Module.Posts
{
    internal class PublicPost : IPublicPost
    {
        private WebprojectDbContext db;

        public PublicPost(WebprojectDbContext context)
        {
            this.db = context;  
        }

        public async Task<int> Create(PostCreateRequest request)
        {
            var posts = new Post()
            {
                
            };
        }

        public Task<int> Delete(int AccId)
        {
            throw new NotImplementedException();
        }

        public Task<PageViewModel<PostViewModel>> GetAllPage(Guid userid)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(PostEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
