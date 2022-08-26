using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Application.Module.Dtos;
using Webproject.Application.Module.GameAccount.GameAccountModel;

namespace Webproject.Application.Module.GameAccount
{
    public class ManageGameAccount : IManageGameAccount
    {
        public Task<int> Create(GameAccountCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int AccId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GameAccountViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PageViewModel<GameAccountViewModel>> GetAllPage(PageModel pageModel)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int AccId, GameAccountEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
