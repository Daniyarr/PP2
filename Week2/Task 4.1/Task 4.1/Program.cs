using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = @"C:\Users\Professional\Desktop\c#\PP2\";  //я указываю путь 
            string s2 = "Task1.txt";    //указываю файл
            string s3 = Path.Combine(s, s2);    //скомбинировал в путь папки файл
            FileStream fs = File.Create(s3);    //создал файл внутри папки
            fs.Close(); //закрыл файл
            string o_path = @"C:\Users\Professional\Desktop\c#\PP2\Task1.txt";      //задаю путь файла
            string v_path = @"C:\Users\Professional\Desktop\c#\PP2\Week1\ConsoleApp1";  //задаю путь папки
            string s1 = Path.Combine(v_path, s2);    //скомбинировал путь папки и файл 
            File.Copy(o_path, s1, true);     //скопировал файл на другой путь
            File.Delete(@"C:\Users\Professional\Desktop\c#\PP2\Task1.txt"); 01//и удаляем после копирование с начального путя файл
        }
    }
}
