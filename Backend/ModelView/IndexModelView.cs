using Backend.Models;
using System.Collections.Generic;

namespace Backend.ModelView
{
    public class IndexModelView
    {
        List<ProductModel> products;

        public List<ProductModel> Products
        { 
            get
            {
                return this.products;
            }
            set
            {
                this.products = value;
            }
        }

        public IndexModelView(List<ProductModel> products)
        {
            this.products = products;
        }
    }
}