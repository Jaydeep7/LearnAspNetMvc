using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnAspNetMVC.Models;

namespace LearnAspNetMVC.ViewModel
{
    public class ProductsVM
    {
        public List<Item> items { get; set; }
        public List<Category> categories { get; set; }

    }
}