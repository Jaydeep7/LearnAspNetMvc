using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnAspNetMVC.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //turn off identity
        public int Id { get; set; }

        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
    }
}