using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_8
{
    public class User : IAccount
    {
        public User(string? fullname, string? email, string password)
        {
            Fullname = fullname;
            Email = email;
            Password = password;
        }

        public string? Fullname { get; set; }



        private string? _email;

        public string? Email
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _email = value;
                else Console.WriteLine("Email Cannot be empty");
            }
        }


        private string? _password;

        public string? Password
        {
            get { return _password; }
            set
            {
                if (PasswordChecker(value!))
                {
                    _password = value;
                }
                else Console.WriteLine("Password is not valid");
            }
        }

        public void ShowInfo()
        {
            if (Email is not null && Password is not null)
                Console.WriteLine($"Fullname:{Fullname}\nEmail:{Email}");
        }

        public bool PasswordChecker(string password) =>
            password.Length >= 8 && password.Any(char.IsDigit) && password.Any(char.IsUpper) && password.Any(char.IsLower);
    }
}
