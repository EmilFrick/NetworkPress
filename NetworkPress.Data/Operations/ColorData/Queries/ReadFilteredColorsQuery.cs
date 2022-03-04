using MediatR;
using NetworkPress.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Data.Operations.ColorData.Queries
{
    public record ReadFilteredColorsQuery(Expression<Func<Color, bool>> Filter): IRequest<IEnumerable<Color>>;
}
