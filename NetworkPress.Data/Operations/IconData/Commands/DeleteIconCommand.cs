using MediatR;
using NetworkPress.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.IconData.Commands
{
    public record DeleteIconCommand(int Id) : IRequest<Icon>;
}
