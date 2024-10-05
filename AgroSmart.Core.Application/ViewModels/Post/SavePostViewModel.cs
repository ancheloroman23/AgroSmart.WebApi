namespace AgroSmart.Core.Application.ViewModels.Post
{
    public class SavePostViewModel
    {
        public string Content { get; set; }
        public int TopicId { get; set; }  // El ID del topic al que se está añadiendo el post
    }
}
