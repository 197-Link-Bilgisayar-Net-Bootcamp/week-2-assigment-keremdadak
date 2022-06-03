using Week2.API.Models;

namespace Week2.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id=Guid.NewGuid(),
                name="Product 1"
            },
            new Product()
            {
                Id = Guid.NewGuid(),
                name="Product 2"
            }
        };
        public Product AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            products.Add(product);
            return product;
        }

        public void DeleteProduct(Product product)
        {
            products.Remove(product);
        }

        public List<Product> GetProduct()
        {
            return products;
        }

        public Product GetProduct(Guid id)
        {
            return products.SingleOrDefault(x => x.Id == id);
        }

        public Product UpdateProduct(Product product)
        {
            var p = GetProduct(product.Id);
            p.name = product.name;
            return p;

        }
    }
}
