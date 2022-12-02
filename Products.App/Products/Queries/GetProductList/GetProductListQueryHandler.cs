using MediatR;
using Products.App.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Products.App.Products.Queries.GetProductList
{
    public class GetProductListQueryHandler
         : IRequestHandler<GetProductListQuery, ProductListVm>
    {
        private readonly IProductsDbContext _dbContext;

        public GetProductListQueryHandler(IProductsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductListVm> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            // if you use EF then you need to do AsQueryable instead of ToList
            var queryProducts = _dbContext.Products.ToList();

            if (request.To != 0 && request.To < request.From)
            {
                var temp = request.To;
                request.To = request.From;
                request.From = temp;
            }

            if (request.From > 0)
            {
                request.From--;
                queryProducts = queryProducts.Skip(request.From).ToList();
            }
            if(request.To != 0)
            {
                queryProducts = queryProducts.Take(request.To - request.From).ToList();
            }

            return new ProductListVm { Products = queryProducts };
        }
    }
}