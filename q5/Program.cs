using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to display its multiplication table:");

            
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                Console.WriteLine($"Multiplication table for {number}:");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            Console.ReadLine();
        }
    }
}
