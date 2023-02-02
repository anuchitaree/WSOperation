﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOperation.Models
{
    public class WorkingStandard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }


        [Required, StringLength(20)]
        public string Partnumber { get; set; } = null!;

        [Required, StringLength(255)]
        public string Destination { get; set; } = null!;

    }
}
