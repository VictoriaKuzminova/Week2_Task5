using System;

namespace _1
{
    class Program
    {    
        static double f(double x)
        {
            try
            {
                if ((x <= -2)||(x>=2)) throw new Exception();
                else return Math.Log(4-Math.Pow(x,2));
            }
            catch
            {
                throw;
            }

        }
        static void Main(string[] args)
        {
            double a, b, h;
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Введите начало диапозона: ");
                        a = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Некорректный ввод!");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введите конец диапозона: ");
                        b = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Некорректный ввод!");
                    }
                }
                if (a > b)
                {
                    Console.WriteLine("Начальная точка диапазона не может быть больше конечной точки");
                    continue;
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Введите шаг: ");
                        h = double.Parse(Console.ReadLine());
                        if (h == 0)
                        {
                            Console.WriteLine("Шаг не может быть равен 0");
                            continue;

                        }
                        else if (h < 0)
                        {
                            Console.WriteLine("Шаг не может быть меньше 0");
                            continue;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Некорректный ввод!");
                    }
                }
                break;
            }
            for (double i = a; i <= b; i += h)
            {
                try
                {
                    Console.WriteLine("y({0:f2})={1:f2}", i, f(i));
                }
                catch
                {
                    Console.WriteLine("y({0:f2})= Не определен", i);
                }
            }
        }
    }
}



