using Webproject.Data.Enum;

namespace Webproject.Application.Module.Post.PostModel
{
    public class PostEditRequest
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
        public PostStatus Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}