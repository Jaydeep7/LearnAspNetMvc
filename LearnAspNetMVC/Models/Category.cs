using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LearnAspNetMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(maximumLength:50)]
        public string Name { get; set; }
    }
}