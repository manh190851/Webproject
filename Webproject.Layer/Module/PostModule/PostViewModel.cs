using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.EntityModel;
using Webproject.Data.Enum;

namespace Webproject.Layer.Module.PostModule
{
    public class PostViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
        public PostStatus Status { get; set; }
        public bool IsDeleted { get; set; }
        public long ShareCount { get; set; }
        public Guid UserId { get; set; }
    }
}
