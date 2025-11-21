namespace _12_Inheritance
{
    class Employee : Person
    {
        public double Salary { get; set; }

        public Employee(string name, int age, double salary) : base(name, age)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Salary: {Salary}";
        }
    }
}
