using FrontEndEduc.Application.Interfaces;
using FrontEndEduc.Domain.DTO;
using FrontEndEduc.Domain.Entities;
using FrontEndEduc.EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndEduc.Application.UseCases.WorkItems
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