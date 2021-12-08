using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGroups
{
    class Manager
    {
        private readonly List<Students> Student = new List<Students>();
        private List<Groups> Group = new List<Groups>();

        public void StudentAdd(Students student)
        {
            Student.Add(student);
        }
        public void GroupAdd(Groups group)
        {
            Group.Add(group);
        }

        public void ShowStudent()
        {
            foreach (Students item in Student)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " " + item.student_id);
            }
        }

        public void ShowGroups()
        {
            foreach (Groups item in Group)
            {
                Console.WriteLine(item.GroupName + " " + item.Capacity + " " + item.group_id);
            }
        }
    }
}
