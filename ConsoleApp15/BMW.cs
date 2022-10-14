using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Басикукле
{
    internal class BMW : Car
    {
        public BMW()
        {
            _enginePower = 200;
            _mark = "BMW";
            _speed = 300;
            _year = 2012;
            _price = 555000;
        }

        public override void Ride()
        {
            while (true)
            {
                bool chec1 = false;
                bool chec2 = false;
                bool chec3 = false;
                bool chec4 = false;
                Console.WriteLine();
                Console.WriteLine($"1. Завести машину");
                Console.WriteLine($"2. Начать двежение");
                Console.WriteLine($"3. Сделать остановку и заглушить двигатель");
                Console.WriteLine($"4. Завершить поездку");
                Console.WriteLine();
                string a = Console.ReadLine();
                bool c = int.TryParse(a, out var b);
                if (b == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Машина заведена");
                    Console.WriteLine();
                    chec1 = true;
                    chec4 = true;
                }
                else if (b == 2)
                {
                    if (chec1 == true)
                    {

                        Console.WriteLine($"Машина едет");
                        Console.WriteLine($"\t");
                        chec2 = true;
                        chec1 = false;
                    }
                    else
                    {
                        Console.WriteLine($"Сначала заведите машину");
                        Console.WriteLine();
                    }
                }

                else if (b == 3)
                {
                    if (chec2 == true)
                    {

                        Console.WriteLine($"Машина остановлена и заглушена");
                        Console.WriteLine();
                        chec3 = true;
                        chec2 = false;
                    }
                    else
                    {
                        Console.WriteLine($"Ваша машина не начала движение");
                        Console.WriteLine();
                    }
                }
                else if (4 == b)
                {
                    if (chec3 == true)
                    {
                        Console.WriteLine($"Вы завершили поездку");
                        Console.WriteLine();
                        break;
                    }
                    else if (chec4 == false)
                    {
                        Console.WriteLine($"Вы завершили поездку");
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Сначала остановите машину");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine($"Выберете команду из списка");
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