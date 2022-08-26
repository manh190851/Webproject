using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Layer.Module.ReplyModule
{
    internal class PublicReply : IPublicReply
    {
        public Task<int> Create(ReplyCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int replyid, ReplyUpdateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<ReplyViewModel>> ViewPost(ReplyViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
