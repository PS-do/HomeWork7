using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void GetParamCube(double a, out double V, out double S)
        {
            V = a * a * a;
            S = a * a * 6;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("2.    Обязательная задача*.\n" +
                " Создать метод для вычисления объема и площади поверхности куба по длине его ребра.\n\n" +
                "Введите сторону куба А");
            double A = Convert.ToDouble(Console.ReadLine());
            double v, s;
            v = s = 0;
            GetParamCube(A, out v, out s);
            Console.WriteLine("\nОбъём куба:{0:f2}\n" +
                                "Площадь куба:{1:f2}", v, s);
            Console.ReadKey();
        }
    }
}
