using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.Enum;

namespace Webproject.Data.EntityModel
{
    public class Friend
    {
        public long FriendId { get; set; }
        public Guid RequestId { get; set; }
        public AppUser RequestUser { get; set; }
        public Guid AcceptId { get; set; }
        public AppUser AcceptUser { get; set; }
        public FriendStatus Status { get; set; }
        public DateTime Created { get; set; }
    }
}
