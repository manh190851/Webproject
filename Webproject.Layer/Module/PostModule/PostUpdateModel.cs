using Webproject.Data.Enum;

namespace Webproject.Layer.Module.PostModule
{
    public class PostUpdateModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
        public PostStatus PostStatus { get; set; }
        public bool IsDeleted { get; set; }
    }
}