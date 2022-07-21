using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.Enum;

namespace Webproject.Data.EntityModel
{
    public class Reaction
    {
        public long ReacId { get; set; }
        public ReactionEnum ReacName { get; set; }
        public DateTime Created { get; set; }
        public long PostId { get; set; }
        public Post Post { get; set; }
        public long ComId { get; set; }
        public Comment Comment { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }
        public long ReplyId { get; set; }
        public Reply Reply { get; set; }
    }
}
