using System;

namespace Attempt2
{
    public class Data
    {
        public string Date { get; private set; }
        public double Distance { get; private set; }

        public Data(string date, double distance)
        {
            Date = date;
            Distance = distance;
        }
        public void printInfo(int id)
        {
            Console.WriteLine("******************************");
            Console.WriteLine($"Walk {id}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Distance: {Distance} km");
        }

        public double CalculateDistance()
        {
            return Distance;
        }
    }
}