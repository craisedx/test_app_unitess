using Products.WebApi;
using System;

namespace Products.Tests.Common
{
    public class QueryTestFixture : IDisposable
    {
        public readonly ProductsDbContext Context;

        public QueryTestFixture()
        {
            Context = ProductsContextFactory.Create();
        }

        public void Dispose()
        {
            ProductsContextFactory.Destroy(Context);
        }
    }
}
