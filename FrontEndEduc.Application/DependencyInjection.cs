using FrontEndEduc.Application.Interfaces;
using FrontEndEduc.Application.Mappers;
using FrontEndEduc.Application.UseCases.WorkItems;
using FrontEndEduc.Domain.DTO;
using FrontEndEduc.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace FrontEndEduc.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services
                .AddUseCases()
                .AddMappers();
        }

        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            return services
                .AddTransient<IUseCase<WorkItemDTO, bool>, AddWorkItem>()
                .AddTransient<IUseCase<List<WorkItemDTO>>, GetWorkItems>();
        }

        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            return services
                .AddSingleton<IMapper<WorkItemEntity, WorkItemDTO>, WorkItemMapper>();
        }
    }
}