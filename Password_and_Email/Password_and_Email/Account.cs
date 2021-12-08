using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_and_Email
{
    public abstract class Account
    {
        public abstract bool PasswordChecker(string password);
        public virtual void ShowInfo()
        {
            Console.WriteLine("sadvasfd");
        }
            
    }
}
