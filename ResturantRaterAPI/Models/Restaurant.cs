﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResturantRaterAPI.Models
{
    public class Restaurant
    {
        [Key]
        public int Id  { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double Rating { get; set; }

        public bool IsRecomended => Rating > 3.5;
    }
}