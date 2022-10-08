using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Басикукле
{
    internal class Mercedes : Car
    {
        public Mercedes()
        {
            _enginePower = 400;
            _mark = "Mercedes";
            _speed = 267;
            _year = 2018;
            _price = 2000000;
        }

        public override void Ride()
        {
            Console.WriteLine($"Завести машину");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            if (b == 1)
            {
                Console.WriteLine($"Машина заведена. Чтобы начать двежение введите 1");
                string r = Console.ReadLine();
                int rid = int.Parse(r);
                if (rid == 1)
                {
                    Console.WriteLine($"Автомобиль едет");
                    Console.WriteLine($"\t");
                    Console.WriteLine($"Чтобы сделать остановку введите и заглушить двигатель 1");
                    string s = Console.ReadLine();
                    int stop = int.Parse(r);
                    if (rid == 1)
                    {
                        Console.WriteLine($"машина остановлена");
                        Console.WriteLine("\t");
                        Console.WriteLine($"Завершить поездку 1. Продолжить поездку введите 2");
                        string ri = Console.ReadLine();
                        int ride = int.Parse(r);
                        if (ride == 1)
                        {
                            Console.WriteLine($"Досвидания");
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
    }
}
