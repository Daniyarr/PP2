using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                             //Создал переменную n
            string[] a = (Console.ReadLine()).Split();                         //и сощдал стринг чтоб содержать все числа массива
            int cnt1 = 0;                                                      //создал переменную которая считывает простые количество 
            List<int> b = new List<int>();                                     //и создал новый вектор которых я буду добавлять все простые числа
            for (int i = 0;i < n; i++)                                         //массив который пробегается по данному циклу
            {
                int cnt = 0;                                                   //новая переменная которая считает делители чисел
                int x = int.Parse(a[i]);
                for(int j = 1;j <= x; j++)                                     //этот массив пробегается до данных чисел
                {
                    if (x % j == 0)                                            //здесь мы считаем делаители
                    {
                        cnt++;                                                 //и если условия выполнены то прибавляем к этой переменной
                    }
                }
                if (cnt == 2)                                                  //если количество делителей составляет 2

#endif
                {
                    b.Add(x);                                                  //то мы их добавляем в вектор b
                    cnt1++;                                                    //и прибавляем их к переменной которое считывает количество простых чисел
                }
            }
            Console.WriteLine(cnt1);                                           //тут мы сперва выводим количество простых чисел делаем endline
            for(int i=0; i<b.Count; i++)                                       //и пробегаемся по размеру вектора
            {
                Console.Write(b[i] + " ");                                     //и выводим все числа вектора через пробел
            }
        }
    }
}
