using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GaleevTS.Sprint5.Task4.V30.Lib;
using System.IO;

namespace Tyuiu.GaleevTS.Sprint5.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №5 | Выполнил: Галеев Т. С. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                  *");
            Console.WriteLine("* Задание №4                                                               *");
            Console.WriteLine("* Вариант #30                                                              *");
            Console.WriteLine("* Выполнил: Галеев Тимур Серикович | ИИПб-23-3                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("****************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V30.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
