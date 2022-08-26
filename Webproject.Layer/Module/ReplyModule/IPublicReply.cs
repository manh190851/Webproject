using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Layer.Module.ReplyModule
{
    public interface IPublicReply
    {
        Task<int> Create(ReplyCreateModel model);

        Task<int> Update(int replyid, ReplyUpdateModel model);

        Task<int> Delete(int postId);

        Task<List<ReplyViewModel>> ViewPost(ReplyViewModel model);
    }
}
