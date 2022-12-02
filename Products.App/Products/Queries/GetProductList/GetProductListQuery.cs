using MediatR;

namespace Products.App.Products.Queries.GetProductList
{
    public class GetProductListQuery : IRequest<ProductListVm>
    {
        public int From { get; set; }
        public int To { get; set; }
    }
}
