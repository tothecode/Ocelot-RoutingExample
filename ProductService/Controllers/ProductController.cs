using Microsoft.AspNetCore.Mvc;
using ProductService.Model;
using ProductService.Services;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productService;

        public ProductController(IProductRepository productService)
        {
            _productService = productService;
        }

        [HttpGet("all")]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }
    }
}