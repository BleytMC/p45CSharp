namespace _09_ShopTask
{
    class Shop
    {
        private Laptop[] laptops { get; set; }

        public Shop(Laptop[] laptops)
        {
            this.laptops = laptops;
        }

        public override string ToString()
        {
            return string.Join("\n", laptops.Select(s => s.ToString()).ToArray());
        }

        public int FindIndexByVendor(string vendor)
        {
            for(int i = 0; i < laptops.Length; i++)
                if (laptops[i].GetVendor() == vendor) return i;
            return -1;
        }

        public int FindIndexByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
                if (laptops[i].GetPrice() == price) return i;
            return -1;
        }

        public Laptop this[int index]
        {
            get
            {
                return laptops[index];
            }
            set
            {
                if (index >= 0 && index < laptops.Length) laptops[index] = value;
            }
        }

        public Laptop this[string vendor]
        {
            get
            {
                int index = FindIndexByVendor(vendor);
                return laptops[index];
            }
            set
            {
                int index = FindIndexByVendor(vendor);
                if (index >= 0 && index < laptops.Length) laptops[index] = value;
            }
        }

        public Laptop this[double price]
        {
            get
            {
                int index = FindIndexByPrice(price);
                return laptops[index];
            }
            set
            {
                int index = FindIndexByPrice(price);
                if (index >= 0 && index < laptops.Length) laptops[index] = value;
            }
        }
    }
}
