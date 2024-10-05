using AgroSmart.Core.Application.Dtos.API.Post;
using AgroSmart.Core.Application.Dtos.API.Topic;
using AgroSmart.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgroSmart.WebApi.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class ForumController : ControllerBase
    {
        private readonly IForumService _forumService;

        public ForumController(IForumService forumService)
        {
            _forumService = forumService;
        }        

        [HttpGet("topics")]
        public async Task<IActionResult> GetAllTopics()
        {
            var topics = await _forumService.GetAllTopicsAsync();
            return Ok(topics);
        }

        [HttpGet("topics/{id}")]
        public async Task<IActionResult> GetTopicById(int id)
        {
            var topic = await _forumService.GetTopicByIdAsync(id);
            return Ok(topic);
        }

        [HttpPost("topics")]
        public async Task<IActionResult> CreateTopic([FromBody] SaveTopicDto model)
        {
            await _forumService.CreateTopicAsync(model);
            return CreatedAtAction(nameof(GetTopicById), new { id = model.Id }, model);
        }

        [HttpPost("topics/{id}/posts")]
        public async Task<IActionResult> AddPostToTopic(int id, [FromBody] SavePostDto model)
        {
            await _forumService.AddPostToTopicAsync(model);
            return Ok();
        }
    }
}
