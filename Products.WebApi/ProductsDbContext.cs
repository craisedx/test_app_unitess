using System;
using System.Collections.Generic;
using Products.App.Interfaces;
using Products.Domain;

namespace Products.WebApi
{
    public class ProductsDbContext : IProductsDbContext
    {
        public IList<Product> Products { get; set; } = new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Milk1", Description = "Desc", Amount = 15, DateReceipt = DateTime.Today},
            new Product { Id = Guid.NewGuid(), Name = "Milk2", Description = "Desc", Amount = 15, DateReceipt = DateTime.Today},
            new Product { Id = Guid.NewGuid(), Name = "Milk3", Description = "Desc", Amount = 15, DateReceipt = DateTime.Today},
            new Product { Id = Guid.NewGuid(), Name = "Milk4", Description = "Desc", Amount = 15, DateReceipt = DateTime.Today},
            new Product { Id = Guid.NewGuid(), Name = "Milk5", Description = "Desc", Amount = 15, DateReceipt = DateTime.Today},
            new Product { Id = Guid.NewGuid(), Name = "Milk6", Description = "Desc", Amount = 15, DateReceipt = DateTime.Today},
            new Product { Id = Guid.NewGuid(), Name = "Milk7", Description = "Desc", Amount = 15, DateReceipt = DateTime.Today},
            new Product { Id = Guid.NewGuid(), Name = "Milk8", Description = "Desc", Amount = 15, DateReceipt = DateTime.Today},
        };
    }
}