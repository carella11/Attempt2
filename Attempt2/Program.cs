using System;
using System.IO;

namespace Attempt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var WalkHistoryPage = CreateWalkHistoryPage();

            while (true)
            {
                MenuText.ShowMenuText(WalkHistoryPage);
            }
        }
        public static WalkHistoryPage CreateWalkHistoryPage()
        {
            //string filePath = "C:\Users\GET Academy\Desktop\Modul 3 Prosjekter\Attempt2\Attempt2\myWalks – Kopi.txt";
            string filePath = "../../../myWalks – Kopi.txt";
            var WalkHistoryPage = new WalkHistoryPage();

            foreach (string s in File.ReadLines(filePath))
            {
                string[] userInput = s.Split(',');
                var stringToDouble = userInput[1];
                var kmWalked = Double.Parse(stringToDouble, System.Globalization.CultureInfo.InvariantCulture);
                WalkHistoryPage.AddWalk(userInput[0], kmWalked);
            }
            return WalkHistoryPage;
        }
    }
}
