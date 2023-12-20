using FrontEndEduc.Application.Interfaces;
using FrontEndEduc.Domain.DTO;
using FrontEndEduc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndEduc.Application.Mappers
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