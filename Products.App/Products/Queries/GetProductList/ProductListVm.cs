using Products.Domain;
using System.Collections.Generic;

namespace Products.App.Products.Queries.GetProductList
{
    public class ProductListVm
    {
        public IList<Product> Products { get; set; }
    }
}
