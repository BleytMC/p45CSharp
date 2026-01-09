namespace _43_LINQ_Practice2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{Name}\t{Age}\t{City}";
        }
    }
}
