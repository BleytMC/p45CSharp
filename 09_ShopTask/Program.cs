using _09_ShopTask;

Shop shop = new Shop(new Laptop[]
{
    new Laptop("Lenovo", 2000.0),
    new Laptop("HP", 1850.0),
    new Laptop("Dell", 2100.0),
    new Laptop("Asus", 1750.0),
    new Laptop("Acer", 1600.0),
    new Laptop("Apple", 3200.0),
    new Laptop("MSI", 2500.0),
    new Laptop("Samsung", 1900.0),
    new Laptop("Razer", 2800.0),
    new Laptop("Huawei", 1700.0)
});

Console.WriteLine(shop);

Console.WriteLine();

Console.WriteLine(shop[3]);