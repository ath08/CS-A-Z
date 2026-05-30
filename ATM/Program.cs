using System;
using System.Collections.Generic;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctPin = 1234;
            int attempts = 0;
            bool access = false;

            while(attempts < 3)
            {
                Console.Write("Enter Your PIN: ");
                int enteredPin = int.Parse(Console.ReadLine());
                

                if (enteredPin == correctPin) {
                    access = true;
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Wrong PIN, {3 - attempts} remaining attempt(s)");
                }
            }

            if (!access)
            {
                Console.WriteLine("Your account blocked");
                return;
            }

            string history1 = "";
            string history2 = "";
            string history3 = "";
            string history4 = "";
            int historyCount = 0;

            double balance = 1000;
            Console.WriteLine($"Welcom! Your initial balance {balance:C}");
            int choice;

            do {
                Console.WriteLine("1.Deposit: ");
                Console.WriteLine("2.Withdrawal");
                Console.WriteLine("3.History: ");
                Console.WriteLine("4.Exit: ");
                Console.Write("Choose an option: ");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.Write("Enter Deposit Amount: ");
                        int deposit = int.Parse(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine($"Entered Deposit {deposit:C}, current balance {balance:C}");

                        if(historyCount == 0)
                        {
                            history1 = $"1.Deposit: {deposit:C}";
                            historyCount++;
                        } else if (historyCount == 1)
                        {
                            history2 = $"2.Deposit: {deposit:C}";
                            historyCount++;
                        } else if (historyCount == 2)
                        {
                            history3 = $"3.Deposit: {deposit:C}";
                            historyCount++;
                        } else if(historyCount == 3)
                        {
                            history4 = $"4.Deposit: {deposit:C}";
                            historyCount++;
                        }
                        break;
                    case 2:
                        Console.Write("Enter Withdrawal Amount: ");
                        int withdrawal = int.Parse(Console.ReadLine());

                        if(withdrawal > balance)
                        {
                            Console.WriteLine("insufficient funds"); 
                        } else
                        {
                            balance -= withdrawal;
                            Console.WriteLine($"Entered Withdrawal {withdrawal:C}, current balanc {balance:C}");

                            if (historyCount == 0)
                            {
                                history1 = $"1.Withdrawal: {withdrawal:C}";
                                historyCount++;
                            }
                            else if (historyCount == 1)
                            {
                                history2 = $"2.Withdrawal: {withdrawal:C}";
                                historyCount++;
                            }
                            else if (historyCount == 2)
                            {
                                history3 = $"3.Withdrawal: {withdrawal:C}";
                                historyCount++;
                            }
                            else if (historyCount == 3)
                            {
                                history4 = $"4.Withdrawal: {withdrawal:C}";
                                historyCount++;
                            }
                        }
                        break;
                    case 3:
                        if(historyCount == 0)
                        {
                            Console.WriteLine("NO DATA");
                        } else
                        {
                            if (historyCount >= 1) { Console.WriteLine(history1); }
                            if (historyCount >= 2) { Console.WriteLine(history2); }
                            if (historyCount >= 3) { Console.WriteLine(history3); }
                            if (historyCount >= 4) { Console.WriteLine(history4); }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exit!");
                        break;
                    default:
                        Console.WriteLine("Invalid output");
                        break;
                }

            } while (choice != 4);
        }
    }
}