using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChickenCoop3.Models;

namespace ChickenCoop3.ViewModels
{
    public class NewChickenViewModel
    {
        public IEnumerable<ChickenBreed> ChickenBreeds { get; set; }
        public Chicken Chicken { get; set; }
    }
}