using System;

namespace bankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal initialBalance = 1000;
            int correctPin = 1234;
            int attempts = 0;
            bool access = false;

            while (attempts < 3)
            {
                Console.Write("Enter Your PIN: ");
                int pin = int.Parse(Console.ReadLine());

                if (pin == correctPin)
                {
                    access = true;
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Wrong pin. {3 - attempts} attempts remaining.");
                }
            } 

            if (!access) 
            {
                Console.WriteLine("Your account blocked!");
                return;
            }

            string history1 = "";
            string history2 = "";
            string history3 = "";
            string history4 = "";
            int historyCount = 0;

            Console.WriteLine($"Welcome! Your initial balance {initialBalance:C}");

            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawal");
                Console.WriteLine("3. History");
                Console.WriteLine("4. Exit"); 
                Console.Write("Your Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Deposit Amount: ");
                        decimal deposit = decimal.Parse(Console.ReadLine());
                        initialBalance += deposit;
                        Console.WriteLine($"Deposit {deposit:C}. New balance: {initialBalance:C}");

                        historyCount++;
                        if (historyCount == 1)
                            history1 = $"Deposit: {deposit:C}";
                        else if (historyCount == 2)
                            history2 = $"Deposit: {deposit:C}";
                        else if (historyCount == 3)
                            history3 = $"Deposit: {deposit:C}";
                        else if (historyCount == 4)
                            history4 = $"Deposit: {deposit:C}";
                        break;

                    case 2:
                        Console.Write("Enter Withdrawal amount: "); 
                        decimal withdrawal = decimal.Parse(Console.ReadLine());

                        if (withdrawal > initialBalance)
                        {
                            Console.WriteLine("Insufficient funds!");
                        }
                        else
                        {
                            initialBalance -= withdrawal;
                            Console.WriteLine($"Withdrawal {withdrawal:C}. New balance: {initialBalance:C}");

                            historyCount++;
                            if (historyCount == 1)
                                history1 = $"Withdrawal: {withdrawal:C}";
                            else if (historyCount == 2)
                                history2 = $"Withdrawal: {withdrawal:C}";
                            else if (historyCount == 3)
                                history3 = $"Withdrawal: {withdrawal:C}";
                            else if (historyCount == 4)
                                history4 = $"Withdrawal: {withdrawal:C}";
                        }
                        break; 

                    case 3:
                        Console.WriteLine("--- History ---");
                        if (historyCount == 0)
                            Console.WriteLine("No Data");
                        if (historyCount >= 1)
                            Console.WriteLine($"1. {history1}");
                        if (historyCount >= 2)
                            Console.WriteLine($"2. {history2}");
                        if (historyCount >= 3)
                            Console.WriteLine($"3. {history3}");
                        if (historyCount >= 4)
                            Console.WriteLine($"4. {history4}");
                        break;

                    case 4: 
                        Console.WriteLine("Good Bye!");
                        return; 

                    default: 
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}