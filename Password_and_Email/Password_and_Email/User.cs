using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Password_and_Email
{
    class User : Account
    {
        public string FullName;
        public string email { get; set; }

        private string Password;

        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    this.Password = value;
                }
                else
                {
                    Console.WriteLine("Password is not valid");
                }

            }
        }

        public User(string fullname, string email)
        {
            this.FullName = fullname;
            try
            {
                MailAddress mailAdress = new MailAddress(email);
                this.email = email;
            }
            catch (Exception)
            {
                Console.WriteLine("Email is not VALID...");
            }

        }
        public override bool PasswordChecker(string password)
        {
            bool letUpper = false, letLower = false; 
            if (password.Length < 8) return false;
            else
            {
                foreach (char item in password)
                {
                    if (Char.IsUpper(item)) letUpper = true;
                    if (Char.IsLower(item)) letLower = true;
                }
            }

            if (letLower==true && letUpper==true) { this.Password = password;  return true;} 
            else
            return false;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Fullname: {FullName}; Email: {email}");
        }
    }
}
