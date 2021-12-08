using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Account
{
    class Account
    {
        public string name;
        public string password;
        public static int No=0;

        public Account(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public static bool IsUserNameValid(string validname)
        {
            foreach (char c in validname)
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }

            return true;
        }

        public static bool IsPasswordValid(string validname)
        {
            bool symbol = false, uplatter = false, digit = false; 

            if (validname.Length >= 8 && validname.Length <= 25)
            {
                foreach (char c in validname)
                {
                    if (Char.IsDigit(c)) digit = true;
                    if (Char.IsSymbol(c)) symbol = true;
                    if (Char.IsUpper(c)) uplatter = true;
                       
                  
                }

             
            }
            else return false;

            if (symbol == true && uplatter == true && digit == true) return true;
            else
            return false;
        }

    }
}
