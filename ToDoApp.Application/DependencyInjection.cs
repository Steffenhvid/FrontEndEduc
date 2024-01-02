using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Application.Interfaces;
using ToDoApp.Application.Mappers;
using ToDoApp.Application.UseCases.Registrations;
using ToDoApp.Application.UseCases.WorkItems;
using ToDoApp.Domain.DTO;
using ToDoApp.Domain.Entities;
using static ToDoApp.Application.UseCases.Registrations.GetRegistrationsForTimePeriod;

namespace ToDoApp.Application
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
                .AddTransient<IUseCase<List<WorkItemDTO>>, GetWorkItems>()
                .AddTransient<IUseCase<GetRegistrationsForTimePeriodInput, List<WorkItemRegistrationDTO>>, GetRegistrationsForTimePeriod>();
        }

        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            return services
                .AddSingleton<IMapper<WorkItemEntity, WorkItemDTO>, WorkItemMapper>()
                .AddSingleton<IMapper<WorkItemRegistrationEntity, WorkItemRegistrationDTO>, WorkItemRegistrationMapper>();
        }
    }
}