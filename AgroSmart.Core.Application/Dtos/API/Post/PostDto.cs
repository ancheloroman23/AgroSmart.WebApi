

namespace AgroSmart.Core.Application.Dtos.API.Post
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }  // ID del usuario que hizo el post
        public string UserName { get; set; }  // Nombre del usuario que hizo el post (opcional)
        public int TopicId { get; set; }
    }
}
