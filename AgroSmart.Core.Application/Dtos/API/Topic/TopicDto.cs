using AgroSmart.Core.Application.Dtos.API.Post;

namespace AgroSmart.Core.Application.Dtos.API.Topic
{
    public class TopicDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }  // ID del usuario que creó el topic
        public string UserName { get; set; }  // Nombre del usuario que creó el topic (opcional)
        public List<PostDto> Posts { get; set; }
    }
}
