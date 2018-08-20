using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChickenCoop3.Models
{
    public class ChickenBreed
    {
        public byte Id { get; set; }

        [Display(Name = "Breed")]
        public string Name { get; set; }
    }
}