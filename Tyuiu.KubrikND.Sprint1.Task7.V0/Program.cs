using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint1.Task7.V0.Lib;

namespace Tyuiu.KubrikND.Sprint1.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Кубрик Н.Д.| ИСПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант 0                                                               *");
            Console.WriteLine("* Выполнил: Кубрик Н.Д.| ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая решает задачу по формуле   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x, y, z;
            Console.WriteLine("Введите значение Х");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение У");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Z");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y, z));
            Console.ReadKey();
        }
    }
}
