using FrontEndEduc.Application.Interfaces;
using FrontEndEduc.Domain.DTO;
using FrontEndEduc.Domain.Entities;
using FrontEndEduc.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndEduc.Application.UseCases.WorkItems
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