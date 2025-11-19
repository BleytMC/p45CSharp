namespace _08_OperatorsOverloading
{
    class Group
    {
        private Student[] students { get; set; }

        public Group(Student[] students)
        {
            this.students = students;
        }

        public override string ToString()
        {
            //return string.Join("\n", students);

            //string res = string.Empty;
            //foreach (Student student in students) res += student + "\n";
            //return res;

            return string.Join("", students.Select(s => s.ToString() + "\n").ToArray());
        }

        public Student this[int index]
        {
            get
            {
                return students[index];
            }
            set
            {
                if(index >= 0 && index < students.Length) students[index] = value;
            }
        }

        public int FindIndexByName(string name)
        {
            for(int i = 0; i < students.Length; i++)
                if(students[i].Name == name) return i;
            return -1;
        }


        public Student this[string name]
        {
            get
            {
                int index = FindIndexByName(name);
                return students[index];
            }
            set
            {
                int index = FindIndexByName(name);
                if (index >= 0 && index < students.Length) students[index] = value;
            }
        }
    }
}
