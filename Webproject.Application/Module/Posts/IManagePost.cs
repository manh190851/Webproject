using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Application.Module.Post
{
    public interface IManagePost
    {
        Task<int> Block(int postId);
    }
}
