using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.DTO;
using ToDoApp.Domain.Entities;
using ToDoApp.EntityFramework;
using static ToDoApp.Application.UseCases.Registrations.GetRegistrationsForTimePeriod;

namespace ToDoApp.Application.UseCases.Registrations
{
    public class GetRegistrationsForTimePeriod : IUseCase<GetRegistrationsForTimePeriodInput, List<WorkItemRegistrationDTO>>
    {
        private readonly DataContext _dataContext;
        private readonly IMapper<WorkItemRegistrationEntity, WorkItemRegistrationDTO> _mapper;

        public GetRegistrationsForTimePeriod(DataContext dataContext, IMapper<WorkItemRegistrationEntity, WorkItemRegistrationDTO> mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<List<WorkItemRegistrationDTO>> ExecuteAsync(GetRegistrationsForTimePeriodInput input)
        {
            return await _dataContext.WorkItemsRegistrations
                .Where(BetweenInputDate(input))
                .Select(x => _mapper.FromEntity(x))
                .ToListAsync();
        }

        private static Expression<Func<WorkItemRegistrationEntity, bool>> BetweenInputDate(GetRegistrationsForTimePeriodInput input)
        {
            return x => x.RegistrationDate >= input.Start && x.RegistrationDate <= input.End;
        }

        public record GetRegistrationsForTimePeriodInput(DateOnly Start, DateOnly End);
    }
}