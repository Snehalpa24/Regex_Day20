using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDay19
{
    class UserInfo
    {
        //UC1
        public static string FirstName = "^[A-Z][a-z]{3,}$";

        public bool validateFirstName(string Fname)
        {
            return Regex.IsMatch(Fname, FirstName);
        }

        //UC2
        public static string LastName = "^[A-Z][a-z]{3,}$";

        public bool validateLastName(string Lname)
        {
            return Regex.IsMatch(Lname, FirstName);
        }

        //UC3 
        public static string Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

        public bool validateEmail(string mail)
        {
            return Regex.IsMatch(mail, Email);
        }

        //UC4
        public static string Number = "^[91][0-9]{10}";

        public bool validateNumber(string num)
        {
            return Regex.IsMatch(num, Number);
        }
   }
}
