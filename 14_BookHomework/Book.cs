using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_BookHomework
{
    class Book
    {
        public string Name { get; set; }
        public string Writer { get; set; }
        public string Ganre { get; set; }
        public int Year { get; set; }

        public Book(string name, string writer, string ganre, int year)
        {
            Name = name;
            Writer = writer;
            Ganre = ganre;
            Year = year;
        }

        public override string ToString()
        {
            return $"Name: {Name},\tWriter: {Writer},\tGanre: {Ganre},\tYear: {Year}";
        }
    }
}
