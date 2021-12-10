using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_delete_update
{
    class Students
    {
        public string Student_name;
        public string Student_surname;
        public int Student_id;
        public string Student_group;
        public int Student_Group_id;
        public static int id = 0;

        public Students()
        {
            Student_id = id;
            id++;
        }
    }
}
