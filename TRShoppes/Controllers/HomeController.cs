using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRShoppes.DAL;
using TRShoppes.ViewModels;

namespace TRShoppes.Controllers
{
    public class HomeController : Controller
    {
        private ShopContext db = new ShopContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<PurchaseDateGroup> data = from customer in db.Customers
                                                   group customer by customer.PurchaseDate into dateGroup
                                                   select new PurchaseDateGroup()
                                                   {
                                                       PurchaseDate = dateGroup.Key,
                                                       CustomerCount = dateGroup.Count()
                                                   };
            return View(data.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}