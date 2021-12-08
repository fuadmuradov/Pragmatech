using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_GetBirthDay
{
    class Student
    {
        public string Fullname;
        public int GroupNo;
        public int Age;
        
       public Student(string Fullname, int GroupNo, int Age)
        {
            this.Fullname = Fullname;
            this.GroupNo = GroupNo;
            this.Age = Age;
        }

    }
}
