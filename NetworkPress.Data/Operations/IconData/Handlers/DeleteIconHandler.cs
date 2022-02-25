using MediatR;
using NetworkPress.Data.DataAccess;
using NetworkPress.Data.Operations.IconData.Commands;
using NetworkPress.Data.Operations.IconData.Queries;
using NetworkPress.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.IconData.Handlers
{
    public class DeleteIconHandler : IRequestHandler<DeleteIconCommand, Icon>
    {

        private readonly AppDbContext _db;

        private readonly IMediator _mediator;

        public DeleteIconHandler(AppDbContext db, IMediator mediator)
        {
            _db = db;
            _mediator = mediator;
        }

        public async Task<Icon> Handle(DeleteIconCommand request, CancellationToken cancellationToken)
        {
            var color = await _mediator.Send(new ReadIconQuery(x=>x.Id == request.Id));
            _db.Remove(color);
            await _db.SaveChangesAsync();
            return color;
        }
    }
}
