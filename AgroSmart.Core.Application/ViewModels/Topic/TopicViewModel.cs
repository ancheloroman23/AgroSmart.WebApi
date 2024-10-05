using AgroSmart.Core.Application.ViewModels.Post;

namespace AgroSmart.Core.Application.ViewModels.Topic
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        public List<PostViewModel> Posts { get; set; }
    }
}
