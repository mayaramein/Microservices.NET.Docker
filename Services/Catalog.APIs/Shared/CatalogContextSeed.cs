using Catalog.APIs.Entity;
using MongoDB.Driver;

namespace Catalog.APIs.Shared
{
    public static class CatalogContextSeed
    {
        public static void SeedProductsData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (existProduct)
            {
                productCollection.InsertManyAsync(GetPrecoonfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPrecoonfiguredProducts()
        {
            return new List<Product>()
            {
                new Product
    {
        Name = "Product 1",
        Summary = "This is a summary for product 1",
        Description = "This is a description for product 1",
        Image = "product1.jpg",
        Price = 9.99M,
        Category = new Category { Name = "Category 1" }
    },
                new Product
    {
        Name = "Product 2",
        Summary = "This is a summary for product 2",
        Description = "This is a description for product 2",
        Image = "product2.jpg",
        Price = 19.99M,
        Category = new Category { Name = "Category 2" }
    },
                new Product
    {
        Name = "Product 3",
        Summary = "This is a summary for product 3",
        Description = "This is a description for product 3",
        Image = "product3.jpg",
        Price = 29.99M,
        Category = new Category { Name = "Category 3" }
    }

            };
        }

        public static void SeedCategoriesData(IMongoCollection<Category> categoryCollection)
        {
            bool existCategory = categoryCollection.Find(p => true).Any();
            if (existCategory)
            {
                categoryCollection.InsertManyAsync(GetPreconfiguredCategories());
            }
        }

        private static IEnumerable<Category> GetPreconfiguredCategories()
        {
            return new List<Category>()
            {
                new Category
    {
        Name = "Category 1",
        Image = "category1.jpg"
    },
                new Category
    {
        Name = "Category 2",
        Image = "category2.jpg"
    },
                new Category
    {
        Name = "Category 3",
        Image = "category3.jpg"
    }
            };
        }
    }
}
