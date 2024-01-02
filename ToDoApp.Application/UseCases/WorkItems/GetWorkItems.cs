using Microsoft.EntityFrameworkCore;
using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.DTO;
using ToDoApp.Domain.Entities;
using ToDoApp.EntityFramework;

namespace ToDoApp.Application.UseCases.WorkItems
{
    public class GetWorkItems : IUseCase<List<WorkItemDTO>>
    {
        private readonly DataContext _dataContext;
        private readonly IMapper<WorkItemEntity, WorkItemDTO> _workItemMapper;

        public GetWorkItems(DataContext dataContext, IMapper<WorkItemEntity, WorkItemDTO> workItemMapper)
        {
            _dataContext = dataContext;
            _workItemMapper = workItemMapper;
        }

        public async Task<List<WorkItemDTO>> ExecuteAsync()
        {
            return await _dataContext.WorkItems
                .Select(t => _workItemMapper.FromEntity(t))
                .ToListAsync();
        }
    }
}