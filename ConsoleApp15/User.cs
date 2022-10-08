using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Басикукле
{
    internal class User
    {
        private int _money;
        private string _car;
        public User(int money)
        {
            _money = money;
        }
        Car lada = new Lada();
        Car BMW = new BMW();
        Car porsche = new Porsche();
        Car mercedes = new Mercedes();
        public void BuyAuto()
        {
            void Confirmation()
            {
                Console.WriteLine($"Хотите ли вы купить данный автомобиль 1) да 2)нет");
                string b = Console.ReadLine();
                int confirmation = int.Parse(b);
                if (confirmation == 1)
                {
                    //if (_money<)
                    Console.WriteLine($"Вы приобрели авто");
                }
                else if (confirmation == 2)
                {
                    BuyAuto();
                }
            }
            Console.WriteLine($"Выберите марку авто 1) Lada 2) BMV 3) Porsche 4) Mercedes");
            string a = Console.ReadLine();
            int choice = int.Parse(a);
            Console.WriteLine("\t");
            if (choice == 1)
            {
                Console.WriteLine($"Информация об авто: {lada.GetInformation}");
                Console.WriteLine("\t");
                Confirmation();
            }
            else if (choice == 2)
            {
                Console.WriteLine($"Информация об авто: {BMW.GetInformation}");
                Console.WriteLine("\t");
                Confirmation();
            }
            else if (choice == 3)
            {
                Console.WriteLine($"Информация об авто: {porsche.GetInformation}");
                Console.WriteLine("\t");
                Confirmation();
            }
            else if (choice == 4)
            {
                Console.WriteLine($"Информация об авто: {mercedes.GetInformation}");
                Console.WriteLine("\t");
                Confirmation();
            }
        }
        public void UpgradeAuto()
        {
            Console.WriteLine($"Выберите авто которое хотите улучшить: 1) Lada 2) BMV 3) Porsche 4) Mercedes");
            string b = Console.ReadLine();
            int choice = int.Parse(b);
            Console.WriteLine("\t");
            if (choice == 1)
            {
                lada.Upgrade();
                Console.WriteLine("\t");
            }
            else if (choice == 2)
            {
                BMW.Upgrade();
                Console.WriteLine("\t");
            }
            else if (choice == 3)
            {
                porsche.Upgrade();
                Console.WriteLine("\t");
            }
            else if (choice == 4)
            {
                mercedes.Upgrade();
                Console.WriteLine("\t");
            }
        }
        public void GetInformation()
        {
            Console.WriteLine($"Выберите авто о котором хотите получить информацию: 1) Lada 2) BMV 3) Porsche 4) Mercedes");
            string b = Console.ReadLine();
            int choice = int.Parse(b);
            Console.WriteLine("\t");
            if (choice == 1)
            {
                lada.GetInformation();
                Console.WriteLine("\t");
            }
            else if (choice == 2)
            {
                BMW.GetInformation();
                Console.WriteLine("\t");
            }
            else if (choice == 3)
            {
                porsche.GetInformation();
                Console.WriteLine("\t");
            }
            else if (choice == 4)
            {
                mercedes.GetInformation();
                Console.WriteLine("\t");
            }

        }
    }
}