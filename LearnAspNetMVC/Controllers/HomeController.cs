using System;
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
        public ActionResult Products()
        {
            ViewBag.Message = "...Products...";

            ProductsVM productsVm = new ProductsVM();
            productsVm.items = db.Items.ToList();
            productsVm.categories = db.Categories.ToList();
            return View(productsVm);
        }

        [HttpPost]
        public ActionResult Products(ProductsVM model)
        {
            ViewBag.Message = "...Categories...";

            List<Item> items = db.Items.ToList();

            return View(items);
        }

        public ActionResult Category()
        { 
            return View(db.Categories.ToList());
        }

        [HttpPost]
        public ActionResult Category(List<Category> model)
        {
            return View(db.Categories.ToList());
        }
    }
}