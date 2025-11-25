using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_BookHomework
{
    class HomeLibrary
    {
        private List<Book> books;

        public HomeLibrary(List<Book> books)
        {
            this.books = books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string name)
        {
            books.Remove(byName(name));
        }

        private Book byName(string name)
        {
            return books.Find(x => x.Name == name);
        }

        public HomeLibrary FindByName(string name)
        {
            return new HomeLibrary(books.FindAll(x => x.Name == name));
        }

        public HomeLibrary FindByWriter(string writer)
        {
            return new HomeLibrary(books.FindAll(x => x.Writer == writer));
        }

        public HomeLibrary FindByGanre(string ganre)
        {
            return new HomeLibrary(books.FindAll(x => x.Ganre == ganre));
        }

        public HomeLibrary FindByYear(int year)
        {
            return new HomeLibrary(books.FindAll(x => x.Year == year));
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (Book book in books) str += book.ToString() + "\n";
            return str;
        }
    }
}
