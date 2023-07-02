using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            string seriesType;

            // Ask the user to enter an integer value between 1 and 100
            Console.WriteLine("Enter an integer value between 1 and 100:");
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 100)
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 100:");
            }

            // Ask the user to specify a series of integer numbers (even or odd)
            Console.WriteLine("Specify a series of integer numbers (even or odd):");
            while (true)
            {
                seriesType = Console.ReadLine().Trim().ToLower();
                if (seriesType == "even" || seriesType == "odd")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'even' or 'odd':");
                }
            }

            // Display the selected series and the numbers within the range
            Console.WriteLine($"You have selected the {seriesType} series. The numbers between 0 and {userInput} are:");
            if (seriesType == "even")
            {
                for (int i = 0; i <= userInput; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 1; i <= userInput; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
