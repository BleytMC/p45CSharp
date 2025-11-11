Console.Write("Enter A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int b = Convert.ToInt32(Console.ReadLine());
for(int i = a; i <= b; i++)
{
    for(int j = 0; j < i; j++) Console.Write(i + " ");
    Console.WriteLine();
}

Console.WriteLine();

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine()), c = 0;
while(n != 0)
{
    c = (c * 10) + (n % 10);
    n /= 10;
}
Console.WriteLine(c);