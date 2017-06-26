using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnAspNetMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string TestAction()
        {
            return "From Test Action.....";
        }
    }
}