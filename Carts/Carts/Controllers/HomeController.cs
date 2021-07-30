using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carts.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using ( Models.CartsEntities db = new Models.CartsEntities())
            {
                var result = (from s in db.Products select s).ToList();
                return View(result);
            }
            
        }

        public ActionResult Index2()
        {
            return Content(
                "<html><body><h1>這是一段訊息</h1></body></html>"
                );
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
    }
}