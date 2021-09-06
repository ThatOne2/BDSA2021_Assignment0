using System;

namespace Assignment00
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");*/
            Console.WriteLine("Enter a year to see if it is a leap year:");
            UserSpecifiedYear(UserInput.GetYearFromUser());
            
        }

        public static void UserSpecifiedYear(int year) {
            if(IsLeapYear(year)) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
        }
        public static bool IsLeapYear(int year) 
        {
            if (year % 4 == 0)  {
                if(year % 100 != 0 || year % 400 == 0) {
                   return true; 
                }
                else {
                    return false;
                }
            } else {
                return false;
            }
        }
    }
}
//Run by: dotnet run -p .\Assignment00\ 
