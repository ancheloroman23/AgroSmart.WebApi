using AgroSmart.Core.Domain.Entities;
using AgroSmart.Core.Application.Dtos.Accounts;
using AgroSmart.Core.Application.Helpers;
using AgroSmart.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using AgroSmart.Core.Application.Features.Post.Commands;

namespace AgroSmart.Core.Application.Features.Post.CommandHandlers
{
    public class AddPostCommandHandler
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        private readonly AuthenticationResponse? _user;

        public AddPostCommandHandler(IPostRepository postRepository, IMapper mapper, IHttpContextAccessor contextAccessor)
        {
            _postRepository = postRepository;
            _mapper = mapper;
            _user = contextAccessor.HttpContext.Session.Get<AuthenticationResponse>("client");
        }

        public async Task Handle(AddPostCommand command)
        {
            if (_user != null)
            {
                var post = _mapper.Map<AgroSmart.Core.Domain.Entities.Post>(command.Model);
                /*var post = _mapper.Map<Post>(command.Model);*/
                post.UserId = _user.Id;  // Assign the authenticated user ID
                await _postRepository.AddAsync(post);
            }
        }
    }
}
