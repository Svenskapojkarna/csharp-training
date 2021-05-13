using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = new double[3] {12.7, 10.3, 6.11};
            double result = 0.0;

            foreach (double number in numbers)
            {
                result += number;
            }

            Console.WriteLine(Math.Round(result,2));

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
