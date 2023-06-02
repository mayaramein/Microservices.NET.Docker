using static System.Net.Mime.MediaTypeNames;

namespace Catalog.APIs.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public Category(int id, string name, string image)
        {
            Id = id;
            Name = name;
            Image = image;
        }

        public Category() { }
    }
}
