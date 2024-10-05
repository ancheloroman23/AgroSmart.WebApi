using AgroSmart.Core.Application.Facade;
using AgroSmart.Core.Application.Features.Post.CommandHandlers;
using AgroSmart.Core.Application.Features.Topic.CommandHandlers;
using AgroSmart.Core.Application.Features.Topic.QueryHandlers;
using AgroSmart.Core.Application.Interfaces.Services;
using AgroSmart.Core.Application.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace AgroSmart.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            #region Services
            services.AddTransient(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IForumService, ForumService>();
            #endregion

            services.AddTransient<CreateTopicCommandHandler>();
            services.AddTransient<AddPostCommandHandler>();
            services.AddTransient<GetAllTopicsQueryHandler>();
            services.AddTransient<GetTopicByIdQueryHandler>();

            #region Facade
            services.AddScoped<FacadeForImages>();
            #endregion

        }
    }
}
