using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labday2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N for Fibonacci series:");

            
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.WriteLine($"Fibonacci series with {n} terms:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write(Fibonacci(i) + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
    }

