using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.DTO;
using ToDoApp.Domain.Entities;
using ToDoApp.EntityFramework;

namespace ToDoApp.Application.UseCases.WorkItems
{
    public class AddWorkItem : IUseCase<WorkItemDTO, bool>
    {
        private readonly DataContext _dataContext;
        private readonly IMapper<WorkItemEntity, WorkItemDTO> _workItemMapper;

        public AddWorkItem(DataContext dataContext, IMapper<WorkItemEntity, WorkItemDTO> workItemMapper)
        {
            _dataContext = dataContext;
            _workItemMapper = workItemMapper;
        }

        public async Task<bool> ExecuteAsync(WorkItemDTO input)
        {
            try
            {
                _dataContext.Update(_workItemMapper.FromDTO(input));
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
                return false;
            }
        }
    }
}