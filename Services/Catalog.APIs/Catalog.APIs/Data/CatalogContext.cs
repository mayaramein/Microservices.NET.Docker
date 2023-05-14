using Catalog.APIs.Entity;
using Catalog.APIs.Shared;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Catalog.APIs.Data
{
    public class CatalogContext : ICatalogContext
    {
        private readonly DatabaseSettings _settings;
        public CatalogContext(IOptions<DatabaseSettings> settings) 
        {
            _settings = settings.Value;
            var client  = new MongoClient();
            var database = client.GetDatabase(_settings.DatabaseName);
            
            var Products = database.GetCollection<Product>(_settings.CollectionName);
            var Categories = database.GetCollection<Category>(_settings.CollectionName);
            
            CatalogContextSeed.SeedProductsData(Products);
            CatalogContextSeed.SeedCategoriesData(Categories);
        }

        public IMongoCollection<Product> Products => throw new NotImplementedException();

        public IMongoCollection<Category> Categories => throw new NotImplementedException();
    }
}
