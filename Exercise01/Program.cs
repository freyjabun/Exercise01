using System;

namespace Exercise01
{
    public class Program
    {
        public static void Main(string[] args)
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
    }
}
