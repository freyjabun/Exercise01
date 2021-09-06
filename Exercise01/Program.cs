using System;

namespace Exercise01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintPrompt();
            UserInput();
        }

        public static void Hello_World(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0){
                return true;
            } else if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0){
                return true;
            } else return false;
        }

        public static void UserInput()
        {
            string input = Console.ReadLine();
            int parse;
            bool success = Int32.TryParse(input, out parse);
            if (success) {
                if (parse >= 1582) {
                    if (IsLeapYear(parse)) {
                        Console.WriteLine("yay");
                } else Console.WriteLine("nope");
            } else Console.WriteLine("Leap year function only applies to years from 1582 and up");
            } else Console.WriteLine("Year not recognized, please provide valid year");
        }

        public static void PrintPrompt()
        {
            Console.WriteLine("Enter Year");
        }
    }
}
