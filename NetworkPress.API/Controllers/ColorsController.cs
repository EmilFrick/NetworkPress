using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetworkPress.Data.Operations.ColorData.Queries;

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
        public async Task<IActionResult> GetColors() => Ok(await _mediator.Send(new ReadColorQuery()));            
    }
}
