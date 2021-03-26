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
           
            Console.WriteLine("Name To Enter");
            string Name = Console.ReadLine();
            Console.WriteLine("Last Name To Enter");
            string LastName = Console.ReadLine();
            Console.WriteLine("email To Enter");
           string Email = Console.ReadLine();
           
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
           

        }
    }
}
