using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Басикукле
{
    internal class User
    {
        private decimal _money;
        private string _car;
        private bool _lada;
        private bool _BMW;
        private bool _mercedes;
        private bool _porche;
        private bool _chec = false;

        public User()
        {
            _lada = false;
        }
        Car lada = new Lada();
        Car BMW = new BMW();
        Car porsche = new Porsche();
        Car mercedes = new Mercedes();
        public void BuyAuto()
        {
            Console.WriteLine($"Выберите марку авто 1) Lada 2) BMV 3) Porsche 4) Mercedes");
            Console.WriteLine("\t");
            string a = Console.ReadLine();
            int choice = int.Parse(a);
            _lada = false;
            if (choice == 1)
            {
                lada.GetInformation();
                Console.WriteLine("\t");
                Console.WriteLine($"Хотите ли вы купить данный автомобиль 1) да 2)нет");
                Console.WriteLine();
                Console.WriteLine();
                string b = Console.ReadLine();
                int confirmation = int.Parse(b);
                if (confirmation == 1)
                {
                    if (_money > lada.GetPrice())
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Вы приобрели авто");
                        Console.WriteLine();
                        _money = _money - lada.GetPrice();
                        _lada = true;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"У вас недостаточно средств");
                        Console.WriteLine();
                        BuyAuto();
                        _lada = false;
                    }
                }
                else if (confirmation == 2)
                {
                    BuyAuto();
                }
            }
            else if (choice == 2)
            {
                BMW.GetInformation();
                Console.WriteLine("\t");
                Console.WriteLine($"Хотите ли вы купить данный автомобиль 1) да 2)нет");
                Console.WriteLine();
                string b = Console.ReadLine();
                int confirmation = int.Parse(b);
                if (confirmation == 1)
                {
                    if (_money > BMW.GetPrice())
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Вы приобрели авто");
                        Console.WriteLine();
                        _money = _money - BMW.GetPrice();
                        _BMW = true;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"У вас недостаточно средств");
                        Console.WriteLine();
                        _BMW = false;
                        BuyAuto();
                    }
                }
                else if (confirmation == 2)
                {
                    BuyAuto();
                }
            }
            else if (choice == 3)
            {
                porsche.GetInformation();
                Console.WriteLine("\t");
                Console.WriteLine($"Хотите ли вы купить данный автомобиль 1) да 2)нет");
                Console.WriteLine();
                string b = Console.ReadLine();
                int confirmation = int.Parse(b);
                if (confirmation == 1)
                {
                    if (_money > mercedes.GetPrice())
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Вы приобрели авто");
                        Console.WriteLine();
                        _money = _money - mercedes.GetPrice();
                        _mercedes = true;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"У вас недостаточно средств");
                        Console.WriteLine();
                        _mercedes = false;
                        BuyAuto();
                    }
                }
                else if (confirmation == 2)
                {
                    BuyAuto();
                }
            }
            else if (choice == 4)
            {
                mercedes.GetInformation();
                Console.WriteLine("\t");
                Console.WriteLine($"Хотите ли вы купить данный автомобиль 1) да 2)нет");
                Console.WriteLine();
                string b = Console.ReadLine();
                int confirmation = int.Parse(b);
                if (confirmation == 1)
                {
                    if (_money > porsche.GetPrice())
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Вы приобрели авто");
                        _money = _money - porsche.GetPrice();
                        _porche = true;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"У вас недостаточно средств");
                        Console.WriteLine();
                        _porche = false;
                        BuyAuto();
                    }
                }
                else if (confirmation == 2)
                {
                    BuyAuto();
                }
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
        public void SetMoney()
        {
            string mone = Console.ReadLine();
            bool money = decimal.TryParse(mone, out var a);
            _money = a;
        }
        public void GetMoney()
        {
            Console.WriteLine($"У вас осталось: {_money}");


        }
        public void Ride()
        {
            Console.WriteLine($"на каком авто вы хотите поехать 1) Lada 2) BMV 3) Porsche 4) Mercedes");
            string choic = Console.ReadLine();
            short choice = short.Parse(choic);
            Console.WriteLine();
            if (choice == 1)
            {
                if (ControlLada() == true)
                {
                    lada.Ride();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("нет авто");
                }
            }
            else if (choice == 2)
            {
                if (ControlBMW() == true)
                {
                    BMW.Ride();
                }
                else
                {
                    Console.WriteLine("нет авто");
                }
            }
            else if (choice == 3)
            {
                if (ControlMercedes() == true)
                {
                    mercedes.Ride();
                }
                else
                {
                    Console.WriteLine("нет авто");
                }
            }
            else if (choice == 4)
            {
                if (ControlPorche() == true)
                {
                    porsche.Ride();
                }
                else
                {
                    Console.WriteLine("нет авто");
                }
            }
        }
        public bool ControlLada()
        {
            return _lada;
        }
        public bool ControlBMW()
        {
            return _BMW;
        }
        public bool ControlMercedes()
        {
            return _mercedes;
        }
        public bool ControlPorche()
        {
            return _porche;
        }
    }
}