using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Басикукле
{
    internal class Porsche : Car
    {
        public Porsche()
        {
            _enginePower = 340;
            _mark = "Posche";
            _speed = 360;
            _year = 2020;
            _price = 5000000;
        }

        public override void Ride()
        {
            Console.WriteLine($"Завести машину");
            Console.WriteLine();
            string a = Console.ReadLine();
            int b = int.Parse(a);
            if (b == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"Машина заведена. Чтобы начать двежение введите 1");
                Console.WriteLine();
                string r = Console.ReadLine();
                int rid = int.Parse(r);
                if (rid == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Автомобиль едет");
                    Console.WriteLine($"\t");
                    Console.WriteLine($"Чтобы сделать остановку введите и заглушить двигатель 1");
                    Console.WriteLine();
                    string s = Console.ReadLine();
                    int stop = int.Parse(r);
                    if (rid == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"машина остановлена");
                        Console.WriteLine("\t");
                        Console.WriteLine($"Завершить поездку 1. Продолжить поездку введите 2");
                        Console.WriteLine();
                        string ri = Console.ReadLine();
                        int ride = int.Parse(r);
                        if (ride == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Досвидания");
                            Console.WriteLine();
                        }
                        else if (ride == 2)
                        {
                            Ride();
                        }
                    }
                }
            }
        }

        public override void GetInformation()
        {
            Console.WriteLine($"Цена: {_price}");
            Console.WriteLine($"Марка: {_mark}");
            Console.WriteLine($"Мощность двигателя: {_enginePower}");
            Console.WriteLine($"Скорость: {_speed}");
            Console.WriteLine($"Год выпуска: {_year}");
        }

        public override void Upgrade()
        {
            _enginePower = _enginePower + 20;
            _speed = _speed + 15;
            _price = _price + 50000;
        }
        public override int GetPrice()
        {
            return _price;
        }
    }
}
