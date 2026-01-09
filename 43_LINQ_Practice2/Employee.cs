namespace _43_LINQ_Practice2
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int DepId { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
}
