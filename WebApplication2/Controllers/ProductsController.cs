using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        public ProductsController()
        {

        }

        // GET: Products
        public ActionResult Index()
        {
            return View(DataStorage.Instance.Products);
        }

        [HttpGet]
        public ActionResult Products(int id)
        {
            var product = DataStorage.Instance.Products.FirstOrDefault(p => p.Id == id);
            return View("AddProduct", product);
        }

        public ActionResult AddProduct()
        {

            ViewBag.Title = "Add new product";
            return View();
        }

        [HttpPost]
        public ActionResult Products(Product product)
        {
            if (ModelState.IsValid)
            {
                DataStorage.Instance.Products.Add(product);
                return Redirect("/Products/");
            }
            else
            {
                return View("AddProduct", product);
            }
        }
    }
}