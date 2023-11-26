using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GaleevTS.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V30.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                            line = line.Replace("4", "9");
                            line = line.Replace("5", "9");
                            line = line.Replace("6", "9");
                    }
                    line = line.Replace("39", "34");
                    File.AppendAllText(pathSaveFile, line + Environment.NewLine);
                }
                
            }
            return pathSaveFile;

        }
    }
}
