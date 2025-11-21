// Виключення(виняткові ситації), Exeptions

// try, catch, finally, throw


//try
//{
//    Console.WriteLine("Before Exception");
//    throw new Exception("Test Exception");
//    Console.WriteLine("After Exception");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    Console.WriteLine("In finally block");
//}


//do
//{
//    try
//    {
//        int a = Convert.ToInt32(Console.ReadLine());

//        if (a < 50) throw new Exception("Out number should be bigger than 49");

//        int b = Convert.ToInt32(Console.ReadLine());

//        int res = a / b;

//        int[] arr = new int[5];

//        arr[10] = res;

//        Console.WriteLine($"Res: {res}");
//    }
//    catch (DivideByZeroException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//} while (true);


// Створення власних класів вийнятків


// Account
// Bank

//using _11_Exceptions;

//List<Account> accounts = new List<Account>()
//{
//    new Account()
//    {
//        Id = 1,
//        Name = "John",
//        Surname = "Smith",
//        Balance = 1000
//    },
//    new Account()
//    {
//        Id = 2,
//        Name = "Emily",
//        Surname = "Johnson",
//        Balance = 1500
//    },
//    new Account()
//    {
//        Id = 3,
//        Name = "Michael",
//        Surname = "Brown",
//        Balance = 800
//    },
//    new Account()
//    {
//        Id = 4,
//        Name = "Sarah",
//        Surname = "Miller",
//        Balance = 2200
//    },
//    new Account()
//    {
//        Id = 5,
//        Name = "David",
//        Surname = "Wilson",
//        Balance = 500
//    }
//};

//Bank bank = new Bank(accounts);

//Account account = new Account()
//{
//    Id = 100,
//    Name = "John",
//    Surname = "Smith",
//    Balance = 1000
//};

//try
//{
//    bank.Withdraw(account, 100);
//}
//catch (NotFoundAccountException ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.Account.Id);
//}



do
{
    try
    {
        int a = Convert.ToInt32(Console.ReadLine());
        char sign = Convert.ToChar(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int res;

        switch (sign)
        {
            case '+':
                res = a + b;
                break;
            case '-':
                res = a - b;
                break;
            case '*':
                res = a * b;
                break;
            case '/':
                res = a / b;
                break;
            default:
                throw new Exception("Invalid sign");
        }
        Console.WriteLine($"Res: {res}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch(OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
} while (true);