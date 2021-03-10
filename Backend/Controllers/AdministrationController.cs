using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Backend.Data;
using Backend.Models;
using Backend.ModelView;

namespace Backend.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            DataContext context = new DataContext();

            List<ProductModel> products = new List<ProductModel>();

            foreach(var item in context.Products.ToList())
            {
                products.Add(item);
            }
            
            AdministrationModelView modelView = new AdministrationModelView(products);

            return View(modelView);
        }
    }
}