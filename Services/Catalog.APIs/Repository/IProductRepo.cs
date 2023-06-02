using Catalog.APIs.Entity;

namespace Catalog.APIs.Repository
{
    public interface IProductRepo
    {
        Task CreateProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(Product product);   
        Task<bool> DeleteProductById(int id);   
        Task<Product> GetProductById(int id);
        Task<Product> GetProductByName(string name);
        Task<Product> GetProductByCategoryName(string categoryName);
        Task<IEnumerable<Product>> GetProductsByCategoryName(string categoryName);  
    }
}
