using System;
using System.IO;

namespace Sandbox.TopTenPops
{
    public class TopTenPopulations
    {
        private string filePath = Path.GetFullPath(@"../../resources/Pop by Largest Final.csv");

        public void PrintPopulations(int amount)
        {
            CsvReader reader = new CsvReader(filePath);
            Country [] countries = reader.ReadFirstNCountries(amount);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}