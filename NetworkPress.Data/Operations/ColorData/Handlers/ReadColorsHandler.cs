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
    public class ReadColorsHandler : IRequestHandler<ReadColorsQuery, IEnumerable<Color>>
    {

        private readonly AppDbContext _db;

        public ReadColorsHandler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Color>> Handle(ReadColorsQuery request, CancellationToken cancellationToken)
        {
            return await _db.Colors.ToListAsync();
        }
    }
}
