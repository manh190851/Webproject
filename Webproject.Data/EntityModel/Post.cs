using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.Enum;

namespace Webproject.Data.EntityModel
{
    public class Post
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
        public PostStatus Status { get; set; }
        public bool IsDeleted { get; set; }
        public long ShareCount { get; set; }
        public List<Share> Shares { get; set; }
        public List<Reaction>? Reactions { get; set; }
        public List<Comment>? Comments { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
