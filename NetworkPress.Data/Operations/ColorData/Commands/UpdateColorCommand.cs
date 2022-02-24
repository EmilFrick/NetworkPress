using MediatR;
using NetworkPress.Models.Entities;
using NetworkPress.Models.Models.ColorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.ColorData.Commands
{
    public record UpdateColorCommand(int Id, UpdateColorModel Model) : IRequest<Color>;
}
