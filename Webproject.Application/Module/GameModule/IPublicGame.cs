using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Application.Module.Dtos;
using Webproject.Application.Module.Game.GameModel;

namespace Webproject.Application.Module.Game
{
    public interface IPublicGame
    {
        Task<PageViewModel<GameViewModel>> GetAllByCategoryId(int CateId, PageModel pageModel);
    }
}
