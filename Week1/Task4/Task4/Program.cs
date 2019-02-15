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
            for(int i = 1;i <= n; i++) {                           // than add array a[i] than it run to size n
                int t = i;                                         // than we add integer t and equate to i
                while(t != 0)                                      // while int t don't equal to 0 we add [*]
                {
                    Console.Write("[*]");                          // and t is decrised while t don't equal 0
                    t--;
                }
                Console.WriteLine();                               // here we add endline
            }
        }
    }
}
