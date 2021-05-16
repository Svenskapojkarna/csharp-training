using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Robert's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            Statistics stats = book.GetStatistics();
            Console.WriteLine($"Highest grade: {stats.High:N1}");
            Console.WriteLine($"Lowest grade: {stats.Low:N1}");
            Console.WriteLine($"Average of grades: {stats.Average:N1}");
        }
    }
}
