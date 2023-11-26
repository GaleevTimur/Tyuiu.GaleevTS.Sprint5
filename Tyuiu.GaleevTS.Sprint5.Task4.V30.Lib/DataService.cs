using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.GaleevTS.Sprint5.Task4.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);
            double res = Math.Round((Math.Pow(x, 3) - Math.Tan(x)) + 2.03 * x, 3);
            return res;
        }
    }
}
