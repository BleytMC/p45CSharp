using _19_VectorHomework;

Vector vec = new Vector();
bool running = true;

// Меню чат зробив

while (running)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1. PushBack");
    Console.WriteLine("2. PopBack");
    Console.WriteLine("3. Insert");
    Console.WriteLine("4. Erase");
    Console.WriteLine("5. IsEmpty");
    Console.WriteLine("6. At");
    Console.WriteLine("7. Reverse");
    Console.WriteLine("8. Clear");
    Console.WriteLine("9. Print vector");
    Console.WriteLine("0. Exit");
    Console.Write("Select option: ");

    string option = Console.ReadLine();
    Console.WriteLine();

    try
    {
        switch (option)
        {
            case "1":
                Console.Write("Enter value: ");
                int val = int.Parse(Console.ReadLine());
                vec.PushBack(val);
                break;

            case "2":
                Console.WriteLine("Removed: " + vec.PopBack());
                break;

            case "3":
                Console.Write("Enter index: ");
                int insIndex = int.Parse(Console.ReadLine());
                Console.Write("Enter value: ");
                int insVal = int.Parse(Console.ReadLine());
                vec.Insert(insIndex, insVal);
                break;

            case "4":
                Console.Write("Enter index: ");
                int eraseIndex = int.Parse(Console.ReadLine());
                vec.Erase(eraseIndex);
                break;

            case "5":
                Console.WriteLine("Empty? " + vec.IsEmpty());
                break;

            case "6":
                Console.Write("Enter index: ");
                int atIndex = int.Parse(Console.ReadLine());
                Console.WriteLine("Value: " + vec.At(atIndex));
                break;

            case "7":
                vec.Reverse();
                Console.WriteLine("Reversed!");
                break;

            case "8":
                vec.Clear();
                Console.WriteLine("Vector cleared!");
                break;

            case "9":
                Console.WriteLine("Vector: " + vec.ToString());
                break;

            case "0":
                running = false;
                break;

            default:
                Console.WriteLine("Unknown option!");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}

Console.WriteLine("Goodbye!");