using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GaleevTS.Sprint5.Task1.V4.Lib;

namespace Tyuiu.GaleevTS.Sprint5.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт №5 | Выполнил: Галеев Т. С. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                  *");
            Console.WriteLine("* Задание №1                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Галеев Тимур Серикович | ИИПб-23-3                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл:" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
