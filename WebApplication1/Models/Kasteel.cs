﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Kasteel
    {
        public int Id { get; set; }
        //[Required]
        public string? Name { get; set; }
    }
}
