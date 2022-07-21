using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.EntityModel
{
    public class Share
    {
        public long ShareId { get; set; }
        public Guid UserId { get; set; }
        public AppUser Users { get; set; }
        public long PostId { get; set; }
        public Post Post { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
    }
}
