using MediatR;
using Microsoft.EntityFrameworkCore;
using NetworkPress.Data.DataAccess;
using NetworkPress.Data.Operations.IconData.Commands;
using NetworkPress.Models.Entities;
using NetworkPress.Models.Models.IconModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.IconData.Handlers
{
    public class UpdateIconHandler : IRequestHandler<UpdateIconCommand, Icon>
    {

        private readonly AppDbContext _db;

        public UpdateIconHandler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Icon> Handle(UpdateIconCommand request, CancellationToken cancellationToken)
        {
            if(request.Id != request.Model.Id)
                return null;

            var color = await _db.Icons.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (color == null)
                return null;

            color = color.UpdateIcon(request.Model);
            _db.Icons.Update(color);
            await _db.SaveChangesAsync();
            return color;
        }
    }
}
