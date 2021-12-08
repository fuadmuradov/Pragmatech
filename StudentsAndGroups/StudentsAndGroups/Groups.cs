using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndGroups
{
    class Groups
    {


        public string GroupName;
        private int capacity;
        public static int no = 101;
        public int group_id;
        public Groups(string Name, int Capacity)
        {
            this.GroupName = Name;
            this.capacity = Capacity;
            this.group_id = no;
            no++;
        }

        public int Capacity{
            get{
                return capacity;
            }
        }
    }
}
