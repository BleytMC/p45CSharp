namespace _04_Classes
{
    class Student
    {
        private string name;
        private string surname;
        private int age;


        public Student() : this("No name", "No surname", 0)
        {

        }

        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }


        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }


        public void Print()
        {
            Console.WriteLine($"Name: {name} | Surname: {surname} | Age: {age}");
        }
    }
}
