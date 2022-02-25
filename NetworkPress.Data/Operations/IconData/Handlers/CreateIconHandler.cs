using MediatR;
using NetworkPress.Data.DataAccess;
using NetworkPress.Data.Operations.IconData.Commands;
using NetworkPress.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.IconData.Handlers
{
    public class CreateIconHandler : IRequestHandler<CreateIconCommand, Icon>
    {


        private readonly AppDbContext _db;

        public CreateIconHandler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Icon> Handle(CreateIconCommand request, CancellationToken cancellationToken)
        {
            var color = new Icon(request.IconModel);
            await _db.Icons.AddAsync(color);
            await _db.SaveChangesAsync();
            return color;
        }
    }
}
