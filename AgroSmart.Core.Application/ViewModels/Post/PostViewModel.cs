

namespace AgroSmart.Core.Application.ViewModels.Post
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }  // El ID del usuario que hizo el post
        public string UserName { get; set; }  // El nombre del usuario que hizo el post (opcional)
        public int TopicId { get; set; }  // El ID del topic al que pertenece el post
    }
}
