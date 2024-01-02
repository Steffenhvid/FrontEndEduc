using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.DTO;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Mappers
{
    public class WorkItemMapper : IMapper<WorkItemEntity, WorkItemDTO>
    {
        public WorkItemEntity FromDTO(WorkItemDTO dto)
        {
            return new WorkItemEntity
            {
                Id = dto.Id,
                Title = dto.Title,
                State = dto.State
            };
        }

        public WorkItemDTO FromEntity(WorkItemEntity entity)
        {
            return new WorkItemDTO
            {
                Id = entity.Id,
                Title = entity.Title,
                State = entity.State
            };
        }
    }
}