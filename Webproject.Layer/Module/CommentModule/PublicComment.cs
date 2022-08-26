using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Layer.Module.CommentModule
{
    internal class PublicComment : IPublicComment
    {
        public Task<int> Create(CommentCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int commentId, CommentUpdateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<CommentViewModel>> ViewComment(CommentViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
