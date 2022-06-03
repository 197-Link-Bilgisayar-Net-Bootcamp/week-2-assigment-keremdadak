using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week2.API.Models;
using Week2.API.Repository;

namespace Week2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productRepository.GetProduct());
        }
        [HttpGet("{id}")]

        public IActionResult GetProducts(Guid id)
        {
            var product = _productRepository.GetProduct(id);
            if (product != null)
            {
                return Ok(product);
            }

            return NotFound($"Ürün Id'si : {id} olan id'ye ait ürün bulunamadı.");
        }
        [HttpPost]
        public IActionResult GetProducts(Product product)
        {
            _productRepository.AddProduct(product);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + product.Id, product);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProducts(Guid id)
        {
            var product = _productRepository.GetProduct(id);

            if (product != null)
            {
                _productRepository.DeleteProduct(product);
                return Ok($"{id} numaralı id başarıyla silindi");
            }
            return NotFound($"Ürün Id'si : {id} olan id'ye ait ürün bulunamadı.");
        }
        //Sadece var olan veriyi değiştireceğim için put yerine denemek amaçlı patch kullandım.
        [HttpPatch("{id}")]
        public IActionResult UpdateProducts(Product product, Guid id)
        {
            var p = _productRepository.GetProduct(id);
            if (p != null)
            {
                product.Id = p.Id;
                _productRepository.UpdateProduct(product);
                return Ok($"{id} numaralı id başarıyla güncellendi.");
            }
            return NotFound($"Ürün Id'si : {id} olan id'ye ait ürün bulunamadı.");
        }
    }
}
