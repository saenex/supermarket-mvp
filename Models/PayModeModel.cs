﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    class PayModeModel
    {
        [DisplayName("Play Mode Id")]
        public int Id { get; set; }

        [DisplayName("Play Mode Name")]
        [Required(ErrorMessage = "Please enter a name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Play mode name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Play mode observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]
        public string Observation{ get; set; }

    }
}
