using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Account
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter username: ");
            string name = Console.ReadLine().ToString();
            Console.WriteLine("Please Enter Password: ");
            string password = Console.ReadLine().ToString();

            if (Account.IsPasswordValid(password) && Account.IsUserNameValid(name))
            {
                Account account = new Account(name, password);
                Console.WriteLine("Account Created");
            }
            else
            {
                Console.WriteLine("Username Or Password is not valid");
            }

            Console.ReadLine();
        }
    }
}
