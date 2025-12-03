using _24_GenericList;

_24_GenericList.List<int> list = new _24_GenericList.List<int>();

list.AddTail(4);
list.AddTail(8);
list.AddTail(1);
list.AddTail(-6);

foreach (int el in list)
{
    Console.WriteLine(el);
}