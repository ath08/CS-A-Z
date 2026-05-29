using System;

namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter your monthly salary($): ");
            decimal monthlyGrossSalary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Tax %: ");
            double taxRate = double.Parse(Console.ReadLine());

            Console.Write("Enter your monthly expenses($): ");
            decimal monthlyExpenses = decimal.Parse(Console.ReadLine());

            Console.Write("Enter your dream item: ");
            string dreamItemName = Console.ReadLine();

            Console.Write("Enter the price of your dream item($): ");
            decimal priceOfDreamItem = decimal.Parse(Console.ReadLine());

            decimal annualGrossSalary = monthlyGrossSalary * 12;
            decimal monthlyTaxAmount = monthlyGrossSalary * (decimal)taxRate / 100;
            decimal netMonthlySalary = monthlyGrossSalary - monthlyTaxAmount;
            decimal annualNetSalary = netMonthlySalary * 12;
            decimal monthlySaving = netMonthlySalary - monthlyExpenses;
            int monthsNeeded = (int)Math.Ceiling(priceOfDreamItem / monthlySaving);

            if (monthlySaving <= 0)
            {
                Console.WriteLine("\nYour expenses exceed your net salary. You cannot save!");
            }

            int yearsToSave = monthsNeeded / 12;
            int remainingMonths = monthsNeeded % 12;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"SALARY SUMMERY - {fullName}");
            Console.WriteLine($"Gross monthly: {monthlyGrossSalary:C}");
            Console.WriteLine($"Tax (%): {monthlyTaxAmount:C}");
            Console.WriteLine($"Net salary: {netMonthlySalary:C}");
            Console.WriteLine($"Expenses: {monthlyExpenses:C}");
            Console.WriteLine($"Monthly savings: {monthlySaving:C}");
            Console.WriteLine($"Annual salary: {annualGrossSalary:C}, after taxes {annualNetSalary:C}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Dream item: {dreamItemName} {priceOfDreamItem:C}");

            if (yearsToSave > 0)
            {
                Console.WriteLine($"Save for: {yearsToSave:C} year(s) and {remainingMonths:C} month(s)");
            }
            else
            {
                Console.WriteLine($"Save for: {remainingMonths:C} month(s)");
            }
        }
    }
}
