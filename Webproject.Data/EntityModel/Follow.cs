using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EntityModel
{
    public class Follow
    {
        public long FollowId { get; set; }
        public Guid FollowerId { get; set; }
        public AppUser Follower { get; set; }
        public Guid FollowingId { get; set; }
        public AppUser Following { get; set; }
        public DateTime Created { get; set; }
    }
}
