using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EntityModel
{
    public class GameAccount
    {
        public long AccId { get; set; }
        public string _Account { get; set; }
        public string _Password { get; set; }
        public List<AccountImage> Images { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public Guid SalerId { get; set; }
        public AppUser Saler { get; set; }
    }
}
