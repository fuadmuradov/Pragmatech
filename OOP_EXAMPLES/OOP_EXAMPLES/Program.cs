using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXAMPLES
{
    class Program
    {
        static void Main(string[] args)
        {
            //double radius = 2.5;
            //double height = 3.0;
            //var ring = new Circle(radius);

            //Console.WriteLine($"Circle Area {ring.Area():F2}");

            //var cyln = new Cylnder(radius, height);
            //Console.WriteLine($"Cylender Area {cyln.Area():F2}");


            //Console.WriteLine("************************************");
            //DateTime centuryBegin = new DateTime(2020, 1, 1);
            //DateTime currentDate = DateTime.Now;

            //long elapsedTicks = currentDate.Ticks - centuryBegin.Ticks;
            //TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);

            //Console.WriteLine("Elapsed from the beginning of the century to {0:f}:",
            //                   currentDate);
            //Console.WriteLine("   {0:N0} nanoseconds", elapsedTicks * 100);
            //Console.WriteLine("   {0:N0} ticks", elapsedTicks);
            //Console.WriteLine("   {0:N2} seconds", elapsedSpan.TotalSeconds);
            //Console.WriteLine("   {0:N2} minutes", elapsedSpan.TotalMinutes);
            //Console.WriteLine("   {0:N0} days, {1} hours, {2} minutes, {3} seconds",
            //                  elapsedSpan.Days, elapsedSpan.Hours,
            //                  elapsedSpan.Minutes, elapsedSpan.Seconds);


            //List<Student> stdlist = new List<Student>();
            //Student[] stdarr = new Student[2];
            //Student student1 = new Student("Fuad Muradov", "CH105", 21);
            //stdlist.Add(student1);
            //stdarr[0] = student1;
            //Student student2 = new Student("Murad Muradov", "CH202", 25);
            //stdlist.Add(student2);
            //stdarr[1] = student2;
            //Console.WriteLine(stdlist[0].getBirthYear()+ " " + stdlist[1].getBirthYear());
            //Console.WriteLine(stdarr[0].getBirthYear() + " " + stdarr[1].getBirthYear());
            //string group = "CH105";
            //Student stdd = stdlist.Find(x => x.GroupNo == group);
            //Console.WriteLine(stdd.Fullname + " " + stdd.getBirthYear() + " " + stdd.Age);

            //Console.WriteLine(stdarr.Count(x => x.GroupNo == group));

            //Console.WriteLine(stdlist.Count(x => x.GroupNo == group));



            Console.Read();

        }

        public static int Counter(string group, Student[] std)
        {
            int counter = 0;
            foreach (var item in std)
            {
                if(item.GroupNo==group)
                counter++;
            }

            return counter;
        }


         public class Student
        {
            public string Fullname;
            public string GroupNo;
            public int Age;
            public Student(string name, string group, int age)
            {
                this.Fullname = name;
                this.GroupNo = group;
                this.Age = age;
            }

            public int getBirthYear()
            {
                return DateTime.Now.Year - Age;
            }

        }

        abstract class Shape
        {
            public double pi = Math.PI;
            protected double x, y;
            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public abstract double Area();

        }

        class Circle : Shape
        {
            public Circle(double radius) : base(radius,0)
            {
            }
            public override double Area() => (pi * x * x);
            
        }

       class Cylnder : Circle
        {
            public Cylnder(double radius, double height) : base(radius)
            {
                y = height;
            }

           // public override double Area() => (2 * base.Area() + (2 * pi * x * y));

            public override double Area()
            {
                return (2 * (pi * x * x) + (2 * pi * x * y));
            }
           
        }


    }
}
