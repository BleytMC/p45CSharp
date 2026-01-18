namespace _46_FilesHM
{
    class Shop
    {
        public string Name { get; private set; }
        public Product[] Products { get; private set; }

        public Shop(string name, Product[] products)
        {
            Name = name;
            Products = products;
        }
    }
}
