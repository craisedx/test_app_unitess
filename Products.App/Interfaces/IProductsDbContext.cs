using Products.Domain;
using System.Collections.Generic;

namespace Products.App.Interfaces
{
    public interface IProductsDbContext
    {
        IList<Product> Products { get; set; }
    }
}