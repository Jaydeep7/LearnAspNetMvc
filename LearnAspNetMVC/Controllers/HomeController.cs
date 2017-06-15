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



            return View(model);
        }

        public PartialViewResult Filter(ProductsVM productsVm)
        {
            productsVm.categories.RemoveAll(x => x.isSelected == true);

            var model = from it in db.Items
                        join ct in productsVm.categories
                        on it.Category.Id equals ct.Id
                        select it;

            return PartialView("DisplayItem", model.ToList());
        }
    }
}