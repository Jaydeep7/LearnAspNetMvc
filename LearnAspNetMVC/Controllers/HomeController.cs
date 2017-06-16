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
            try
            {
                productsVm.categories.RemoveAll(x => x.isSelected == false);
                //var model = (from it in db.Items
                //            join ct in productsVm.categories
                //            on it.Category.Id equals ct.Id
                //            select it).ToList();
                HashSet<int> categories = new HashSet<int>(productsVm.categories.Select(x => x.Id));

                List<Item> items = db.Items.ToList();
                items.RemoveAll(x => categories.Contains(x.Category.Id));

                return PartialView("DisplayItem", items);
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

    }
}