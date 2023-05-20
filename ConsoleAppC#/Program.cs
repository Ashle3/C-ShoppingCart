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
            Console.WriteLine("Please enter the number of the option you would like to perform: ");
            Console.WriteLine();
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. View Cart");
            Console.WriteLine("3. Remove item");
            Console.WriteLine("4. Leave");
        }
        static void PrintItems() //This method/function prints a list of grocery items and their prices
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the number of the item you would like to add: ");
            Console.WriteLine("1. Apples..........$1.99");
            Console.WriteLine("2. Bread...........$3.99");
            Console.WriteLine("3. Milk............$4.99");
            Console.WriteLine("4. Eggs............$5.99");
            Console.WriteLine("5. Orange Juice....$5.99");
        }
        static void Main(string[] args)
        {
            bool programIsRunning = true;
            Console.WriteLine("Welcome to the Grocery Store!");

            while (programIsRunning == true)
            {
                Console.WriteLine();
                PrintOptions();
                Console.WriteLine();

                int userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == 1)
                {
                    PrintItems();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("You have chosen 2");
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("You have chosen 3");
                }
                else if (userChoice == 4)
                {
                    programIsRunning = false;
                    Console.WriteLine("Thank you for shopping with us! Have a nice day!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid number.");
                }
            } //ends the while loop
            //Prevents the program from terminating
            Console.ReadLine();
        }
    }
}
