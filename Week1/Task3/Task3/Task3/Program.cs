using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());              //создаем переменную n
            string s = Console.ReadLine();
            string[] a = s.Split();                             //эелементы строки делаю через пробелы
            for(int i = 0;i < n; i++)                           
            {
                Console.Write(a[i] + " " + a[i] + " ");         //вывожу дважды элементы
            }
        }
    }
}
