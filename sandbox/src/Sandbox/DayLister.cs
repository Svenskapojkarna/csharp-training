using System;

namespace Sandbox
{
    public class DayLister
    {
        private string [] daysOfWeek = {
            "Monday",
            "Tuesday",
            "Wedsday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        public void AskForDays()
        {
            int iDay = getWeekDay();
            string chosenDay = daysOfWeek[iDay - 1];
            Console.WriteLine($"That day is {chosenDay}");
        }

        private int getWeekDay()
        {
            int weekDay = 0;
            Console.WriteLine("Which day do you want to display?");
            do
            {
                try
                {
                    Console.Write("(Monday = 1, etc.) > ");
                    weekDay = int.Parse(Console.ReadLine());
                    if (weekDay < 1 || weekDay > 7) {
                        Console.WriteLine("Invalid value! The number should be between 1 to 7.");
                    }
                    else {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid value! The value should be a number between 1 to 7.");
                }
            } while (true);
            return weekDay;
        }

        public void ChangeWeekDay(int index, string newDay)
        {
            daysOfWeek[index] = newDay;
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}