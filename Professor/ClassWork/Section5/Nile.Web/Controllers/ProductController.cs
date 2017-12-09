using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nile.Web.Models;

namespace Nile.Web.Controllers
{
    public class ProductController : Controller
    {
        public ProductController (IProductDatabase database)
        {
            _database = database;
        }

        // GET: Product
        public ActionResult List()
        {
            var products = _database.GetAll();
            return View(products.ToModel());
        }

        private readonly IProductDatabase _database;
    }
}