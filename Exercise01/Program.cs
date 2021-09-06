using System;

namespace Exercise01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintPrompt();
            LeapYearUserInput();
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

        public static void LeapYearUserInput()
        {
            string input = Console.ReadLine();
            int parse = Int32.Parse(input);
            if (IsLeapYear(parse)) {
                Console.WriteLine("yay");
            } else Console.WriteLine("nope");
        }

        public static void PrintPrompt()
        {
            Console.WriteLine("Enter Year");
        }
    }
}
