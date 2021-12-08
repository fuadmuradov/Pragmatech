using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_management
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = { 2, 3, 4, 5, 6, 7, 8, 9 };
            //useParam(num);
            Student[] students = new Student[2];
           
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Telebe adini daxil edin!");
                String name = Console.ReadLine();

                Console.WriteLine("Telebenin balini daxil edin!");
                double point = Convert.ToDouble(Console.ReadLine());

                Student student = new Student(name, point);


                students[i] = student;


            }


          Console.WriteLine($"telebelerin ortalamasi {average(students)}");

            //ArrayList arraylist = new ArrayList();
            //arraylist.Add("fuad");
            //arraylist.Add(5);
            //arraylist.Add(true);

            //foreach (var item in arraylist)
            //{
            //    Console.WriteLine($"arraylistin elementleri {item}");
            //}

            Console.ReadLine();
        }

        public static double average(Student[] students)
        {
            double sum = 0;
            foreach (var item in students)
            {
                sum = sum + item.Point;
            }
            return sum / students.Length;
        }

        //public static int useParam(int[] list)
        //{
        //    foreach(var item in list)
        //    {
        //        Console.WriteLine(item);
        //    }


        //    return 0;
        //}
    }
}
