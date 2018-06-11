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

        //GET SALE


        public ActionResult Index()
        {
            if (Session["PersonKey"] == null)
            {
                Message m = new Message();
                m.MessageText = "Please log in to place an order";
                return RedirectToAction("Result", m);
            }
            //Create a Sales Order Object
            //    {
            //        Sale s = new Sale();
            //        Session["Sale"] = s;

            //        ViewBag.products = new SelectList(db.Products, "ProductKey", "ProductName");
                 return View();
               }
            //}
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //        public ActionResult Index([Bind(Include = "ProductKey,ProductName,Price,Quantity, Discount")]Item i)
            //        { 
            //       var prod = from p in db.Products
            //                  where p.ProductKey == i.ProductKey
            //                  select new { p.ProductName, p.ProductPrice };

            //            foreach(var pr in prod)
            //            {
            //                i.ProductName = pr.ProductName.ToString();
            //                i.Price = (decimal) pr.ProductPrice;
            //    }
            //            Sale s = (Sale)Session["Sale"];

            //            s.AddItem(i);
            //            Session["Sale"] = s;
            //            ViewBag.prduct = new SelectList(db.Products, "ProductKey", "ProductName");
            //            return View();
            //}
            //        public ActionResult FinishSale()

            //           {
            //            Sale sale = new Sale();
            //            sale.EmployeeKey = 1;
            //            sale.SaleDate = DateTime.Now;
            //            sale.CustomerKey = (int)Session["PersonKey"];
            //            db.Sales.Add(sale);


            //            Sale s = (Sale)Session["sale"];
            //            List<Item> saleItem = s.GetItem();

            //            foreach (Item in saleItem)
            //            {
            //                SaleDetail sd = new SaleDetail();
            //                sd.Sale = sale;
            //                sd.ProductKey = i.ProductKey;
            //                sd.SaleDetailPriceCharged = i.Price;
            //                sd.SaleDetailQuantity = i.Quantity;
            //                sd.SaleDetailDiscount = (decimal)i.Discount;
            //                sd.SaleDetailSaleTaxPercent = .09m;
            //                sd.SaleDetailEatInTax = .01m;

            //                db.SaleDetails.Add(sd);
            //            }



        }
    }
