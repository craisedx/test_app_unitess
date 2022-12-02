using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.App.Products.Queries.GetProductList;

namespace Products.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class ProductController : BaseController
    {
        /// <summary>
        /// Gets the list of products
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// GET /product
        /// </remarks>
        /// <param name="from">Product start (int)</param>
        /// <param name="to">Product end (int)</param>
        /// <returns>Returns ProductListVm</returns>
        /// <response code="200">Success</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ProductListVm>> GetAll(int from = 0, int to = 0)
        {
            var query = new GetProductListQuery()
            {
                 From = from,
                 To = to,
            };
            
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }
    }
}