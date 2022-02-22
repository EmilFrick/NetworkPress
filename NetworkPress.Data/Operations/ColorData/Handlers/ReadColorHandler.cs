using MediatR;
using Microsoft.EntityFrameworkCore;
using NetworkPress.Data.DataAccess;
using NetworkPress.Data.Operations.ColorData.Queries;
using NetworkPress.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.ColorData.Handlers
{
    public class ReadColorHandler : IRequestHandler<ReadColorQuery, IEnumerable<Color>>
    {

        private readonly AppDbContext _db;

        public ReadColorHandler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Color>> Handle(ReadColorQuery request, CancellationToken cancellationToken)
        {
            return await _db.Colors.ToListAsync();
        }
    }
}
