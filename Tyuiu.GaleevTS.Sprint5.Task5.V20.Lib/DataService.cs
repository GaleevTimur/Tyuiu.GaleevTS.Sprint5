using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GaleevTS.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double x = Convert.ToDouble(line);
                    if (x >= -10)
                    {
                        if (x <= 10)
                        {
                            count++;
                            res = res + Convert.ToDouble(line);
                        }
                    }


                }
            }
            res = res / count;
            return Math.Round(res, 3);
        }
    }
}
