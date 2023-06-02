using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.APIs.Entity
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public Product(int id, 
            string name, 
            string summary, 
            string image, 
            string description, 
            decimal price, 
            Category category)
        {
            Id = id;
            Summary = summary;
            Image = image;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }

        public Product() { }
    }
    
}
