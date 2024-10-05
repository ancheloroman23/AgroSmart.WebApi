

namespace AgroSmart.Core.Application.Dtos.API.Post
{
    public class SavePostDto
    {
        public string Content { get; set; }
        public int TopicId { get; set; }  // El ID del Topic al que se está añadiendo el post
    }
}
