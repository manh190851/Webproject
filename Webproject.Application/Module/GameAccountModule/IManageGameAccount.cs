using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Application.Module.Dtos;
using Webproject.Application.Module.GameAccount.GameAccountModel;

namespace Webproject.Application.Module.GameAccount
{
    public interface IManageGameAccount
    {
        Task<int> Create(GameAccountCreateRequest request);

        Task<int> Update(int AccId,GameAccountEditRequest request);

        Task<int> Delete(int AccId);

        Task<List<GameAccountViewModel>> GetAll();

        Task<PageViewModel<GameAccountViewModel>> GetAllPage(PageModel pageModel);
    }
}
