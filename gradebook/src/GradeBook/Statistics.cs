using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch(Average)
                {
                    case double average when average >= 90.0:
                        return 'A';
                    case double average when average >= 80.0:
                        return 'B';
                    case double average when average >= 70.0:
                        return 'C';
                    case double average when average >= 60.0:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        public double Sum;
        public int Count;

        public void Add(double number)
        {
            Sum += number;
            Count++;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}