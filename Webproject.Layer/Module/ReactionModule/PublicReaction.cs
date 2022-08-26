using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Layer.Module.ReactionModule
{
    public class PublicReaction : IPublicReaction
    {
        public Task<int> Create(ReactionCreateModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int reactionId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ReactionViewModel>> ViewReaction(ReactionViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
