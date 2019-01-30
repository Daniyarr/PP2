using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                 // we change string to char than char to integer
            for(int i = 1;i <= n; i++)                             //than we 
            {
                int t = i;
                while(t != 0)
                {
                    Console.Write("[*]");
                    t--;
                }
                Console.WriteLine();
            }
        }
    }
}
