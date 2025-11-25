using _14_BookHomework;
using System.Xml.Schema;

HomeLibrary books = new HomeLibrary(
[
    new Book("To Kill a Mockingbird", "Harper Lee", "Fiction", 1960),
    new Book("1984", "George Orwell", "Dystopian", 1949),
    new Book("The Great Gatsby", "F. Scott Fitzgerald", "Novel", 1925),
    new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy", 1937),
    new Book("Pride and Prejudice", "Jane Austen", "Romance", 1813),
    new Book("The Catcher in the Rye", "J.D. Salinger", "Fiction", 1951),
    new Book("Moby-Dick", "Herman Melville", "Adventure", 1851)
]);

int choice, year;
string name, writer, ganre;

do
{
    Console.WriteLine("\n" + books + "\n");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("1 - Add book");
    Console.WriteLine("2 - Remove book");
    Console.WriteLine("3 - Find by name");
    Console.WriteLine("4 - Find by writer");
    Console.WriteLine("5 - Find by ganre");
    Console.WriteLine("6 - Find by year");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter writer: ");
            writer = Console.ReadLine();
            Console.Write("Enter ganre: ");
            ganre = Console.ReadLine();
            Console.Write("Enter Year: ");
            year = Convert.ToInt32(Console.ReadLine());
            books.AddBook(new Book(name, writer, ganre, year));
            break;
        case 2:
            Console.Write("\nEnter name: ");
            name = Console.ReadLine();
            books.RemoveBook(name);
            break;
        case 3:
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("\n" + books.FindByName(name));
            break;
        case 4:
            Console.Write("Enter writer: ");
            writer = Console.ReadLine();
            Console.WriteLine("\n" + books.FindByWriter(writer));
            break;
        case 5:
            Console.Write("Enter ganre: ");
            ganre = Console.ReadLine();
            Console.WriteLine("\n" + books.FindByGanre(ganre));
            break;
        case 6:
            Console.Write("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + books.FindByYear(year));
            break;
    }
} while (choice != 0);