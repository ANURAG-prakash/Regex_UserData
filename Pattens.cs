using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Pattens
    {
        public static string Regex_Name = "^[A-Z]{1}[a-z]{2,}$";
        public bool ToCheckName(string name)
        {
            return Regex.IsMatch(name, Regex_Name);
        }
    }
}
