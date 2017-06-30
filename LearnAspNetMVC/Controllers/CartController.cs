using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnAspNetMVC.Models;

namespace LearnAspNetMVC.Controllers
{
    public class CartController : Controller
    {

        List<CartLine> cartLine;

        public CartController()
        {
            cartLine = new List<CartLine>();
        }

        // GET: Cart
        public ActionResult AddToCart(Item item, int id, string returnUrl)
        {
            return Redirect(returnUrl);
        }
    }

    public class CartLine
    {
        public Item item { get; set; }
        public int quantity { get; set; }
    }
}
