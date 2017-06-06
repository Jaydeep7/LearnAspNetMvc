using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LearnAspNetMVC.Models;

namespace LearnAspNetMVC.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(1, double.MaxValue)]
        public double Price { get; set; }

        [Range(0, double.MaxValue)]
        public double Stock { get; set; }

        public Category Category { get; set; }

        [StringLength(maximumLength:100)]
        public string ImagePath { get; set; }
        
    }
}