using Sandbox.TopTenPops;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            DayLister dayLister = new DayLister();
            TopTenPopulations topTenPopulations = new TopTenPopulations();
            //dayLister.ChangeWeekDay(2, "Wednesday");
            //dayLister.AskForDays();
            topTenPopulations.PrintPopulations(10);
        }
    }
}
