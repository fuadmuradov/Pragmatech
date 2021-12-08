using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students("Fuad", "Muradov");

            Groups groups = new Groups("Technition", 3);
            Groups groups1 = new Groups("Front-End", 1);
            Groups groups2 = new Groups("Back-End", 4);
            Groups groups3 = new Groups("Help-Desc", 2);


            Manager manager = new Manager();
            manager.GroupAdd(groups);
            manager.GroupAdd(groups1);
            manager.GroupAdd(groups2);
            manager.GroupAdd(groups3);
            manager.StudentAdd(students);
            manager.ShowGroups();

            Console.ReadLine();
        }
    }
}
