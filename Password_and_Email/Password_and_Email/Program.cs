using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_and_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Fuad Muradov", "fuadmuradov@gmail.com");
            user.password = "12345aA678";
            Console.WriteLine(user.password);
            user.ShowInfo();




            Console.ReadLine();
        }
    }
}
