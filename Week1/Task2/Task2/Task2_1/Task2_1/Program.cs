using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Bolat", "ID", 1);                      //по классу придал значение 
            s.Spectre();                                                    //создал функцию
        }
        class Student                                                       //создал новый класс 
        {
            string Name;
            string ID;
            int YoS;
            public Student(string Name, string ID, int YoS)                 //ввел в класс 
            {
                this.Name = Name;                                           //открыл доступ на значения
                this.ID = ID;
                this.YoS = YoS;
            }
            public void Spectre()                                           //по фушнкции год обучения увеличивается
            {
                YoS++;
                Console.WriteLine("Student: " + Name + " , ID: " + ID + " , Year of Study: " + YoS);     //и вывожу значения
            }
        }
    }
}
