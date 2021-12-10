using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_delete_update
{
    class Groups
    {
        public string Group_name;
        public int group_id;
        public static int id = 0;

        public Groups()
        {
            group_id = id;
            id++;
        }

        public override string ToString()
        {
            return Group_name;
        }
    }
}
