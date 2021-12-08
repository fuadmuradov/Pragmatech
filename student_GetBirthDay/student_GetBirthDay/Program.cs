using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_GetBirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            for (int i = 0; i < students.Length; i++)
            {
                string name = Console.ReadLine();
                int groupNo = Convert.ToInt32(Console.ReadLine());
                int Age = Convert.ToInt32(Console.ReadLine());

                Student student = new Student(name, groupNo, Age);
                students[i] = student;

                Console.WriteLine($"telebenin Dogum tarixi: {getBirthYear(Age)}");

            }

            distinctgroup(students);

            int groupnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + groupnumber + $" nomreli grupun telebe sayi: {SumOfParticipants(groupnumber,students)}");

            Console.ReadLine();
        }

        public static int getBirthYear(int age)
        {
            return Convert.ToInt32(DateTime.Now.Year) - age;
        }

        public static void distinctgroup(Student[] students)
        {
            List<int> distinct = new List<int>();
            int converted;
            foreach (var item in students)
            {
                   converted = Convert.ToInt32(item.GroupNo);
                if (!distinct.Contains(converted))
                {
                    distinct.Add(converted);
                }
                else continue;
               
              
            }

          
            Console.WriteLine("\n" + "asagidaki telebe nomrelerinden birini secin!!!");
            foreach (var item in distinct)
            {
                Console.WriteLine(item);
            }
        }
        public static int SumOfParticipants(int num, Student[] students)
        {
            int sum = 0;
            foreach (var item in students)
            {
                if (Convert.ToInt32(item.GroupNo) == num) sum++;
            }

            return sum;
        }
    }
}
