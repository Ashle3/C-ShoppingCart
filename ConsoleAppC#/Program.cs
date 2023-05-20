using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppC_
{
    internal class Program
    {
        //This method/function prints a list of options every time it's called
        static void PrintOptions()
        {
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. View Cart");
            Console.WriteLine("3. Remove item");
            Console.WriteLine("4. Leave");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grocery Store!");
            Console.WriteLine();
            Console.WriteLine("Enter the number of the option you would like to perform: ");
            Console.WriteLine();
            PrintOptions();
            Console.ReadLine();
        }
    }
}
