using MediatR;
using Microsoft.EntityFrameworkCore;
using NetworkPress.Data.DataAccess;
using NetworkPress.Data.Operations.IconData.Queries;
using NetworkPress.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.IconData.Handlers
{
    public class ReadIconsHandler : IRequestHandler<ReadIconsQuery, IEnumerable<Icon>>
    {

        private readonly AppDbContext _db;

        public ReadIconsHandler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Icon>> Handle(ReadIconsQuery request, CancellationToken cancellationToken)
        {
            return await _db.Icons.ToListAsync();
        }
    }
}
