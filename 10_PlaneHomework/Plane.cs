namespace _10_PlaneHomework
{
    partial class Plane
    {
        private string name;
        private int year;
        private int length;
        private int wingspan;
        private double price;

        public Plane()
        {
            name = "No name";
            year = 0;
            length = 0;
            wingspan = 0;
            price = 0;
        }

        public Plane(string name, int year, int length, int wingspan, double price)
        {
            this.name = name;
            this.year = year;
            this.length = length;
            this.wingspan = wingspan;
            this.price = price;
        }

        public string GetName() { return name; }
        public int GetYear() { return year; }
        public int GetLength() { return length; }
        public int GetWingspan() { return wingspan; }
        public double GetPrice() { return price; }

        public void SetName(string name) { this.name = name; }
        public void SetYear(int year) { this.year = year; }
        public void SetLength(int length) {this.length = length; }
        public void SetWingspan(int wingspan) { this.wingspan = wingspan;}
        public void SetPrice(double price) { this.price = price; }

        public override string ToString()
        {
            return $"Name: {name}\n\tYear: {year}\n\tLength: {length}\n\tWingspan: {wingspan}\n\tPrice: {price}$";
        }
    }
}