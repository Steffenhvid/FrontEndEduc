using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Interfaces;
using ToDoApp.Domain.DTO;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Mappers
{
    public class WorkItemRegistrationMapper : IMapper<WorkItemRegistrationEntity, WorkItemRegistrationDTO>
    {
        public WorkItemRegistrationEntity FromDTO(WorkItemRegistrationDTO dto)
        {
            return new WorkItemRegistrationEntity()
            {
                Id = dto.Id,
                StartTime = dto.StartTime,
                EndTime = dto.EndTime,
                Description = dto.Description,
                RegistrationDate = dto.RegistrationDate,
                Task = dto.Task,
                UserStory = dto.UserStory,
            };
        }

        public WorkItemRegistrationDTO FromEntity(WorkItemRegistrationEntity entity)
        {
            return new WorkItemRegistrationDTO()
            {
                Id = entity.Id,
                StartTime = entity.StartTime,
                EndTime = entity.EndTime,
                Description = entity.Description,
                RegistrationDate = entity.RegistrationDate,
                Task = entity.Task,
                UserStory = entity.UserStory,
            };
        }
    }
}