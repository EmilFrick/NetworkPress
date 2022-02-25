using MediatR;
using NetworkPress.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.IconData.Queries
{
    public record ReadIconQuery(Expression<Func<Icon, bool>> Filter): IRequest<Icon>;
}
