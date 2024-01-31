using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7
{
    internal class Program
    {
       
    static double balance = 1000; 

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Check Balance\n2. Deposit Money\n3. Withdraw Money\n4. Exit");
                Console.Write("Enter your choice (1-4): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1: Console.WriteLine($"Your current balance is: ${balance}"); break;
                        case 2: DepositMoney(); break;
                        case 3: WithdrawMoney(); break;
                        case 4: Console.WriteLine("Exiting ATM. Thank you!"); return;
                        default: Console.WriteLine("Invalid choice! Please enter a number between 1 and 4."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.WriteLine(); 
            }
        }

        static void DepositMoney()
        {
            Console.Write("Enter the amount to deposit: $");

            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposit successful. Your new balance is: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid positive amount.");
            }
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: $");

            if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Withdrawal canceled.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid positive amount.");
            }
        }
    }
}

