using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EntityModel
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int CateId { get; set; }
        public Category Category { get; set; }
        public DateTime Created { get; set; }
        public List<GameAccount> Accounts { get; set; }
    }
}
