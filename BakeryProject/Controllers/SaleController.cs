using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryProject.Models;
namespace BakeryProject.Controllers
{
    public class SaleController : Controller
    {
        BakeryEntities db = new BakeryEntities();
        


        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index()
        {
            Sale s = new Sale();
            s.CustomerKey = (int)Session["PersonKey"];
            s.EmployeeKey = 1;
            s.SaleDate = DateTime.Now;
            db.Sales.Add(s);
            SaleDetail sd = new SaleDetail();
            List<Sale> orders = new List<Sale>();
        }
    }
}


