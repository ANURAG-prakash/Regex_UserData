using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattens name = new Pattens();
            Pattens lastname = new Pattens();
            Pattens email = new Pattens();
            Pattens number = new Pattens();
            Pattens password = new Pattens();
           
            Console.WriteLine("Name To Enter");
            string Name = Console.ReadLine();
            Console.WriteLine("Last Name To Enter");
            string LastName = Console.ReadLine();
            Console.WriteLine("Email To Enter");
           string Email = Console.ReadLine();
            Console.WriteLine("Number to Enter using Country Code");
            string Number = Console.ReadLine();
            Console.WriteLine("Password To Enter ");
            Console.WriteLine("Must Have Atleat 8 character");
            string Password = Console.ReadLine();


            if (name.ToCheckName(Name) == true)
                Console.WriteLine("Valid Input");
            else
                Console.WriteLine("InValid Input");
            if (lastname.ToCheckLastName(LastName) == true)
                Console.WriteLine("Valid Input");
            else
                Console.WriteLine("InValid Input");
             if (email.ToCheckMail(Email) ==  true)
              Console.WriteLine("Valid Input");
             else
              Console.WriteLine("InValid Input");
            if (number.ToCheckNumber(Number) == true)
                Console.WriteLine("Vaild Input");
            else
                Console.WriteLine("Invalid Input");
            if (password.ToCheckPassword(Password) == true)
                Console.WriteLine("Vaild Input");
            else
                Console.WriteLine("Invalid Input");


        }
    }
}
