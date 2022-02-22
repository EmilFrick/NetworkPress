using MediatR;
using NetworkPress.Data.DataAccess;
using NetworkPress.Data.Operations.ColorData.Commands;
using NetworkPress.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.ColorData.Handlers
{
    public class CreateColorHandler : IRequestHandler<CreateColorCommand, Color>
    {


        private readonly AppDbContext _db;

        public CreateColorHandler(AppDbContext db)
        {
            _db = db;
        }

        public Task<Color> Handle(CreateColorCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
