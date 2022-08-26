using Webproject.Data.Enum;

namespace Webproject.Application.Module.Post.PostModel
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