using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattens name = new Pattens();
            Console.WriteLine("Enter Name To Enter");
            string Name = Console.ReadLine();
            if (name.ToCheckName(Name) == true)
                Console.WriteLine("Valid Input");
            else
                Console.WriteLine("InValid Input");

        }
    }
}
