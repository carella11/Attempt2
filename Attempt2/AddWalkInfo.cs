using System;

namespace Attempt2
{
    public class AddWalkInfo
    {
        public static void AddWalkData(WalkHistoryPage walkHistoryPage)
        {
            Console.WriteLine("Date: YYYY-MM-DD");
            string addWalkDate = Console.ReadLine();

            Console.WriteLine("Distance: ");
            string addWalkDistance = Console.ReadLine();
            double distanceConverted = Double.Parse(addWalkDistance, System.Globalization.CultureInfo.InvariantCulture);

            walkHistoryPage.AddWalk(addWalkDate, distanceConverted);
        }
    }
}