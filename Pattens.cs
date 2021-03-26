using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Pattens
    {
        public static string Regex_Name = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_Email = "^[a-z0-9A-Z]+([.,~!@#$%&*][a-z0-9A-Z]+)*@([a-z0-9A-Z]+).([a-zA-Z]{2,5})(.[a-zA-Z]{2})*$";
        public static string Regex_Number = "^91[6-9][0-9]{9}$";
        public static string Regex_Password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";
        public bool ToCheckName(string name)
        {
            return Regex.IsMatch(name, Regex_Name);
        }
        public bool ToCheckLastName(string lastname)
        {
            return Regex.IsMatch(lastname, Regex_LastName);
        }
       public bool ToCheckMail(string mail)
        {
            return Regex.IsMatch(mail, Regex_Email);
        }
        public bool ToCheckNumber(string number)
        {
            return Regex.IsMatch(number, Regex_Number);
        }
        public bool ToCheckPassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }

    }
}
