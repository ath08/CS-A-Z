using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Input ---
        Console.Write("Enter your full name: ");
        string name = Console.ReadLine();

        Console.Write("Enter birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        Console.Write("Enter birth month (1-12): ");
        int birthMonth = int.Parse(Console.ReadLine());

        Console.Write("Enter birth day (1-31): ");
        int birthDay = int.Parse(Console.ReadLine());

        int currentYear = DateTime.Now.Year;
        int currentMonth = DateTime.Now.Month;
        int currentDay = DateTime.Now.Day;

        int ageYears = currentYear - birthYear;
        int ageMonths = ageYears * 12 + (currentMonth - birthMonth);
        long ageDays = ageYears * 365L;
        long ageHours = ageDays * 24;
        int turns100 = birthYear + 100;

        DateTime today = DateTime.Now;
        DateTime nextBirthday = new DateTime(currentYear, birthMonth, birthDay);
        if (nextBirthday <= today)
        { 
            nextBirthday = nextBirthday.AddYears(1); 
        }
        int daysUntilBirthday = (nextBirthday - today).Days;

        Console.WriteLine($"\n------------------------------");
        Console.WriteLine($" AGE DETECTIVE — {name}");
        Console.WriteLine($"------------------------------");
        Console.WriteLine($" Born        : {birthDay} / {birthMonth} / {birthYear}");
        Console.WriteLine($" Age         : {ageYears} years");
        Console.WriteLine($" In months   : {ageMonths} months");
        Console.WriteLine($" In days     : ~{ageDays:N0} days");
        Console.WriteLine($" In hours    : ~{ageHours:N0} hours");
        Console.WriteLine($"──────────────────────────────");
        Console.WriteLine($" Turns 100   : year {turns100}");

        if (daysUntilBirthday == 0)
            Console.WriteLine($" Happy Birthday, {name}!");
        else
            Console.WriteLine($" Next Birthday  : ~{daysUntilBirthday} days away");

        DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
        Console.WriteLine($" Born on     : {birthDate.DayOfWeek}");
    }
}