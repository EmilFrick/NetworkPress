using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Models.Entities
{
    public interface IComponent
    {
        int Id { get; set; }
        string Name { get; set; }
        string Value { get; set; }
    }
}
