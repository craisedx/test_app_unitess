using Products.Domain;
using Products.WebApi;
using System;
using System.Collections.Generic;

namespace Products.Tests.Common
{
    public class ProductsContextFactory
    {
        public static int FromA = 1;
        public static int ToA = 3;
        
        public static int FromB = 3;
        public static int ToB = 2;

        public static ProductsDbContext Create()
        {
            var context = new ProductsDbContext();
            context.Products = new List<Product>();
            context.Products.Add(
                new Product
                {
                    Id = Guid.Parse("A6BB65BB-5AC2-4AFA-8A28-2616F675B825"),
                    Name = "Milk",
                    Description = "Very good milk",
                    Amount = 15,
                    DateReceipt = DateTime.Today,
                });
            context.Products.Add(
                new Product
                {
                    Id = Guid.Parse("7FFF6C49-ABFB-4A08-BD54-5615186034EA"),
                    Name = "Potato",
                    Description = "Very good potato",
                    Amount = 505,
                    DateReceipt = DateTime.Today,
                });
            context.Products.Add(
                new Product
                {
                    Id = Guid.Parse("7A3167A6-40B7-4BD0-9B43-3CDC0A988473"),
                    Name = "Cucumber",
                    Description = "Very good Cucumber",
                    Amount = 55,
                    DateReceipt = DateTime.Today,
                });
            context.Products.Add(
                new Product
                {
                    Id = Guid.Parse("5A55FB89-3CFF-4C2D-B958-618659814488"),
                    Name = "Сarrot",
                    Description = "Very good carrot",
                    Amount = 100,
                    DateReceipt = DateTime.Today,
                });
            context.Products.Add(
                new Product
                {
                    Id = Guid.Parse("{4DB677E0-EAA4-4781-B51B-78F1D8F63BDA}"),
                    Name = "Сabbage",
                    Description = "Very good cabbage",
                    Amount = 400,
                    DateReceipt = DateTime.Today,
                });

            return context;
        }

        public static void Destroy(ProductsDbContext context)
        {
        }
    }
}
