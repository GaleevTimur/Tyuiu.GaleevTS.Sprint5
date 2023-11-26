using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.GaleevTS.Sprint5.Task5.V20.Lib;

namespace Tyuiu.GaleevTS.Sprint5.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №5 | Выполнил: Галеев Т. С. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                           *");
            Console.WriteLine("* Задание №5                                                               *");
            Console.WriteLine("* Вариант #20                                                              *");
            Console.WriteLine("* Выполнил: Галеев Тимур Серикович | ИИПб-23-3                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");
            string path = @"C:\Users\timur_8n182p8\source\repos\Tyuiu.GaleevTS.Sprint5\Tyuiu.GaleevTS.Sprint5.Task5.V20\bin\Debug\InPutDataFileTask5V20.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение чисел в промежутке от -10 до 10 в файле" + res);
            Console.ReadKey();
        }
    }
}
