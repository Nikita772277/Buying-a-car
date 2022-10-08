using Басикукле;

User user = new User(1000000);
void GetMenu()
{
    Console.WriteLine("1. Купить автомобиль");
    Console.WriteLine("2. Апгрейд автомобиля");
    Console.WriteLine("3. Информация об автомобиле");
    Console.WriteLine("4. денег");
    Console.WriteLine("5. ехать");
    Console.WriteLine("\t");
}
void FuncMenu()
{
    while (true)
    {

        GetMenu();
        string a = Console.ReadLine();
        int b = int.Parse(a);
        Console.WriteLine("\t");

        if (b == 1)
        {
            user.BuyAuto();
        }
        else if (b == 2)
        {
            user.UpgradeAuto();
        }
        else if (b == 3)
        {
            user.GetInformation();
        }
        else if (b == 4)
        {
            user.GetMoney();
        }
        else if (b == 5)
        {
            if (user.ControlLada() == true)
            {
                user.Ride();
            }
            else if (user.ControlBMW() == true)
            {
                user.Ride();
            }
            else if (user.ControlMercedes() == true)
            {
                user.Ride();
            }
            else if (user.ControlPorche() == true)
            {
                user.Ride();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("нет авто");
            }
        }
        else
        {
            Console.WriteLine($"нет такой команды");
        }
    }
}
FuncMenu();