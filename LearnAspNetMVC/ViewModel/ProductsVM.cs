using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnAspNetMVC.Models;
using System.Web.Mvc;

namespace LearnAspNetMVC.ViewModel
{
    public class ProductsVM
    {
        public IList<Item> items { get; set; }
        public List<Category> categories { get; set; }

    }
}