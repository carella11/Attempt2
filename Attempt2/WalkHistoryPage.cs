using System;
using System.Collections.Generic;

namespace Attempt2
{
    public class WalkHistoryPage
    {
        public List<Data> ListWalkData { get; set; }
        public WalkHistoryPage()
        {
            ListWalkData = new List<Data>();
        }

        public void ShowHistory()
        {
            var totalDistance = 0.0;
            var id = 1;

            foreach (var Walk in ListWalkData)
            {
                Walk.printInfo(id);
                id++;
                totalDistance = totalDistance + Walk.CalculateDistance();
            }
            Console.WriteLine("*********************");
            Console.WriteLine($"Nice Work! You've walked a total distance of {totalDistance} km");
            Console.WriteLine("*********************");
        }
        public void AddWalk(string addWalkDate, double distanceConverted)
        {
            ListWalkData.Add(new Data(addWalkDate, distanceConverted));
        }
    }
}