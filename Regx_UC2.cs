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
    }
}
