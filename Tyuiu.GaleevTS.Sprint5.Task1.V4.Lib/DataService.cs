using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GaleevTS.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            if (fileExist)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((Math.Cos(x)) / (x + 1)) - Math.Cos(x) * 1.3 + 3 * x;
                y = Math.Round(y, 2);
                if (x == -1)
                {
                    strY = "0";
                }
                else
                {
                    strY = Convert.ToString(y);
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
