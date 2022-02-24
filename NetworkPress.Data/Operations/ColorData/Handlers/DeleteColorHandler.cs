using MediatR;
using NetworkPress.Data.DataAccess;
using NetworkPress.Data.Operations.ColorData.Commands;
using NetworkPress.Data.Operations.ColorData.Queries;
using NetworkPress.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.ColorData.Handlers
{
    public class DeleteColorHandler : IRequestHandler<DeleteColorCommand, Color>
    {

        private readonly AppDbContext _db;

        private readonly IMediator _mediator;

        public DeleteColorHandler(AppDbContext db, IMediator mediator)
        {
            _db = db;
            _mediator = mediator;
        }

        public async Task<Color> Handle(DeleteColorCommand request, CancellationToken cancellationToken)
        {
            var color = await _mediator.Send(new ReadColorQuery(request.Id));
            _db.Remove(color);
            await _db.SaveChangesAsync();
            return color;
        }
    }
}
