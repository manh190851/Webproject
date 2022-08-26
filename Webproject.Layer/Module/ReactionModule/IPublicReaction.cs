using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Layer.Module.ReactionModule
{
    public interface IPublicReaction
    {
        Task<int> Create(ReactionCreateModel model);

        Task<int> Delete(int reactionId);

        Task<List<ReactionViewModel>> ViewReaction(ReactionViewModel model);
    }
}
