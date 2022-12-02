using Products.App.Products.Queries.GetProductList;
using Products.Tests.Common;
using Products.WebApi;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Products.Tests.Queries
{
    [Collection("QueryCollection")]
    public class GetProductListQueryHandlerTests
    {
        private readonly ProductsDbContext context;
        public GetProductListQueryHandlerTests(QueryTestFixture fixture)
        {
            context = fixture.Context;
        }

        [Fact]
        public async Task GetProductListWithTwoParametersQueryHandler_Success()
        {
            // Arrange
            var handler = new GetProductListQueryHandler(context);

            // Act
            var result = await handler.Handle(
                new GetProductListQuery
                {
                    From = ProductsContextFactory.FromA,
                    To = ProductsContextFactory.ToA,
                },
                CancellationToken.None);

            // Assert
            result.ShouldBeOfType<ProductListVm>();
            result.Products.Count.ShouldBe(3);
        }
        
        [Fact]
        public async Task GetProductListWithReverseTwoParametersQueryHandler_Success()
        {
            // Arrange
            var handler = new GetProductListQueryHandler(context);

            // Act
            var result = await handler.Handle(
                new GetProductListQuery
                {
                    From = ProductsContextFactory.FromB,
                    To = ProductsContextFactory.ToB,
                },
                CancellationToken.None);

            // Assert
            result.ShouldBeOfType<ProductListVm>();
            result.Products.Count.ShouldBe(2);
        }
        
        [Fact]
        public async Task GetProductListWithoutParametersQueryHandler_Success()
        {
            // Arrange
            var handler = new GetProductListQueryHandler(context);

            // Act
            var result = await handler.Handle(
                new GetProductListQuery(),
                CancellationToken.None);

            // Assert
            result.ShouldBeOfType<ProductListVm>();
            result.Products.Count.ShouldBe(5);
        }
    }
}
