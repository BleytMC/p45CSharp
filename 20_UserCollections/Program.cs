using _20_UserCollections;

UserCollection myCollection = new UserCollection(new Element[]{
            new Element("A", 1, 10),
            new Element("B", 2, 20),
            new Element("C", 3, 30),
            new Element("D", 4, 40),
        });

foreach(Element el in myCollection)
{
    Console.WriteLine(el);
}