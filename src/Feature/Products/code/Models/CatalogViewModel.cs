using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreCITest.Feature.Products.Models
{
    public class CatalogViewModel
    {
        public CatalogViewModel()
        {
            this.Products = new List<Product>();
        }

        public string Id { get; set; }

        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            this.Products.Add(product);
        }
    }
}