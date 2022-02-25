using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Models.Models.IconModels
{
    public class IconUpdateModel
    {

        public int Id { get; set; }
        public string IconValue { get; set; }
        public string Binding { get; set; }
    }
}
