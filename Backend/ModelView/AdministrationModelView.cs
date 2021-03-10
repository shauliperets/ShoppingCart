using Backend.Models;
using Backend.ModelView;
using System.Collections.Generic;

namespace Backend.ModelView
{
    public class AdministrationModelView
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

        public AdministrationModelView(List<ProductModel> products)
        {
            this.products = products;
        }
    }
}