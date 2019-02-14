using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();          //создаю новую строку
            for (int i = 0;i < s.Length; i++)       //пробегаюсь по массиву
            {
                if(s[i] != s[s.Length - 1 - i])     //проверяю строку на полиндромность
                {
                    Console.WriteLine("No");        
                    break;
                }
            
            }
            Console.WriteLine("Yes");               //если проходит проверку то вывожу YES
        }
    }
}
