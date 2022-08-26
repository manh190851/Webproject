using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Layer.Module.ShareModule
{
    public interface IPublicShare
    {
        Task<int> Create(ShareCreateModel model);

        Task<int> Update(int shareId, ShareUpdateModel model);

        Task<int> Delete(int shareId);

        Task<List<ShareViewModel>> ViewComment(ShareViewModel model);
    }
}
