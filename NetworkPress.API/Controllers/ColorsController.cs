using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetworkPress.Data.Operations.ColorData.Commands;
using NetworkPress.Data.Operations.ColorData.Queries;
using NetworkPress.Models.Models.ColorModels;

namespace NetworkPress.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ColorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetColors() => Ok(await _mediator.Send(new ReadColorsQuery()));
        
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetColors(int id) => Ok(await _mediator.Send(new ReadColorQuery(x=>x.Id== id)));

        [HttpPost]
        public async Task<IActionResult> CreateColor(ColorCreateModel color) => Ok(await _mediator.Send(new CreateColorCommand(color)));

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteColor(int id) => Ok(await _mediator.Send(new DeleteColorCommand(id)));

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateColor(int id, ColorUpdateModel model) => Ok(await _mediator.Send(new UpdateColorCommand(id, model)));
    }
}
