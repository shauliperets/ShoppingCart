using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Backend.Data;
using Backend.Models;

namespace Backend.Controllers.API
{
    
    public class ProductController : ControllerBase
    {
        [Route("api/[controller]")]
        public IEnumerable<ProductModel> GetProducts()
        {
            using(DataContext context = new DataContext())
            {
                return context.Products.ToList();
            }

            return null;
        }

        [HttpPost]
        [Route("api/[controller]")]
        public bool UpdateProduct(int id, string name/*, short price, string description*/)
        {
            //this.log("ProductController", "Name: " + name.ToString() + " , Price:" + price.ToString() + " , Description:" + description);
            this.log("ProductController", "Name: " + name.ToString());

            using(DataContext context = new DataContext())
            {
                string str = "";
                //str += string.Format("paramates ==> id: {0}, name: {1}, price: {2}, description: {3} |||", id, name, price, description);
                foreach(ProductModel item in context.Products)
                {
                    //str += string.Format("id: {0}, name: {1}, price: {2}, description: {3} :::", item.ID, item.Name, item.Price, item.Description);
                    //this.log("ProductController", string.Format("id: {0}, name: {1}, price: {2}, description: {3}", item.ID, item.Name, item.Price, item.Description));
                    if(item.ID == id)
                     {
                         //str += string.Format("if-> id: {0}, name: {1}, price: {2}, description: {3} ***", item.ID, item.Name, item.Price, item.Description);
                         //this.log("ProductController", string.Format("if-> id: {0}, name: {1}, price: {2}, description: {3}", id, name, price, description));
                         item.Name = name;
                         //item.Price = price;
                         //item.Description = description;
                     }
                }

                this.log("ProductController", str);

                //context.Update(product);
                context.SaveChanges();

                return true;
            }
            
            return false;
        }

        private void log(string file, string description)
        {
            using(DataContext context = new DataContext())
            {
                LogModel log = new LogModel(file, description, DateTime.Now);

                context.AddRange(log);
                context.SaveChanges();
            }
        }
    }


}