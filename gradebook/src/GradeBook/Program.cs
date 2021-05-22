using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Robert's Grade Book");
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);

            Statistics stats = book.GetStatistics();
            Console.WriteLine($"Information from {InMemoryBook.CATEGORY} GradeBook titled {book.Name}!");
            Console.WriteLine($"Highest grade: {stats.High:N1}");
            Console.WriteLine($"Lowest grade: {stats.Low:N1}");
            Console.WriteLine($"Average of grades: {stats.Average:N1}");
            Console.WriteLine($"the letter grade is: {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.Write("Enter a grade or 'q' to quit: ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    double grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("A grade was added.");
        }
    }
}
