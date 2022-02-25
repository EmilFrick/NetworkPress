using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetworkPress.Data.Operations.IconData.Commands;
using NetworkPress.Data.Operations.IconData.Queries;
using NetworkPress.Models.Models.IconModels;

namespace NetworkPress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IconsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public IconsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetIcons() => Ok(await _mediator.Send(new ReadIconsQuery()));
        
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetIcons(int id) => Ok(await _mediator.Send(new ReadIconQuery(x=>x.Id== id)));

        [HttpPost]
        public async Task<IActionResult> CreateIcon(IconCreateModel color) => Ok(await _mediator.Send(new CreateIconCommand(color)));

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteIcon(int id) => Ok(await _mediator.Send(new DeleteIconCommand(id)));

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateIcon(int id, IconUpdateModel model) => Ok(await _mediator.Send(new UpdateIconCommand(id, model)));
    }
}
