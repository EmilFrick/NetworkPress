using MediatR;
using Microsoft.EntityFrameworkCore;
using NetworkPress.Data.DataAccess;
using NetworkPress.Data.Operations.ColorData.Commands;
using NetworkPress.Models.Entities;
using NetworkPress.Models.Models.ColorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.ColorData.Handlers
{
    public class UpdateColorHandler : IRequestHandler<UpdateColorCommand, Color>
    {

        private readonly AppDbContext _db;

        public UpdateColorHandler(AppDbContext db)
        {
            _db = db;
        }

        public async Task<Color> Handle(UpdateColorCommand request, CancellationToken cancellationToken)
        {
            if(request.Id != request.Model.Id)
                return null;

            var color = await _db.Colors.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (color == null)
                return null;

            color = color.UpdateColor(request.Model);
            _db.Colors.Update(color);
            await _db.SaveChangesAsync();
            return color;
        }
    }
}
