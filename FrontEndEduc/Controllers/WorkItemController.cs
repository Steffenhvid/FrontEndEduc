using FrontEndEduc.Application.Interfaces;
using FrontEndEduc.Domain.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndEduc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class WorkItemController : ControllerBase
    {
        private readonly IUseCase<List<WorkItemDTO>> _getWorkItems;
        private readonly IUseCase<WorkItemDTO, bool> _addWorkItem;

        public WorkItemController(
            IUseCase<List<WorkItemDTO>> getWorkItems,
            IUseCase<WorkItemDTO, bool> addWorkItem)
        {
            _getWorkItems = getWorkItems;
            _addWorkItem = addWorkItem;
        }

        [HttpGet("GetWorkItems")]
        [ProducesResponseType(typeof(WorkItemDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetWorkItems()
        {
            return Ok(await _getWorkItems.ExecuteAsync());
        }

        [HttpPut("UpSertWorkItem")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpSertWorkItem(WorkItemDTO workItem)
        {
            return Ok(await _addWorkItem.ExecuteAsync(workItem));
        }
    }
}