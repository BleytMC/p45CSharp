using System.Net.Http.Headers;

int[,] arr = new int[7, 8];
Random random = new Random();

for (int i = 0; i < arr.GetLength(0); i++) for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = random.Next(-100, 100);
for (int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++) Console.Write(arr[i, j] + " ");
    Console.WriteLine();
}

int res = arr[0, 0], max;

for(int i = 0; i < arr.GetLength(0); i++)
{
    max = arr[i, 0];
    for(int j = 0;j < arr.GetLength(1); j++) if (arr[i, j] > max) max = arr[i, j];
    if (max < res) res = max;
}

Console.WriteLine(res);
Console.WriteLine("\n");

Console.Write("Enter text: ");
string str =  Console.ReadLine(), word, w;
int choice, a;

do
{
    Console.WriteLine("\n" + str);
    Console.WriteLine("\n0 - Exit");
    Console.WriteLine("1 - Get text lenght");
    Console.WriteLine("2 - Find word");
    Console.WriteLine("3 - Replace word");
    Console.WriteLine("4 - Remove word");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (choice)
    {
        case 1:
            Console.WriteLine(str.Length);
            break;
        case 2:
            {
                Console.Write("Enter your word: ");
                word = Console.ReadLine();
                string[] buf = str.Split(" ");
                a = 0;
                foreach (string s in buf) if (s == word) a++;
                Console.WriteLine($"There are {a} similar words");
            }
            break;
        case 3:
            {
                Console.Write("Enter old word: ");
                word = Console.ReadLine();
                Console.Write("Enter new word: ");
                w = Console.ReadLine();
                string[] buf = str.Split(" ");
                str = "";
                foreach (string s in buf)
                {
                    if (s != word) str += s + " ";
                    else str += w + " ";
                }
            }
            break;
        case 4:
            {
                Console.Write("Enter your word: ");
                word = Console.ReadLine();
                string[] buf = str.Split(" ");
                str = "";
                foreach (string s in buf) if (s != word) str += s + " ";
            }
            break;
    }
} while (choice != 0);