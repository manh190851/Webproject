using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Layer.Module.CommentModule
{
    public interface IPublicComment
    {
        Task<int> Create(CommentCreateModel model);

        Task<int> Update(int commentId, CommentUpdateModel model);

        Task<int> Delete(int commentId);

        Task<List<CommentViewModel>> ViewComment(CommentViewModel model);
    }
}
