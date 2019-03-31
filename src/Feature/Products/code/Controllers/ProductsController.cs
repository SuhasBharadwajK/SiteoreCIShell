using SitecoreCITest.Feature.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace code.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var index = 0;
            var model = new CatalogViewModel();
            model.AddProduct(new Product { Id = ++index, Name = "Galaxy S10" });
            model.AddProduct(new Product { Id = ++index, Name = "Google Pixel 3" });
            model.AddProduct(new Product { Id = ++index, Name = "Galaxy Note 9" });
            model.AddProduct(new Product { Id = ++index, Name = "OnePlus 7" });

            return View("~/Views/Feature/Products/Catalog.cshtml", model);
        }
    }
}