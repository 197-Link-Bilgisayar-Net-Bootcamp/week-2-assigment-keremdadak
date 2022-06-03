using Week2.API.Models;

namespace Week2.API.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProduct();
        Product GetProduct(Guid id);
        Product AddProduct(Product product);
        void DeleteProduct(Product product);
        Product UpdateProduct(Product product);
        

    }
}
