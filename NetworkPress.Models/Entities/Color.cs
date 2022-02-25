using NetworkPress.Models.Models.ColorModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Models.Entities
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Hex { get; set; }

        public Color()
        {

        }

        public Color(ColorCreateModel model)
        {
            Name = model.Name;
            Hex = model.Hex;
        }

        public Color UpdateColor(ColorUpdateModel model)
        {
            Id = model.Id;
            Name = model.Name;
            Hex = model.Hex;
            return this;
        }
    }
}
