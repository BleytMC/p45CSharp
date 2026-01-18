namespace _46_FilesHM
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Product(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
