using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool isPrime(int x)           //я создал функцию IsPrime
        {
            if (x == 2 || x == 3)                   //числа 2 и 3 не ходят в мой цикл и они считаются прайм чилсами  
            {
                return true;                        //из за этогог их считываю к прайм числам
            }
            if (x <= 1)                             //если числа меньше 1 не считаются
            {
                return false;
            }
            for (int i = 2; i * i <= x; i++)        //я пробегаюсь по циклу которая проверяет число х на уникальность
            {
                if (x % i == 0)                     //если он делится на число i 
                {
                    return false;                   //число не считывается
                }
            }
            return true;                            //если проходит проверку то считывается
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Input.txt");    //создаю файл на который ввожу числа
            string[] s = sr.ReadToEnd().Split(' '); //12345 создаю строку которая читает до конца введенных чисел 
            StreamWriter sw = new StreamWriter("Output.txt");   //созжаю файл на котором будет вывод
            for (int i = 0; i < s.Length; i++)                  //пробегаюсь по циклу
            {
                int x = int.Parse(s[i]);                        //строку перевлжу в integer x                
                if (isPrime(x) == true)                         //проверяю данные числа на уникальноость по функции 
                {
                    sw.Write(x + " ");                          //если проходит проверку то вывожу на файл вывода через пробел
                }
            }
            sr.Close();                                         //и закрываю файл ввода
            sw.Close();                                         //и вывода
        }
    }
}
