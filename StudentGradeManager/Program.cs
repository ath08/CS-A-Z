using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students there are?: ");
            int studentsCount = int.Parse(Console.ReadLine());

            List<string> studentsNames = new List<string>();
            List<int> studentsScore = new List<int>();

            for(int i = 0; i < studentsCount; i++)
            {
                Console.Write($"Enter {i + 1} student's name: ");
                string studentName = Console.ReadLine();
                studentsNames.Add(studentName);

                Console.Write($"Enter {i + 1} student's score: ");
                int studentScore = int.Parse(Console.ReadLine());
                studentsScore.Add(studentScore);
            }

            Console.WriteLine($"Average of Score: {studentsScore.Average():F1}");
            Console.WriteLine($"Min Score: {studentsScore.Min()}");
            Console.WriteLine($"Max Score: {studentsScore.Max()}");
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < studentsCount; i++)
            {
                if (studentsScore[i] >= 60)
                {
                    Console.WriteLine($"pass: {studentsNames[i]} - {studentsScore[i]}");
                }
            }
        }
    }
}
