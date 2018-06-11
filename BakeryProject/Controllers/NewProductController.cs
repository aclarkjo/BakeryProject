using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryProject.Models;

namespace BakeryProject.Controllers
{
    public class NewProductController : Controller
    {
        // GET: NewProduct
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include ="ProductName, ProductPrice")]Product p)
        {
            BakeryEntities db = new BakeryEntities();
            db.Products.Add(p);
            db.SaveChanges();
            return View();
        }



    }
}