//int[] arrayInt = { 5, 34, 67, 12, 94, 42 };

// Синтаксис запиту

// from, in, select

//IEnumerable<int> query = from i in arrayInt select i;

//foreach (int item in query)
//{
//    Console.Write($"{item} ");
//}


// where


//bool isSimple(int a)
//{
//    for (int i = 2; i < a; i++) if (a % i == 0) return false;
//    return true;
//}

//int[] arrayInt = { 5, 34, 67, 12, 94, 42 };

//IEnumerable<int> query = from i in arrayInt where isSimple(i) select i;

//foreach (int i in query) Console.Write($"{i} ");


// orderby, ascending, descending

//int[] arrayInt = { 5, 34, 67, 12, 94, 42 };

//var query = from i in arrayInt where i % 2 == 0 orderby i ascending select i;

//foreach (int i in query) Console.Write($"{i} ");


using System.Collections;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] students = new string[20]
        {
            "Іваненко", "Петренко", "Сидоренко", "Коваленко", "Бондаренко",
            "Ткаченко", "Кравченко", "Олійник", "Шевченко", "Поліщук",
            "Лисенко", "Кузнецов", "Марченко", "Козак", "Мазур",
            "Мороз", "Кушнір", "Павленко", "Савченко", "Клименко"
        };


IEnumerable<IGrouping<char, string>> query = from s in students group s by s[0] into res where res.Count() > 2 select res;

foreach (var group in query)
{
    Console.WriteLine(group.Key);
    foreach (string s in group) Console.WriteLine(s);
}

//int[] arrayInt = { 5, 34, 67, 12, 94, 42 };

//IEnumerable<int> query = arrayInt.Where(i => i % 2 == 0).OrderBy(i => i).Select(i => i);

//foreach (int i in query) Console.WriteLine(i);

//string[] students = new string[20]
//        {
//            "Іваненко", "Петренко", "Сидоренко", "Коваленко", "Бондаренко",
//            "Ткаченко", "Кравченко", "Олійник", "Шевченко", "Поліщук",
//            "Лисенко", "Кузнецов", "Марченко", "Козак", "Мазур",
//            "Мороз", "Кушнір", "Павленко", "Савченко", "Клименко"
//        };

//var query = students.GroupBy(s => s[0]).Where(g => g.Count() > 1);

//foreach (var group in query)
//{
//    Console.WriteLine(group.Key);
//    foreach (string s in group) Console.WriteLine(s);
//}