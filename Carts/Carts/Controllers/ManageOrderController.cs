using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carts.Controllers
{
    public class ManageOrderController : Controller
    {
        // GET: ManageOrder
        public ActionResult Index()
        {
            using(Models.CartsEntities db = new Models.CartsEntities())
            {
                var result = (from s in db.Orders select s).ToList();
                return View(result);
            }
        }

        public ActionResult Details(int id)
        {
            using (Models.CartsEntities db = new Models.CartsEntities())
            {
                var result = (from s in db.OrderDetails where s.OrderId == id select s).ToList();

                if (result.Count == 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(result);
                }
            }
        }
    }
}