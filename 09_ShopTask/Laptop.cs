namespace _09_ShopTask
{
    class Laptop
    {
        private string vendor { get; set; }
        private double price { get; set; }

        public string GetVendor() { return vendor; }
        public double GetPrice() { return price; }

        public Laptop(string vendor, double price)
        {
            this.vendor = vendor;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Vendor: {vendor}, Price: {price}";
        }
    }
}
