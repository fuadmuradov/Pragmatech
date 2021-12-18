using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_with_picture
{
    public class Student
    {
        public string Name;
        public string Surname;
        public string Email;
        public string Picture;
        public int std_ID;
        public static int ID = 0;

        public Student(string name, string surname, string email, string picture)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Picture = picture;
            this.std_ID = ID;
            ID++;
            
        }


        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}
