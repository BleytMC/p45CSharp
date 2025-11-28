namespace _17_StandartInterfaces
{
    class Student : IComparable, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public object Clone()
        {
            Student student = (Student)MemberwiseClone();
            student.StudentCard = (StudentCard)this.StudentCard.Clone();
            return student;
        }

        public int CompareTo(object? obj)
        {
            if(obj is Student)
            {
                Student other = obj as Student;
                return FirstName.CompareTo(other.FirstName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Student: {FirstName}, {LastName} {BirthDate.ToShortDateString()} {StudentCard}";
        }
    }
}
