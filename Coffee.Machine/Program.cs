using Coffee.Machine.Interfaces;
using System;

namespace Coffee.Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome what would you like:");
            Console.WriteLine();
            foreach (var beverage in Enum.GetValues(typeof(BeverageChoices))) {
                Console.WriteLine($"{(int)beverage} {beverage}");
            }
            Console.WriteLine();
            Console.WriteLine("Please enter the number of your beverage choice>");
            Console.ReadLine();
        }
    }
}
