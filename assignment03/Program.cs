using System;

namespace assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Show menu
            //Example from: https://wellsb.com/csharp/beginners/create-menu-csharp-console-application/
            bool showMenu = true;

            while (showMenu) {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu() {
            String returnString = "";

            Console.Clear();
            //Show menu options
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Display Top Counties");
            Console.WriteLine("2) County where delta is greater than x");
            Console.WriteLine("3) Case county prediction");
            Console.WriteLine("Q) Exit");

            switch (Console.ReadLine().ToUpper()) {
                case "1":
                    returnString = topCounties();
                    Console.WriteLine(returnString);
                    Console.ReadLine();
                    return true;
                case "2":
                    returnString = deltaGreater();
                    Console.WriteLine(returnString);
                    Console.ReadLine();
                    return true;
                case "3":
                    returnString = casePrediction();
                    Console.WriteLine(returnString);
                    Console.ReadLine();
                    return true;
                case "Q":
                    return false;
                default:
                    return true;
            }
        }

        public static String topCounties()
        {
            return "Display top N county dates and case deltas information";
        }
        public static String deltaGreater()
        {
            return "First county where delta cases per capita is greater than a given number";
        }
        public static String casePrediction()
        {
            return "Case county prediction";
        }
    }
}
