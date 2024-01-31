using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's name:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter exam marks:");

            
            if (int.TryParse(Console.ReadLine(), out int marks) && marks >= 0 && marks <= 100)
            {
                string grade = CalculateGrade(marks);

                Console.WriteLine($"Student Name: {studentName}");
                Console.WriteLine($"Grade: {grade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid marks value between 0 and 100.");
            }

            Console.ReadLine(); 
        }

        static string CalculateGrade(int marks)
        {
            if (marks >= 75 && marks <= 100)
            {
                return "Grade A";
            }
            else if (marks >= 60 && marks <= 74)
            {
                return "Grade B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                return "Grade C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                return "Grade D";
            }
            else
            {
                return "Failed";
            }
        }
    }
    }

