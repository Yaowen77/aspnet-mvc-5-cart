using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carts.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.OrderModel.Ship postback)
        {
            if(this.ModelState.IsValid)
            {
                var currentcart = Models.Cart.Operation.GetCurrentCart();

                var userId = "1111";
                using (Models.CartsEntities db = new Models.CartsEntities())
                {
                    var order = new Models.Order()
                    {
                        UserId = userId,
                        RecieverName = postback.RecieverName,
                        RecieverPhone = postback.RecieverPhone,
                        RecieverAddress = postback.RecieverAdress
                    };

                    db.Orders.Add(order);
                    db.SaveChanges();

                    var orderDetails = currentcart.ToOrderDetailList(order.Id);

                    db.OrderDetails.AddRange(orderDetails);
                    db.SaveChanges();
                }
                return Content("訂購成功");
            }            
            
            return View();
        }
    }
}