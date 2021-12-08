using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGroups
{
    class Students
    {
        public string Name;
        public string Surname;
        public static int no = 1;
        public int student_id;
        public Students(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.student_id = no;
            no++;
        }


    }
}
