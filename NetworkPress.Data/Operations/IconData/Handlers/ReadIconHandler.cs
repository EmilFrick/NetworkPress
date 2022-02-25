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
    public class ReadIconHandler : IRequestHandler<ReadIconQuery, Icon>
    {

        private readonly AppDbContext _db;

        public ReadIconHandler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Icon> Handle(ReadIconQuery request, CancellationToken cancellationToken) => await _db.Icons.FirstOrDefaultAsync(request.Filter);
        
    }
}
