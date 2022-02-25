﻿using NetworkPress.Models.Models.IconModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkPress.Models.Entities
{
    public class Icon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string IconValue { get; set; }
        [Required]
        public string Binding { get; set; }

        public Icon()
        {

        }

        public Icon(IconCreateModel model)
        {
            IconValue = model.IconValue;
            Binding = model.Binding;
        }

        public Icon UpdateIcon(IconUpdateModel model)
        {
            Id = model.Id;
            IconValue = model.IconValue;
            Binding = model.Binding;
            return this;
        }
    }
}
