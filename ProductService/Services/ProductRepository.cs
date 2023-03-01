using ProductService.Model;

namespace ProductService.Services
{
    public class ProductRepository : IProductRepository
    {
        private static readonly IEnumerable<Product> products = new List<Product>()
        {

        };

        public ProductRepository()
        {

        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        
    }
}
