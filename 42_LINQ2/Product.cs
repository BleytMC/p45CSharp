namespace _42_LINQ2
{
    class Product
    {
        public string Name { set; get; }
        public int Price { set; get; }
        public string Manufacturer { set; get; }
        public int Count { set; get; }
        public override string ToString()
        {
            return $"{Name}\t{Price}\t{Manufacturer}\t{Count}";
        }
    }
}
