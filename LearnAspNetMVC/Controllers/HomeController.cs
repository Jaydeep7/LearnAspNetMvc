﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnAspNetMVC.Models;
using LearnAspNetMVC.ViewModel;

namespace LearnAspNetMVC.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext db;

        public HomeController()
        {
            db = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        //public ActionResult Products(List<Category> categories, List<string> itemIds)
        public ActionResult Products()
        {
            ViewBag.Message = "...Products...";

            ProductsVM productsVm = new ProductsVM();
            productsVm.items = db.Items.ToList();
            productsVm.categories = db.Categories.ToList();
            return View(productsVm);
        }

        //[HttpPost]
        //public ActionResult Products(List<Category> categories, List<string> itemIds)
        //{
        //    return View(model);
        //}

        [HttpPost]
        public ActionResult Filter(ProductsVM productsVm)
        {
            try
            {
                productsVm.categories.RemoveAll(x => x.isSelected == false);
                var ids = productsVm.categories.Select(c => c.Id);

                var model = db.Items.Where(x => ids.Contains(x.Category.Id)).ToList();

                return PartialView("DisplayItem", model);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public ActionResult Category()
        {
            ViewBag.Message = "...Categories...";
            return View(db.Categories.ToList());
        }

        [HttpPost]
        public ActionResult Category(List<Category> model)
        {
            ViewBag.Message = "...Categories...";



            return View(model);
        }

        public PartialViewResult TestPartial()
        {
            ViewBag.msg = "This is from ViewBag.msg";
            return PartialView();
        }

    }
}