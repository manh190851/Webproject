using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Application.Module.Dtos;
using Webproject.Application.Module.Game.GameModel;

namespace Webproject.Application.Module.Game
{
    public interface IManageGame
    {
        Task<int> Create(GameCreateRequest request);

        Task<int> Update(int GameId, GameEditRequest request);

        Task<int> Delete(int GameId);

        Task<List<GameViewModel>> GetAll();

        Task<PageViewModel<GameViewModel>> GetAllPage(PageModel pageModel);
    }
}
