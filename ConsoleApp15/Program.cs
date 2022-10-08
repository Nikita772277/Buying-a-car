using Басикукле;

User user = new User(1000000);
void GetMenu()
{
    Console.WriteLine("1. Купить автомобиль");
    Console.WriteLine("2. Апгрейд автомобиля");
    Console.WriteLine("3. Информация об автомобиле");
    Console.WriteLine("\t");
}
void FuncMenu()
{
    string a = Console.ReadLine();
    int b = int.Parse(a);
    Console.WriteLine("\t");

    if (b == 1)
    {
        user.BuyAuto();
    }
    if (b == 2)
    {
        user.UpgradeAuto();
    }
    if (b == 3)
    {
        user.GetInformation();
    }
}

while (true)
{
    GetMenu();
    FuncMenu();
}