using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Backend.Models;
using Backend.Data;
using Backend.ModelView;

namespace Backend.Controllers
{
    public class HomeController : Controller
    {
        DataContext context;

        public HomeController(/*DataContext context*/)
        {
            //this.context = context;
        }

        public IActionResult Index()
        {
            DataContext context = new DataContext();

            //IEnumerable<Product> products = context.Products;

            List<ProductModel> products = new List<ProductModel>();// context.Products.ToList();

            foreach(var item in context.Products.ToList())
            {
                products.Add(item);
            }

            IndexModelView modelView = new IndexModelView(products);

            return View(modelView);
        }

        public IActionResult Details(int id)
        {
            DataContext context = new DataContext();

            //neet to passing data between to pages to skip this db read
            ProductModel product = context.Products.SingleOrDefault(i => i.ID == id);

            //DetalisModelView modelView = new DetailsModelView(product);
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
