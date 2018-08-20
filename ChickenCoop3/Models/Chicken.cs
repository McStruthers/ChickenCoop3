using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChickenCoop3.Models
{
    public class Chicken
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsAdoptable { get; set; }
        public int? OwnerId { get; set; }
        public ChickenBreed ChickenBreed { get; set; }
        public byte ChickenBreedId { get; set; }

    }
}