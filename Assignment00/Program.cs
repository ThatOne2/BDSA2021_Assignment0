﻿using System;

namespace Assignment00
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
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