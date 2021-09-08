using System;

namespace Assignment00
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");*/
            Console.WriteLine("Enter a year to see if it is a leap year:");
            try {
                UserSpecifiedYear(UserInput.GetYearFromUser());
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            

            //Console.WriteLine("Please write the year in numbers only");
        
        }  

        public static void UserSpecifiedYear(int year) {
        
            try {
               if(year < 1582) { 
                throw new ArgumentException("Year has to be 1582 or bigger");
            }
            if(IsLeapYear(year)) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            } 
            } catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            
        }
        public static bool IsLeapYear(int year) 
        {
            if (year % 4 == 0)  { //Tests if "normal" leap year
                if(year % 100 != 0 || year % 400 == 0) { //Tests special cases of leap years
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
//dotnet nuget locals all --clear
