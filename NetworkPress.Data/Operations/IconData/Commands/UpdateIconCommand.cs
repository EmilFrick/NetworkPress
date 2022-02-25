using MediatR;
using NetworkPress.Models.Entities;
using NetworkPress.Models.Models.IconModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.IconData.Commands
{
    public record UpdateIconCommand(int Id, IconUpdateModel Model) : IRequest<Icon>;
}
