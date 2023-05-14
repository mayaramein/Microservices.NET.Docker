using Catalog.APIs.Data;
using Catalog.APIs.Entity;
using MongoDB.Driver;

namespace Catalog.APIs.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly ICatalogContext _context;
        public ProductRepo(ICatalogContext context) 
        { 
            _context = context;
        }
        public Task CreateProduct(Product product)
        {
            return _context.Products.InsertOneAsync(product);
        }

        public async Task<bool> DeletePoduct(Product product)
        {
            FilterDefinition<Product> filterDefinition = Builders<Product>.Filter.Eq(p => p.Id, product.Id);
            DeleteResult deleteResult = await _context.Products.DeleteOneAsync(filterDefinition);

            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context
                .Products
                .Find(x => true)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryName(string categoryName)
        {
            FilterDefinition<Product> filterDefinition = Builders<Product>.Filter.Eq(p => p.Category.Name, categoryName);
             return await _context
                .Products
                .Find(filterDefinition)
                .ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context
                .Products
                .Find(p => p.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<Product> GetProductByName(string name)
        {
            FilterDefinition<Product> filterDefinition = Builders<Product>.Filter.Eq(p => p.Name, name);
            return await _context
               .Products
               .Find(filterDefinition)
               .FirstOrDefaultAsync();
        }

       
        public async Task<bool> UpdatePoduct(Product product)
        {
            var updateResult = await _context
                .Products
                .ReplaceOneAsync(filter: g => g.Id == product.Id, replacement: product);

            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }

        public async Task<Product> GetProductByCategoryName(string categoryName)
        {
            FilterDefinition<Product> filterDefinition = Builders<Product>.Filter.Eq(p => p.Category.Name, categoryName);
            return await _context
               .Products
               .Find(filterDefinition)
               .FirstOrDefaultAsync();
        }
    }
}
