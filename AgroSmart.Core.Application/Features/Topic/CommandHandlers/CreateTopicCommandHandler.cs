
using AgroSmart.Core.Application.Dtos.Accounts;
using AgroSmart.Core.Application.Features.Topic.Commands;
using AgroSmart.Core.Application.Helpers;
using AgroSmart.Core.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace AgroSmart.Core.Application.Features.Topic.CommandHandlers
{
    public class CreateTopicCommandHandler
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IMapper _mapper;
        private readonly AuthenticationResponse? _user;

        public CreateTopicCommandHandler(ITopicRepository topicRepository, IMapper mapper, IHttpContextAccessor contextAccessor)
        {
            _topicRepository = topicRepository;
            _mapper = mapper;
            _user = contextAccessor.HttpContext.Session.Get<AuthenticationResponse>("client");
        }

        public async Task Handle(CreateTopicCommand command)
        {
            if (_user != null)
            {
                var topic = _mapper.Map<AgroSmart.Core.Domain.Entities.Topic>(command.Model);
                topic.UserId = _user.Id;  // Assign the authenticated user ID
                await _topicRepository.AddAsync(topic);
            }
        }
    }
}
