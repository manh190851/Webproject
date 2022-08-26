using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Application.Module.Dtos;
using Webproject.Application.Module.Game.GameModel;
using Webproject.Data.EF;

namespace Webproject.Application.Module.Game
{
    public class ManageGame : IManageGame
    {
        private WebprojectDbContext db;

        public ManageGame(WebprojectDbContext context)
        {
            this.db = context;
        }

        public Task<int> Create(GameCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int GameId)
        {
            throw new NotImplementedException();
        }

        public Task<List<GameViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PageViewModel<GameViewModel>> GetAllPage(PageModel pageModel)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int GameId, GameEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
