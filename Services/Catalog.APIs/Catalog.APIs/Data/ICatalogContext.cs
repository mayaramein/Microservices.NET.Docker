using Catalog.APIs.Entity;
using MongoDB.Driver;

namespace Catalog.APIs.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
        IMongoCollection<Category> Categories { get; }
    }
}
