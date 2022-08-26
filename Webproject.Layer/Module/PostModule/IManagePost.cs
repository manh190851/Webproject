using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Layer.Module.PostModule
{
    public interface IManagePost
    {
        Task<bool> Block(int postId);
    }
}
