using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EntityModel
{
    public class Friend
    {
        public long FriendId { get; set; }
        public AppUser FriendWith { get; set; }
        public long UserId { get; set; }
        public AppUser User { get; set; }
    }
}
